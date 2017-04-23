using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 会計システム.Domain.PrimitiveObject;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    [TestCategory("基本テスト")]
    public class 日付クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            日付 元旦 = new 日付(2017, 1, 1);
            Assert.AreEqual(new DateTime(2017,1,1), 元旦.値());
           
            Assert.AreEqual("2017年1月1日", 元旦.西暦年月日());
            Assert.AreEqual("2017年1月1日", 元旦.西暦年月日(日付.曜日表示.なし));
            Assert.AreEqual("2017年1月1日(日)", 元旦.西暦年月日(日付.曜日表示.あり));

            Assert.AreEqual("平成29年1月1日", 元旦.和暦年月日());
            Assert.AreEqual("平成29年1月1日", 元旦.和暦年月日(日付.曜日表示.なし));
            Assert.AreEqual("平成29年1月1日(日)", 元旦.和暦年月日(日付.曜日表示.あり ));
        }
    }
}
