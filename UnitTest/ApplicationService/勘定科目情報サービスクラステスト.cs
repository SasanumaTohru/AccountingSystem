using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTest.ApplicationService
{
    [TestClass]
    public class 勘定科目情報サービスクラステスト
    {
        [TestMethod]
        public void すべての勘定科目()
        {
            var 勘定科目情報サービス = new AccountingSystem.ApplicationService.勘定科目情報サービス();
            var 勘定科目 = 勘定科目情報サービス.すべての勘定科目リスト;
            foreach (var p in 勘定科目)
            {
                Debug.WriteLine(p.コードと名称.値);
            }
        }


        
    }
}
