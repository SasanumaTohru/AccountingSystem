using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.PrimitiveObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.BusinessObject.勘定科目
{
    [TestClass]
    public class 仕訳列クラステスト
    {
        [TestMethod]
        public void すべての仕訳の合計金額()
        {
            var 仕訳列 = new 仕訳列();
            Assert.AreEqual(0m, 仕訳列.合計金額.値);
            Assert.AreEqual(0m, 仕訳列.貸借別合計金額を取得する(AccountingSystem.Domain.BusinessObject.会計伝票.仕訳列.貸借区分リスト.借方).値);
            Assert.AreEqual(0m, 仕訳列.貸借別合計金額を取得する(AccountingSystem.Domain.BusinessObject.会計伝票.仕訳列.貸借区分リスト.貸方).値);
            var 貸方仕訳1勘定科目 = new 科目(new コード(111030), new 名称("現金"));
            var 貸方仕訳1 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("a"), new 金額(1080), 仕訳.貸借区分.貸方);
            仕訳列.追加する(貸方仕訳1);
            Assert.AreEqual(1, 仕訳列.リスト.Count);
            Assert.AreEqual(1080m, 仕訳列.合計金額.値);
        }
    }
}
