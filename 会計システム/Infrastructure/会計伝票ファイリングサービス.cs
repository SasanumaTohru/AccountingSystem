using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 会計システム.Domain.PrimitiveObject;
using 会計システム.Domain.BusinessObject.会計伝票;

namespace 会計システム.Infrastructure
{
    class 会計伝票ファイリングサービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <returns></returns>
        public 伝票 記帳した伝票を取得する(日付 計上日)
        {
            using (var MyDB =new AccountingDBEntities())
            {
                var rs = from o in MyDB.T_会計伝票 where o.伝票番号.Substring(0, 6) == 計上日.西暦年月文字列6桁 select o.伝票番号;
                string 既存伝票番号の最大値 = rs.Max();

                番号 新しい伝票番号 = 伝票番号を採番する(計上日, 既存伝票番号の最大値);

                伝票 新しい会計伝票 = new 伝票(新しい伝票番号, 計上日);
                if (新しい会計伝票.貸借金額不一致)
                {
                    throw new Exception("貸借の金額が一致していないため、伝票の登録を中止します。");
                }

                T_会計伝票 会計伝票ファイル = new T_会計伝票()
                {
                    伝票番号 = 新しい会計伝票.番号.値,
                    計上日 = 新しい会計伝票.計上日.値
                };
                MyDB.T_会計伝票.Add(会計伝票ファイル);
                MyDB.SaveChanges();

                return 新しい会計伝票;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <param name="既存伝票番号の最大値"></param>
        /// <returns></returns>
        private static 番号 伝票番号を採番する(日付 計上日, string 既存伝票番号の最大値)
        {
            自然数 新しい年月内伝票番号 = new 自然数(1);
            if (string.IsNullOrEmpty(既存伝票番号の最大値) == false)
            {
                新しい年月内伝票番号 = new 自然数(年月内伝票番号をインクリメントする(既存伝票番号の最大値));
            }
            番号 新しい伝票番号 = new 番号(新しい年月内伝票番号, 計上日);
            return 新しい伝票番号;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="既存伝票番号の最大値"></param>
        /// <returns></returns>
        private static int 年月内伝票番号をインクリメントする(string 既存伝票番号の最大値)
        {
            int 年月内伝票番号 = int.Parse(既存伝票番号の最大値.Substring(7, 5));
            return 年月内伝票番号 + 1;
        }
    }
}
