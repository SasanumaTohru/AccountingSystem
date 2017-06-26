using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.BusinessObject.財務諸表;
using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.PrimitiveObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTest.Domain.BusinessObject
{
    [TestClass]
    public class 四半期期末残高クラステスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            var 勘定科目コード = new コード(100000);
            var 四半期末残高 = new 四半期末勘定科目残高(勘定科目コード, new 会計年度(2017), 四半期決算.四半期区分リスト.第1四半期, new 金額(-1m));
            Assert.AreEqual(100000, 四半期末残高.勘定科目コード.値);
            Assert.AreEqual(2017, 四半期末残高.会計年度.値);
            Assert.AreEqual(1, (int)四半期末残高.四半期区分);
            Assert.AreEqual(-1m, 四半期末残高.金額.値);

            var 第1四半期決算 = new 四半期決算(new 会計年度(2017), 四半期決算.四半期区分リスト.第1四半期);
            第1四半期決算.追加する(四半期末残高);
            Assert.AreEqual(1, 第1四半期決算.科目別残高リスト.Count);
            foreach (var p in 第1四半期決算.科目別残高リスト)
            {
                Debug.WriteLine(p.勘定科目コード.値);
            }
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 例外テスト年度が異なる()
        {
            var 第1四半期決算 = new 四半期決算(new 会計年度(2017), 四半期決算.四半期区分リスト.第1四半期);

            var 勘定科目コード = new コード(100000);
            var 年度が不正な残高 = new 四半期末勘定科目残高(勘定科目コード, new 会計年度(2018), 四半期決算.四半期区分リスト.第1四半期, new 金額(-1m));
            
            第1四半期決算.追加する(年度が不正な残高);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 例外テスト四半期区分が異なる()
        {
            var 第1四半期決算 = new 四半期決算(new 会計年度(2017), 四半期決算.四半期区分リスト.第1四半期);

            var 勘定科目コード = new コード(100000);
            var 四半期区分が不正な残高 = new 四半期末勘定科目残高(勘定科目コード, new 会計年度(2017), 四半期決算.四半期区分リスト.第2四半期, new 金額(-1m));

            第1四半期決算.追加する(四半期区分が不正な残高);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 例外テスト年度と四半期区分が異なる()
        {
            var 第1四半期決算 = new 四半期決算(new 会計年度(2017), 四半期決算.四半期区分リスト.第1四半期);

            var 勘定科目コード = new コード(100000);
            var 年度と四半期区分が不正な残高 = new 四半期末勘定科目残高(勘定科目コード, new 会計年度(2016), 四半期決算.四半期区分リスト.第2四半期, new 金額(-1m));

            第1四半期決算.追加する(年度と四半期区分が不正な残高);
        }
    }
}
