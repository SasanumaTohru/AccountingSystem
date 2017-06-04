using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.BusinessObject.財務諸表;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class 検討用
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void 合計残高試算表のテスト()
        {
            var 合計残高試算表 = new AccountingSystem.ApplicationService.合計残高試算表参照サービス();
            勘定科目別残高を表示する(合計残高試算表.勘定科目別残高リスト(new 会計年度(2017,4)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="合計残高試算表"></param>
        private static void 勘定科目別残高を表示する(合計残高試算表 合計残高試算表)
        {
            foreach (var p in 合計残高試算表.リスト)
            {
                Debug.WriteLine(p.勘定科目と金額);
            }
        }


    }
}