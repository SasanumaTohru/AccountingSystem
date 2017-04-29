using Microsoft.VisualStudio.TestTools.UnitTesting;
using 会計システム.Domain.FoundationObject;
using 会計システム.Domain.PrimitiveObject;

namespace UnitTest.Domain.FoundationObject
{
    [TestClass]
    public class 消費税課税金額クラステスト
    {
        [TestMethod]
        [TestCategory("基本テスト")]
        public void 基本テスト()
        {
            消費税課税金額 課税取引1 = new 消費税課税金額(new 金額(100), 消費税課税金額.計算方法.課税対象金額);
            Assert.AreEqual(100m, 課税取引1.課税対象金額.値);
            Assert.AreEqual(8m, 課税取引1.消費税額.値);
            Assert.AreEqual(108m, 課税取引1.税込金額.値);
            Assert.AreEqual(0.08m, 課税取引1.税率.値);

            消費税課税金額 課税取引2 = new 消費税課税金額(new 金額(108), 消費税課税金額.計算方法.税込金額);
            Assert.AreEqual(100m, 課税取引2.課税対象金額.値);
            Assert.AreEqual(8m, 課税取引2.消費税額.値);
            Assert.AreEqual(108m, 課税取引2.税込金額.値);
            Assert.AreEqual(0.08m, 課税取引2.税率.値);

            消費税課税金額 課税取引3 = new 消費税課税金額(new 金額(12345), 消費税課税金額.計算方法.課税対象金額);
            Assert.AreEqual(12345m, 課税取引3.課税対象金額.値);
            Assert.AreEqual(987m, 課税取引3.消費税額.値);
            Assert.AreEqual(13332m, 課税取引3.税込金額.値);
            Assert.AreEqual(0.08m, 課税取引3.税率.値);

            消費税課税金額 課税取引4 = new 消費税課税金額(new 金額(13332), 消費税課税金額.計算方法.税込金額);
            Assert.AreEqual(12345m, 課税取引4.課税対象金額.値);
            Assert.AreEqual(987m, 課税取引4.消費税額.値);
            Assert.AreEqual(13332m, 課税取引4.税込金額.値);
            Assert.AreEqual(0.08m, 課税取引4.税率.値);

        }
    }
}
