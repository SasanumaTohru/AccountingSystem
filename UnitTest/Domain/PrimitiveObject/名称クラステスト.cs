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
            会計システム.Domain.PrimitiveObject.名称 氏名 = new 会計システム.Domain.PrimitiveObject.名称("笹沼");
            Assert.AreEqual("笹沼", 氏名.値);
        }

        [TestMethod]
        [TestCategory("基本テスト")]
        public void 空白の除去()
        {
            会計システム.Domain.PrimitiveObject.名称 氏名 = new 会計システム.Domain.PrimitiveObject.名称(" 　笹沼 　");
            Assert.AreEqual("笹沼", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void  空文字列はNG()
        {
            会計システム.Domain.PrimitiveObject.名称 氏名 = new 会計システム.Domain.PrimitiveObject.名称("");
            Assert.AreEqual("", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void ヌルはNG()
        {
            会計システム.Domain.PrimitiveObject.名称 氏名 = new 会計システム.Domain.PrimitiveObject.名称(string.Empty);
            Assert.AreEqual("", 氏名.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空白のみはNG()
        {
            会計システム.Domain.PrimitiveObject.名称 氏名 = new 会計システム.Domain.PrimitiveObject.名称("  　 ");
            Assert.AreEqual("  　 ", 氏名.値);
        }
    }
}
