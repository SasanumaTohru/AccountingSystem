using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.PrimitiveObject;

namespace UnitTest.Domain.BusinessObject.勘定科目
{
    [TestClass]
    public class 訂正伝票関連テスト
    {
        [TestMethod]
        public void 訂正伝票基本テスト()
        {
            var 計上日 = new 日付(2017, 5, 1);
            var 元伝票番号 = new 伝票番号(new 自然数(1), 計上日);
            var 元伝票 = new 伝票(元伝票番号, 計上日);
            var 貸方仕訳1勘定科目 = new 科目(new コード(111030), new 名称("現金"));
            var 貸方仕訳1 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("a"), new 金額(1080), AccountingSystem.Domain.BusinessObject.貸借.区分.貸方);
            var 借方仕訳1勘定科目 = new 科目(new コード(512450), new 名称("消耗品費"));
            var 借方仕訳1 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("b"), new 金額(1000), AccountingSystem.Domain.BusinessObject.貸借.区分.借方);
            var 借方仕訳2勘定科目 = new 科目(new コード(114270), new 名称("仮払消費税"));
            var 借方仕訳2 = new 仕訳(貸方仕訳1勘定科目, new 必須文字列("c"), new 金額(80), AccountingSystem.Domain.BusinessObject.貸借.区分.借方);
            元伝票.追加する(貸方仕訳1);
            元伝票.追加する(借方仕訳1);
            元伝票.追加する(借方仕訳2);
            Assert.AreEqual(伝票情報.伝票区分リスト.通常伝票, 元伝票.伝票情報.伝票区分);
            Assert.AreEqual(伝票情報.訂正リスト.なし, 元伝票.伝票情報.訂正有無);

            var 伝票記帳サービス = new AccountingSystem.ApplicationService.会計伝票.会計伝票記帳サービス();
            伝票 保存した元伝票 = 伝票記帳サービス.伝票を記帳する(元伝票);
            var 訂正伝票ビルダー = new 訂正伝票作成サービス();
            var 訂正伝票 = 訂正伝票ビルダー.訂正伝票を作成する(元伝票);
            伝票 保存した訂正伝票 = 伝票記帳サービス.伝票を記帳する(訂正伝票);

            //元伝票
            Assert.AreEqual("201705-00001", 保存した元伝票.番号.値);
            Assert.AreEqual(0, 保存した元伝票.貸借金額差額.絶対値);
            Assert.AreEqual(1, 保存した元伝票.貸方.リスト.Count);
            Assert.AreEqual(2, 保存した元伝票.借方.リスト.Count);
            Assert.AreEqual(伝票情報.伝票区分リスト.通常伝票, 保存した元伝票.伝票情報.伝票区分);
            Assert.AreEqual(伝票情報.訂正リスト.あり, 保存した元伝票.伝票情報.訂正有無);

            //訂正伝票
            Assert.AreEqual("201706-00001", 保存した訂正伝票.番号.値);
            Assert.AreEqual(0, 保存した訂正伝票.貸借金額差額.絶対値);
            Assert.AreEqual(2, 保存した訂正伝票.貸方.リスト.Count);
            Assert.AreEqual(1, 保存した訂正伝票.借方.リスト.Count);
            Assert.AreEqual(伝票情報.伝票区分リスト.訂正伝票, 保存した訂正伝票.伝票情報.伝票区分);
            Assert.AreEqual(伝票情報.訂正リスト.なし, 保存した訂正伝票.伝票情報.訂正有無);
            Assert.AreEqual(保存した元伝票.番号.値, 保存した訂正伝票.伝票情報.対応伝票番号);

            //伝票比較
            Assert.AreEqual(訂正伝票.貸方.リスト.Count, 元伝票.借方.リスト.Count);
            Assert.AreEqual(訂正伝票.借方.リスト.Count, 元伝票.貸方.リスト.Count);

        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 訂正した伝票は訂正できない()
        {
            var 計上日 = new 日付(2017, 4, 1);
            var 元伝票番号 = new 伝票番号(new 自然数(1), 計上日);
            var 元伝票 = new 伝票(元伝票番号, 計上日);
            var 訂正伝票ビルダー = new 訂正伝票作成サービス();
            var 訂正伝票 = 訂正伝票ビルダー.訂正伝票を作成する(元伝票);
            var 再度訂正した伝票 = 訂正伝票ビルダー.訂正伝票を作成する(元伝票);
        }

        [TestMethod]
        [TestCategory("例外テスト")]
        [ExpectedException(typeof(Exception))]
        public void 訂正伝票は訂正できない()
        {
            var 計上日 = new 日付(2017, 4, 1);
            var 元伝票番号 = new 伝票番号(new 自然数(1), 計上日);
            var 元伝票 = new 伝票(元伝票番号, 計上日);
            var 訂正伝票ビルダー = new 訂正伝票作成サービス();
            var 訂正伝票 = 訂正伝票ビルダー.訂正伝票を作成する(元伝票);
            var さらに訂正した伝票 = 訂正伝票ビルダー.訂正伝票を作成する(訂正伝票);
        }
    }
}
