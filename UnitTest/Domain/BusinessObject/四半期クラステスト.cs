using AccountingSystem.Domain.BusinessObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.BusinessObject
{
    [TestClass]
    public class 四半期クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            var 四半期 = new 四半期(4);
            Assert.AreEqual(4, 四半期.第1四半期の開始月);
            Assert.AreEqual(7, 四半期.第2四半期の開始月);
            Assert.AreEqual(10, 四半期.第3四半期の開始月);
            Assert.AreEqual(1, 四半期.第4四半期の開始月);

            四半期 = new 四半期(5);
            Assert.AreEqual(5, 四半期.第1四半期の開始月);
            Assert.AreEqual(8, 四半期.第2四半期の開始月);
            Assert.AreEqual(11, 四半期.第3四半期の開始月);
            Assert.AreEqual(2, 四半期.第4四半期の開始月);

            四半期 = new 四半期(6);
            Assert.AreEqual(6, 四半期.第1四半期の開始月);
            Assert.AreEqual(9, 四半期.第2四半期の開始月);
            Assert.AreEqual(12, 四半期.第3四半期の開始月);
            Assert.AreEqual(3, 四半期.第4四半期の開始月);

            四半期 = new 四半期(7);
            Assert.AreEqual(7, 四半期.第1四半期の開始月);
            Assert.AreEqual(10, 四半期.第2四半期の開始月);
            Assert.AreEqual(1, 四半期.第3四半期の開始月);
            Assert.AreEqual(4, 四半期.第4四半期の開始月);

            四半期 = new 四半期(8);
            Assert.AreEqual(8, 四半期.第1四半期の開始月);
            Assert.AreEqual(11, 四半期.第2四半期の開始月);
            Assert.AreEqual(2, 四半期.第3四半期の開始月);
            Assert.AreEqual(5, 四半期.第4四半期の開始月);

            四半期 = new 四半期(9);
            Assert.AreEqual(9, 四半期.第1四半期の開始月);
            Assert.AreEqual(12, 四半期.第2四半期の開始月);
            Assert.AreEqual(3, 四半期.第3四半期の開始月);
            Assert.AreEqual(6, 四半期.第4四半期の開始月);

            四半期 = new 四半期(10);
            Assert.AreEqual(10, 四半期.第1四半期の開始月);
            Assert.AreEqual(1, 四半期.第2四半期の開始月);
            Assert.AreEqual(4, 四半期.第3四半期の開始月);
            Assert.AreEqual(7, 四半期.第4四半期の開始月);

            四半期 = new 四半期(11);
            Assert.AreEqual(11, 四半期.第1四半期の開始月);
            Assert.AreEqual(2, 四半期.第2四半期の開始月);
            Assert.AreEqual(5, 四半期.第3四半期の開始月);
            Assert.AreEqual(8, 四半期.第4四半期の開始月);

            四半期 = new 四半期(12);
            Assert.AreEqual(12, 四半期.第1四半期の開始月);
            Assert.AreEqual(3, 四半期.第2四半期の開始月);
            Assert.AreEqual(6, 四半期.第3四半期の開始月);
            Assert.AreEqual(9, 四半期.第4四半期の開始月);

            四半期 = new 四半期(1);
            Assert.AreEqual(1, 四半期.第1四半期の開始月);
            Assert.AreEqual(4, 四半期.第2四半期の開始月);
            Assert.AreEqual(7, 四半期.第3四半期の開始月);
            Assert.AreEqual(10, 四半期.第4四半期の開始月);

            四半期 = new 四半期(2);
            Assert.AreEqual(2, 四半期.第1四半期の開始月);
            Assert.AreEqual(5, 四半期.第2四半期の開始月);
            Assert.AreEqual(8, 四半期.第3四半期の開始月);
            Assert.AreEqual(11, 四半期.第4四半期の開始月);

            四半期 = new 四半期(3);
            Assert.AreEqual(3, 四半期.第1四半期の開始月);
            Assert.AreEqual(6, 四半期.第2四半期の開始月);
            Assert.AreEqual(9, 四半期.第3四半期の開始月);
            Assert.AreEqual(12, 四半期.第4四半期の開始月);
        }
    }
}
