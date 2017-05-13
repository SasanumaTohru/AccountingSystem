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
         * 金額に変換できる
         */
        [TestMethod]
        public void 金額に変換できる基本テスト()
        {
            Assert.AreEqual(true, 型変換サービス.金額に変換できる("0"));
            Assert.AreEqual(true, 型変換サービス.金額に変換できる("1"));
            Assert.AreEqual(true, 型変換サービス.金額に変換できる("-1"));
            Assert.AreEqual(true, 型変換サービス.金額に変換できる("0000001"));

            Assert.AreEqual(false, 型変換サービス.金額に変換できる("a"));
            Assert.AreEqual(false, 型変換サービス.金額に変換できる("a123"));
            Assert.AreEqual(false, 型変換サービス.金額に変換できる("123abc"));
            Assert.AreEqual(false, 型変換サービス.金額に変換できる("-"));
        }

        /*
        * 文字列を金額に変換する
        */
        [TestMethod]
        public void 文字列を金額に変換する基本テスト()
        {
            Assert.AreEqual(0m, 型変換サービス.文字列を金額に変換する("0"));
            Assert.AreEqual(1m, 型変換サービス.文字列を金額に変換する("1"));
            Assert.AreEqual(-1m, 型変換サービス.文字列を金額に変換する("-1"));
            Assert.AreEqual(1m, 型変換サービス.文字列を金額に変換する("001"));
            Assert.AreEqual(-1m, 型変換サービス.文字列を金額に変換する("-001"));
        }
    }
}
