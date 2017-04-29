using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    public class 文字列クラステスト
    {
        [TestMethod]
        [TestCategory("基本テスト")]
        public void 基本テスト()
        {
            会計システム.Domain.PrimitiveObject.文字列 メモ = new 会計システム.Domain.PrimitiveObject.文字列("今日は晴れです。");
            Assert.AreEqual("今日は晴れです。", メモ.値);
            メモ = new 会計システム.Domain.PrimitiveObject.文字列("　今日は晴れです。　");
            Assert.AreEqual("　今日は晴れです。", メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void ヌルはNG()
        {
            会計システム.Domain.PrimitiveObject.文字列 メモ = new 会計システム.Domain.PrimitiveObject.文字列(string.Empty);
            Assert.AreEqual(string.Empty, メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空文字列はNG()
        {
            会計システム.Domain.PrimitiveObject.文字列 メモ = new 会計システム.Domain.PrimitiveObject.文字列("");
            Assert.AreEqual("", メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空白のみはNG()
        {
            会計システム.Domain.PrimitiveObject.文字列 メモ = new 会計システム.Domain.PrimitiveObject.文字列("　    　    　");
            Assert.AreEqual("　    　    　", メモ.値);
        }
    }
}
