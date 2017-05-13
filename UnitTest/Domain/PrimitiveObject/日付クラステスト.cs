using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.Domain.PrimitiveObject;

namespace UnitTest.Domain.PrimitiveObject
{
    [TestClass]
    public class 日付クラステスト
    {
        [TestMethod]
        [TestCategory("基本テスト")]
        public void 基本テスト()
        {
            //コンストラクタ　個別
            日付 元旦 = new 日付(2017, 1, 1);
            Assert.AreEqual(new DateTime(2017,1,1), 元旦.値);
           
            Assert.AreEqual("2017年1月1日", 元旦.西暦年月日());
            Assert.AreEqual("2017年1月1日", 元旦.西暦年月日(日付.曜日表示.なし));
            Assert.AreEqual("2017年1月1日(日)", 元旦.西暦年月日(日付.曜日表示.あり));

            Assert.AreEqual("平成29年1月1日", 元旦.和暦年月日());
            Assert.AreEqual("平成29年1月1日", 元旦.和暦年月日(日付.曜日表示.なし));
            Assert.AreEqual("平成29年1月1日(日)", 元旦.和暦年月日(日付.曜日表示.あり ));

            Assert.AreEqual("01", 元旦.月文字列2桁);

            //コンストラクタ　DateTime
            DateTime 今年の大晦日 = new DateTime(2017, 12, 31);
            日付 大晦日 = new 日付(今年の大晦日);
            Assert.AreEqual("2017年12月31日", 大晦日.西暦年月日());

            Assert.AreEqual("平成29年", 大晦日.和暦年);
            Assert.AreEqual("2017", 大晦日.西暦文字列);
            Assert.AreEqual("12", 大晦日.月文字列2桁);
            Assert.AreEqual("201712", 大晦日.西暦年月文字列6桁);

        }
    }
}
