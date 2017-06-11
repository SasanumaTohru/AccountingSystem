using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.Domain.PrimitiveObject;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using System.Collections.ObjectModel;

namespace UnitTest.ApplicationService
{
    [TestClass]
    public class 会計伝票検索サービスクラステスト
    {
        AccountingSystem.ApplicationService.会計伝票検索サービス 伝票検索 = new AccountingSystem.ApplicationService.会計伝票検索サービス();

        [TestMethod]
        public void 伝票番号で検索する()
        {
            伝票 検索した伝票 = 伝票検索.伝票番号で検索する("201704-00001");
            Assert.AreEqual("201704-00001", 検索した伝票.番号.値);
            //Assert.AreEqual(1080m, 検索した伝票.貸方.合計金額.値);
        }

        [TestMethod]
        public void 日付で検索する()
        {
            ReadOnlyCollection<伝票> ヒットリスト = 伝票検索.計上日で検索する(new DateTime(2017, 4, 1));
            Assert.AreEqual(1, ヒットリスト.Count);
        }

        [TestMethod]
        public void 勘定科目で検索する()
        {
            ReadOnlyCollection<伝票> ヒットリスト = 伝票検索.勘定科目で検索する(113030);
            Assert.AreEqual(1, ヒットリスト.Count);
        }

        [TestMethod]
        public void 期間で検索する()
        {
            var 期間 = new AccountingSystem.Domain.FoundationObject.期間(new 日付(2017, 4, 1), new 日付(2018, 3, 31));
            var ヒットリスト = 伝票検索.期間で検索する(期間);
            Assert.AreEqual(1, ヒットリスト.Count);
        }
    }
}
