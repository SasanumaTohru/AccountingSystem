using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class 検討用
    {
        [TestMethod]
        public void foo()
        {
            //勘定科目 現金　111030　の期末残高を集計する
            var 会計年度 = new AccountingSystem.Domain.BusinessObject.会計年度(2017, 4);

            using (var MyDB = new AccountingSystem.Infrastructure.AccountingDBEntities())
            {
                var 有効伝票リスト = MyDB.T_会計伝票
                    .Where(o => (会計年度.期間.開始日.値 <= o.計上日 | o.計上日 <= 会計年度.期間.開始日.値) &
                    o.伝票区分 == 1 & o.訂正有無 == false);

                var 集計対象仕訳リスト = new List<AccountingSystem.Infrastructure.T_仕訳>();
                foreach (var item in 有効伝票リスト)
                {
                    var 集計対象仕訳 = MyDB.T_仕訳.Where(o => o.伝票番号 == item.伝票番号 & o.勘定科目コード == 111030);
                    foreach (var p in 集計対象仕訳)
                    {
                        集計対象仕訳リスト.Add(p);
                    }
                }

                var 借方金額 = 集計対象仕訳リスト.Where(o => o.貸借 == 1).Select(o => o.金額);
                var 貸方金額 = 集計対象仕訳リスト.Where(o => o.貸借 == 2).Select(o => o.金額);
                Assert.AreEqual(700m, 借方金額.Max() - 貸方金額.Max());

            }




        }

    }
}
