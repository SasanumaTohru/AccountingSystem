using System;
using System.Linq;
using 会計システム.Domain.BusinessObject.会計伝票;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム.ApplicationService
{
    class 会計伝票構築サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <returns></returns>
        public 伝票 伝票を構築する(string 伝票番号)
        {
            using (var MyDB = new Infrastructure.AccountingDBEntities())
            {
                var rs伝票 = MyDB.T_会計伝票.Where(o => o.伝票番号 == 伝票番号);
                if (rs伝票.Count() == 0)
                {
                    throw new Exception("指定された伝票番号に一致する会計伝票はありません。");
                }
                var 年月内伝票番号 = new 自然数(int.Parse(伝票番号.Substring(7, 5)));
                var 伝票日付 = new 日付(rs伝票.First().計上日);
                var 検索した伝票番号 = new 番号(年月内伝票番号, 伝票日付);
                var 検索した伝票 = new 伝票(検索した伝票番号, 伝票日付);

                var rs仕訳 = MyDB.T_仕訳.Where(o => o.伝票番号 == 検索した伝票.番号.値);
                var 仕訳ビルド = new 仕訳構築サービス();
                foreach(var item in rs仕訳)
                {
                    仕訳ビルド.追加する(item.勘定科目コード, item.金額, item.摘要, item.貸借);
                }
                foreach(仕訳 item in 仕訳ビルド.リスト)
                {
                    検索した伝票.追加する(item);
                }
                return 検索した伝票;
            }
        }
    }
}
