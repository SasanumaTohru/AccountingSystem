using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.ApplicationService
{
    [TestClass]
    public class 入力検査クラステスト
    {
        [TestMethod]
        public void 金額に変換できない()
        {
            string 検査値 = "123";
            Assert.AreEqual(false, 会計システム.ApplicationService.入力検査.金額に変換できない(検査値));
            検査値 = "-123";
            Assert.AreEqual(true, 会計システム.ApplicationService.入力検査.金額に変換できない(検査値));
            検査値 = "asdasd5045asd";
            Assert.AreEqual(true, 会計システム.ApplicationService.入力検査.金額に変換できない(検査値));
        }
    }
}
