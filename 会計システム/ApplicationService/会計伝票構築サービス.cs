using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var rs伝票 = from o in MyDB.T_会計伝票 where o.伝票番号 == 伝票番号 select o;

                if(rs伝票.Count() == 0)
                {
                    throw new Exception("指定された伝票番号に一致する会計伝票はありません。");
                }
                自然数 年月内伝票番号 = new 自然数(int.Parse(伝票番号.Substring(7, 5)));
                日付 伝票日付 = new 日付(rs伝票.First().計上日);
                番号 検索した伝票番号 = new 番号(年月内伝票番号, 伝票日付);
                伝票 検索した伝票 = new 伝票(検索した伝票番号, 伝票日付);

                var rs仕訳 = from o in MyDB.T_仕訳 where o.伝票番号 == 検索した伝票.番号.値 select o;
                ApplicationService.仕訳構築サービス 仕訳ビルド = new 仕訳構築サービス();
                foreach(var o in rs仕訳)
                {
                    仕訳ビルド.追加する(o.勘定科目コード, o.金額, o.摘要, o.貸借);
                }
                foreach(仕訳 q in 仕訳ビルド.リスト)
                {
                    検索した伝票.追加する(q);
                }
                return 検索した伝票;
            }
        }
    }
}
