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
            AccountingSystem.Domain.PrimitiveObject.必須文字列 メモ = new AccountingSystem.Domain.PrimitiveObject.必須文字列("今日は晴れです。");
            Assert.AreEqual("今日は晴れです。", メモ.値);
            メモ = new AccountingSystem.Domain.PrimitiveObject.必須文字列("　今日は晴れです。　");
            Assert.AreEqual("　今日は晴れです。", メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void ヌルはNG()
        {
            AccountingSystem.Domain.PrimitiveObject.必須文字列 メモ = new AccountingSystem.Domain.PrimitiveObject.必須文字列(string.Empty);
            Assert.AreEqual(string.Empty, メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空文字列はNG()
        {
            AccountingSystem.Domain.PrimitiveObject.必須文字列 メモ = new AccountingSystem.Domain.PrimitiveObject.必須文字列("");
            Assert.AreEqual("", メモ.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 空白のみはNG()
        {
            AccountingSystem.Domain.PrimitiveObject.必須文字列 メモ = new AccountingSystem.Domain.PrimitiveObject.必須文字列("　    　    　");
            Assert.AreEqual("　    　    　", メモ.値);
        }
    }
}
