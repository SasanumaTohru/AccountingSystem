using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.PrimitiveObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.BusinessObject
{
    [TestClass]
    public class 四半期クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            var 四半期 = new 四半期(new 日付(2017, 4, 1));
            Assert.AreEqual("20170401", 四半期.第1四半期.開始日.数値文字列);
            Assert.AreEqual("20170630", 四半期.第1四半期.終了日.数値文字列);
            Assert.AreEqual("20170701", 四半期.第2四半期.開始日.数値文字列);
            Assert.AreEqual("20170930", 四半期.第2四半期.終了日.数値文字列);
            Assert.AreEqual("20171001", 四半期.第3四半期.開始日.数値文字列);
            Assert.AreEqual("20171231", 四半期.第3四半期.終了日.数値文字列);
            Assert.AreEqual("20180101", 四半期.第4四半期.開始日.数値文字列);
            Assert.AreEqual("20180331", 四半期.第4四半期.終了日.数値文字列);
            Assert.AreEqual(4, 四半期.第1四半期の開始月);
            Assert.AreEqual(7, 四半期.第2四半期の開始月);
            Assert.AreEqual(10, 四半期.第3四半期の開始月);
            Assert.AreEqual(1, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 5, 1));
            Assert.AreEqual(5, 四半期.第1四半期の開始月);
            Assert.AreEqual(8, 四半期.第2四半期の開始月);
            Assert.AreEqual(11, 四半期.第3四半期の開始月);
            Assert.AreEqual(2, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 6, 1));
            Assert.AreEqual(6, 四半期.第1四半期の開始月);
            Assert.AreEqual(9, 四半期.第2四半期の開始月);
            Assert.AreEqual(12, 四半期.第3四半期の開始月);
            Assert.AreEqual(3, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 7, 1));
            Assert.AreEqual(7, 四半期.第1四半期の開始月);
            Assert.AreEqual(10, 四半期.第2四半期の開始月);
            Assert.AreEqual(1, 四半期.第3四半期の開始月);
            Assert.AreEqual(4, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 8, 1));
            Assert.AreEqual(8, 四半期.第1四半期の開始月);
            Assert.AreEqual(11, 四半期.第2四半期の開始月);
            Assert.AreEqual(2, 四半期.第3四半期の開始月);
            Assert.AreEqual(5, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 9, 1));
            Assert.AreEqual(9, 四半期.第1四半期の開始月);
            Assert.AreEqual(12, 四半期.第2四半期の開始月);
            Assert.AreEqual(3, 四半期.第3四半期の開始月);
            Assert.AreEqual(6, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 10, 1));
            Assert.AreEqual(10, 四半期.第1四半期の開始月);
            Assert.AreEqual(1, 四半期.第2四半期の開始月);
            Assert.AreEqual(4, 四半期.第3四半期の開始月);
            Assert.AreEqual(7, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 11, 1));
            Assert.AreEqual(11, 四半期.第1四半期の開始月);
            Assert.AreEqual(2, 四半期.第2四半期の開始月);
            Assert.AreEqual(5, 四半期.第3四半期の開始月);
            Assert.AreEqual(8, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2017, 12, 1));
            Assert.AreEqual(12, 四半期.第1四半期の開始月);
            Assert.AreEqual(3, 四半期.第2四半期の開始月);
            Assert.AreEqual(6, 四半期.第3四半期の開始月);
            Assert.AreEqual(9, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2018, 1, 1));
            Assert.AreEqual(1, 四半期.第1四半期の開始月);
            Assert.AreEqual(4, 四半期.第2四半期の開始月);
            Assert.AreEqual(7, 四半期.第3四半期の開始月);
            Assert.AreEqual(10, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2018, 2, 1));
            Assert.AreEqual(2, 四半期.第1四半期の開始月);
            Assert.AreEqual(5, 四半期.第2四半期の開始月);
            Assert.AreEqual(8, 四半期.第3四半期の開始月);
            Assert.AreEqual(11, 四半期.第4四半期の開始月);

            四半期 = new 四半期(new 日付(2018, 3, 1));
            Assert.AreEqual(3, 四半期.第1四半期の開始月);
            Assert.AreEqual(6, 四半期.第2四半期の開始月);
            Assert.AreEqual(9, 四半期.第3四半期の開始月);
            Assert.AreEqual(12, 四半期.第4四半期の開始月);
        }
    }
}
