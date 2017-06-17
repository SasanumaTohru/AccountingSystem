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
            会計年度 会計年度 = new 会計年度(2017, 1);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            Assert.AreEqual("20170101", 会計年度.期間.開始日.数値文字列);
            Assert.AreEqual("20171231", 会計年度.期間.終了日.数値文字列);
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 1, 1)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成29年度", 会計年度.指定した日付の会計年度を和暦で取得する(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成29年度", 会計年度.現在の和暦会計年度);
            
            会計年度 = new 会計年度(2017, 2);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 3);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);

            会計年度 = new 会計年度(2017);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            Assert.AreEqual("平成29年度", 会計年度.現在の和暦会計年度);
            Assert.AreEqual("2016年度", 会計年度.指定した日付の会計年度(new 日付(2017, 1, 1)));
            Assert.AreEqual("2016年度", 会計年度.指定した日付の会計年度(new 日付(2017, 3, 31)));
            Assert.AreEqual("平成28年度", 会計年度.指定した日付の会計年度を和暦で取得する(new 日付(2017, 3, 31)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 4, 1)));
            Assert.AreEqual("平成29年度", 会計年度.指定した日付の会計年度を和暦で取得する(new 日付(2017, 4, 1)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成29年度", 会計年度.指定した日付の会計年度を和暦で取得する(new 日付(2017, 12, 31)));
            Assert.AreEqual(4, 会計年度.四半期.第1四半期の開始月);

            会計年度 = new 会計年度(2017, 5);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 6);
            Assert.AreEqual("2017年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 7);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 8);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 9);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 10);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            会計年度 = new 会計年度(2017, 11);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);

            会計年度 = new 会計年度(2017, 12);
            Assert.AreEqual("2016年度", 会計年度.現在の会計年度);
            Assert.AreEqual("20171201", 会計年度.期間.開始日.数値文字列);
            Assert.AreEqual("20181130", 会計年度.期間.終了日.数値文字列);
            Assert.AreEqual("2016年度", 会計年度.指定した日付の会計年度(new 日付(2017, 1, 1)));
            Assert.AreEqual("2017年度", 会計年度.指定した日付の会計年度(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成29年度", 会計年度.指定した日付の会計年度を和暦で取得する(new 日付(2017, 12, 31)));
            Assert.AreEqual("平成28年度", 会計年度.現在の和暦会計年度);
        }
    }
}
