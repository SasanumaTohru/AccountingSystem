﻿using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.PrimitiveObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountingSystem.Infrastructure
{
    public class RepositoryImplementation会計伝票
    {
        private List<T_会計伝票> m_伝票リスト = new List<T_会計伝票>();
        private List<string> m_伝票番号リスト = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <returns></returns>
        public T_会計伝票 伝票番号で検索する(string 伝票番号)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_会計伝票.Where(o => o.伝票番号 == 伝票番号);
                if (rs.Count() == 0)
                {
                    throw new Exception("指定された伝票番号に一致する会計伝票はありません。");
                }
                return rs.First();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        public List<T_会計伝票> 計上日で検索する(DateTime 計上日)
        {
            m_伝票リスト.Clear();
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_会計伝票.Where(o => o.計上日 == 計上日);
                return rs.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="開始日"></param>
        /// <param name="終了日"></param>
        /// <returns></returns>
        public List<T_会計伝票> 期間で検索する(DateTime 開始日, DateTime 終了日)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_会計伝票.Where(o => (開始日 <= o.計上日 & o.計上日 <= 終了日) & o.伝票区分 == 1 & o.訂正有無 == false);
                return rs.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <returns></returns>
        public List<string> 勘定科目で検索する(int 勘定科目コード)
        {
            m_伝票番号リスト.Clear();
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_仕訳.Where(o => o.勘定科目コード == 勘定科目コード).GroupBy(p => p.伝票番号);
                foreach (var p in rs)
                {
                    m_伝票番号リスト.Add(p.Key);
                }
            }
            return m_伝票番号リスト;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <returns></returns>
        private string 月内最終伝票番号を取得する(日付 計上日)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_会計伝票.Where(p => p.伝票番号.Substring(0, 6) == 計上日.西暦年月文字列6桁).Select(p => p.伝票番号);
                return rs.Max();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <param name="月内最終伝票番号"></param>
        /// <returns></returns>
        private 伝票番号 伝票番号を採番する(日付 計上日)
        {
            string 月内最終伝票番号 = 月内最終伝票番号を取得する(計上日);
            自然数 新しい年月内伝票番号;

            switch (同一年月に伝票がある(月内最終伝票番号))
            {
                case true:
                    新しい年月内伝票番号 = new 自然数(年月内伝票番号をインクリメントする(月内最終伝票番号));
                    break;
                default:
                    新しい年月内伝票番号 = new 自然数(1);
                    break;
            }
            var 新しい伝票番号 = new 伝票番号(新しい年月内伝票番号, 計上日);
            return 新しい伝票番号;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票"></param>
        /// <returns></returns>
        internal 伝票 伝票を保存する(伝票 伝票)
        {
            伝票番号 新しい伝票番号 = 伝票番号を採番する(伝票.計上日);
            伝票 保存する伝票 = 伝票.伝票番号を変更したコピーを作成する(新しい伝票番号);
            using (var MyDB = new AccountingDBEntities())
            {
                int 仕訳番号 = 1;
                foreach (仕訳 item in 保存する伝票.すべての仕訳.リスト)
                {
                    //仕訳
                    var 仕訳 = new T_仕訳()
                    {
                        伝票番号 = 保存する伝票.番号.値,
                        仕訳番号 = 仕訳番号++,
                        勘定科目コード = item.勘定科目.コード.値,
                        金額 = item.金額.値,
                        摘要 = item.摘要.値,
                        貸借 = (int)item.貸借,
                    };
                    MyDB.T_仕訳.Add(仕訳);
                }

                //伝票
                var 会計伝票ファイル = new T_会計伝票()
                {
                    伝票番号 = 保存する伝票.番号.値,
                    計上日 = 保存する伝票.計上日.値,
                    訂正有無 = 保存する伝票.伝票情報.訂正伝票がある,
                    伝票区分 = (int)保存する伝票.伝票情報.伝票区分,
                    対応伝票番号 = 保存する伝票.伝票情報.対応伝票番号
                };
                MyDB.T_会計伝票.Add(会計伝票ファイル);

                if (保存する伝票.伝票情報.伝票区分 == 伝票情報.伝票区分リスト.訂正伝票)
                {
                    元伝票を訂正済みにする(保存する伝票, MyDB);
                }

                MyDB.SaveChanges();
            }
            return 保存する伝票;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="保存する伝票"></param>
        /// <param name="MyDB"></param>
        private void 元伝票を訂正済みにする(伝票 保存する伝票, AccountingDBEntities MyDB)
        {
            var 訂正元伝票 = MyDB.T_会計伝票.Where(o => o.伝票番号 == 保存する伝票.伝票情報.対応伝票番号);
            訂正元伝票.First().訂正有無 = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="月内最終伝票番号"></param>
        /// <returns></returns>
        private bool 同一年月に伝票がある(string 月内最終伝票番号)
        {
            return string.IsNullOrEmpty(月内最終伝票番号) == false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="月内最終伝票番号"></param>
        /// <returns></returns>
        private int 年月内伝票番号をインクリメントする(string 月内最終伝票番号)
        {
            int 年月内伝票番号 = int.Parse(月内最終伝票番号.Substring(7, 5));
            return ++年月内伝票番号;
        }

    }
}
