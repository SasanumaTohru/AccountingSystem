using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Infrastructure
{
    [TestClass]
    public class 消費税率検索サービスクラステスト
    {
        [TestMethod]
        public void 現在の摘要消費税を検索()
        {
            var 消費税率検索サービス = new 会計システム.Infrastructure.消費税率検索サービス();
            Assert.AreEqual(0.03m, 消費税率検索サービス.適用消費税率(new DateTime(1989, 4, 01)));
            Assert.AreEqual(0.03m, 消費税率検索サービス.適用消費税率(new DateTime(1997, 3, 31)));
            Assert.AreEqual(0.05m, 消費税率検索サービス.適用消費税率(new DateTime(1997, 4, 01)));
            Assert.AreEqual(0.05m, 消費税率検索サービス.適用消費税率(new DateTime(2014, 3, 31)));
            Assert.AreEqual(0.08m, 消費税率検索サービス.適用消費税率(new DateTime(2014, 4, 01)));
            Assert.AreEqual(0.08m, 消費税率検索サービス.適用消費税率(new DateTime(2019, 3, 31)));
            Assert.AreEqual(0.1m, 消費税率検索サービス.適用消費税率(new DateTime(2019, 4, 01)));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void 消費税法施行日前()
        {
            var 消費税率検索サービス = new 会計システム.Infrastructure.消費税率検索サービス();
            Assert.AreEqual(0m, 消費税率検索サービス.適用消費税率(new DateTime(1989, 3, 31)));
        }
    }
}
