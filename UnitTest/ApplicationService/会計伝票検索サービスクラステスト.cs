using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.ApplicationService
{
    [TestClass]
    public class 会計伝票検索サービスクラステスト
    {
        AccountingSystem.ApplicationService.会計伝票検索サービス 伝票検索 = new AccountingSystem.ApplicationService.会計伝票検索サービス();

        [TestMethod]
        public void 伝票番号で検索する()
        {
            AccountingSystem.Domain.BusinessObject.会計伝票.伝票 検索した伝票 = 伝票検索.伝票番号で検索する("201705-00001");
            Assert.AreEqual("201705-00001", 検索した伝票.番号.値);
            Assert.AreEqual(123m, 検索した伝票.貸方.合計金額.値);
        }

        [TestMethod]
        public void 日付で検索する()
        {
            var ヒットリスト = 伝票検索.計上日で検索する(new DateTime(2017, 4, 1));
            Assert.AreEqual(1, ヒットリスト.Count);
        }

        [TestMethod]
        public void 勘定科目で検索する()
        {
            var ヒットリスト = 伝票検索.勘定科目で検索する(401030);
            Assert.AreEqual(1, ヒットリスト.Count);
        }
    }
}
