using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    [TestCategory("基本テスト")]
    public class 自然数クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            会計システム.Domain.PrimitiveObject.自然数 数量 = new 会計システム.Domain.PrimitiveObject.自然数(0);
            Assert.AreEqual(0, 数量.値);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 負の整数はNG()
        {
            会計システム.Domain.PrimitiveObject.自然数 数量 = new 会計システム.Domain.PrimitiveObject.自然数(-1);
            Assert.AreEqual(-1, 数量.値);
        }
    }
}
