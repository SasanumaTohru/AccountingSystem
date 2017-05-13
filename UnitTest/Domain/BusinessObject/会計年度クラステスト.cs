using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.PrimitiveObject;

namespace UnitTest.Domain.BusinessObject
{
    [TestClass]
    public class 会計年度クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            会計年度 会計年度 = new 会計年度(1);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            
            会計年度 = new 会計年度(2);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(3);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);

            会計年度 = new 会計年度(4);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            Assert.AreEqual("平成29年度", 会計年度.現在の和暦会計年度);
            Assert.AreEqual("2016年度", 会計年度.指定した日付の会計年度(new 日付(2017, 1, 1)));
            Assert.AreEqual("2016年度", 会計年度.指定した日付の会計年度(new 日付(2017, 3, 31)));
            Assert.AreEqual("平成28年度", 会計年度.和暦で指定した日付の会計年度を取得する(new 日付(2017, 3, 31)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 4, 1)));
            Assert.AreEqual("平成29年度", 会計年度.和暦で指定した日付の会計年度を取得する(new 日付(2017, 4, 1)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成29年度", 会計年度.和暦で指定した日付の会計年度を取得する(new 日付(2017, 12, 31)));

            会計年度 = new 会計年度(5);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(6);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(7);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(8);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(9);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(10);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(11);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(12);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
        }
    }
}
