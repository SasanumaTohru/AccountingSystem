using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    [TestCategory("基本テスト")]
    public class 金額クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            会計システム.Domain.PrimitiveObject.金額 価格 = new 会計システム.Domain.PrimitiveObject.金額(999999);
            Assert.AreEqual(999999, 価格.値);    //暗黙変換して評価される。
            Assert.AreEqual(999999m, 価格.値);
            Assert.AreEqual("999,999", 価格.桁区切り値);
            価格 = new 会計システム.Domain.PrimitiveObject.金額(-999999);
            Assert.AreEqual("△999,999", 価格.桁区切り値);
        }
    }
}
