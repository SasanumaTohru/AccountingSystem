using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.ApplicationService;


namespace UnitTest.ApplicationService
{
    [TestClass]
    public class 型変換サービスクラステスト
    {
        /*
         * コードと名称から勘定科目コードを抽出する
         */
        [TestMethod]
        public void コードと名称から勘定科目コードを抽出する基本テスト()
        {
            Assert.AreEqual(0, 型変換サービス.コードと名称から勘定科目コードを抽出する("000000 - abc"));
            Assert.AreEqual(123456, 型変換サービス.コードと名称から勘定科目コードを抽出する("123456789 - abc"));
            Assert.AreEqual(999999, 型変換サービス.コードと名称から勘定科目コードを抽出する("999999 - abc"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void コードと名称から勘定科目コードを抽出する例外1()
        {
            Assert.AreEqual(123456, 型変換サービス.コードと名称から勘定科目コードを抽出する("12345 - abc"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void コードと名称から勘定科目コードを抽出する例外2()
        {
            Assert.AreEqual(123456, 型変換サービス.コードと名称から勘定科目コードを抽出する("a12345 - abc"));
        }

        /*
         * 金額に変換可能
         */
        [TestMethod]
        public void 金額に変換可能基本テスト()
        {
            Assert.AreEqual(true, 型変換サービス.文字列を金額に変換する("0").変換可能);
            Assert.AreEqual(true, 型変換サービス.文字列を金額に変換する("1").変換可能);
            Assert.AreEqual(true, 型変換サービス.文字列を金額に変換する("-1").変換可能);
            Assert.AreEqual(true, 型変換サービス.文字列を金額に変換する("0000001").変換可能);
            Assert.AreEqual(true, 型変換サービス.文字列を金額に変換する("100,000").変換可能);

            Assert.AreEqual(false, 型変換サービス.文字列を金額に変換する("a").変換可能);
            Assert.AreEqual(0m, 型変換サービス.文字列を金額に変換する("a").金額);
            Assert.AreEqual(false, 型変換サービス.文字列を金額に変換する("a123").変換可能);
            Assert.AreEqual(false, 型変換サービス.文字列を金額に変換する("123abc").変換可能);
            Assert.AreEqual(false, 型変換サービス.文字列を金額に変換する("-").変換可能);
        }

        /*
        * 文字列を金額に変換する
        */
        [TestMethod]
        public void 文字列を金額に変換する基本テスト()
        {
            Assert.AreEqual(0m, 型変換サービス.文字列を金額に変換する("0").金額);
            Assert.AreEqual(1m, 型変換サービス.文字列を金額に変換する("1").金額);
            Assert.AreEqual(-1m, 型変換サービス.文字列を金額に変換する("-1").金額);
            Assert.AreEqual(1m, 型変換サービス.文字列を金額に変換する("001").金額);
            Assert.AreEqual(-1m, 型変換サービス.文字列を金額に変換する("-001").金額);
            Assert.AreEqual(100000m, 型変換サービス.文字列を金額に変換する("100,000").金額);
            Assert.AreEqual(-100000m, 型変換サービス.文字列を金額に変換する("-100,000").金額);
        }
    }
}
