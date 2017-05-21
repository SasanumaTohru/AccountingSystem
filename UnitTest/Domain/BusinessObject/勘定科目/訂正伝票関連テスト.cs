using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.PrimitiveObject;

namespace UnitTest.Domain.BusinessObject.勘定科目
{
    [TestClass]
    public class 訂正伝票関連テスト
    {
        [TestMethod]
        public void TestMethod1()
        {
            var 計上日 = new 日付(2017, 4, 1);
            var 元伝票番号 = new 番号(new 自然数(1), 計上日);
            var 元伝票 = new 伝票(元伝票番号, 計上日);
            var 貸方仕訳1勘定科目 = new 科目(new コード(1), new 名称("現金"));
            var 貸方仕訳1 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("a"), new 金額(1080), 仕訳.貸借区分.貸方);
            var 借方仕訳1勘定科目 = new 科目(new コード(2), new 名称("消耗品費"));
            var 借方仕訳1 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("b"), new 金額(1000), 仕訳.貸借区分.借方);
            var 借方仕訳2勘定科目 = new 科目(new コード(3), new 名称("仮払消費税"));
            var 借方仕訳2 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("c"), new 金額(80), 仕訳.貸借区分.借方);
            元伝票.追加する(貸方仕訳1);
            元伝票.追加する(借方仕訳1);
            元伝票.追加する(借方仕訳2);
            
            var 訂正伝票 = 元伝票.訂正伝票を用意する();

            //元伝票
            Assert.AreEqual("201704-00001", 元伝票.番号.値);
            Assert.AreEqual(0, 元伝票.貸借金額差額.絶対値);
            Assert.AreEqual(1, 元伝票.貸方.リスト.Count);
            Assert.AreEqual(2, 元伝票.借方.リスト.Count);

            //訂正伝票
            Assert.AreEqual("201705-00000", 訂正伝票.番号.値);
            Assert.AreEqual(0, 訂正伝票.貸借金額差額.絶対値);
            Assert.AreEqual(2, 訂正伝票.貸方.リスト.Count);
            Assert.AreEqual(1, 訂正伝票.借方.リスト.Count);

            //伝票比較
            Assert.AreEqual(訂正伝票.貸方.リスト.Count, 元伝票.借方.リスト.Count);
            Assert.AreEqual(訂正伝票.借方.リスト.Count, 元伝票.貸方.リスト.Count);

            //Assert.AreEqual(true, foo.訂正伝票の有無(元伝票.番号));
            

        }
    }
}
