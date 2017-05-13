using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    [TestCategory("基本テスト")]
    public class 整数クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            AccountingSystem.Domain.PrimitiveObject.整数 数値 = new AccountingSystem.Domain.PrimitiveObject.整数(77);
            Assert.AreEqual(77, 数値.値);
        }
    }
}
