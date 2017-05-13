using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    public class 名称クラステスト
    {
        [TestMethod]
        [TestCategory("基本テスト")]
        public void 基本テスト()
        {
            AccountingSystem.Domain.PrimitiveObject.名称 氏名 = new AccountingSystem.Domain.PrimitiveObject.名称("笹沼");
            Assert.AreEqual("笹沼", 氏名.値);
        }

        [TestMethod]
        [TestCategory("基本テスト")]
        public void 空白の除去()
        {
            AccountingSystem.Domain.PrimitiveObject.名称 氏名 = new AccountingSystem.Domain.PrimitiveObject.名称(" 　笹沼 　");
            Assert.AreEqual("笹沼", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void  空文字列はNG()
        {
            AccountingSystem.Domain.PrimitiveObject.名称 氏名 = new AccountingSystem.Domain.PrimitiveObject.名称("");
            Assert.AreEqual("", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void ヌルはNG()
        {
            AccountingSystem.Domain.PrimitiveObject.名称 氏名 = new AccountingSystem.Domain.PrimitiveObject.名称(string.Empty);
            Assert.AreEqual("", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空白のみはNG()
        {
            AccountingSystem.Domain.PrimitiveObject.名称 氏名 = new AccountingSystem.Domain.PrimitiveObject.名称("  　 ");
            Assert.AreEqual("  　 ", 氏名.値);
        }
    }
}
