using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 会計システム.Domain.BusinessObject.勘定科目;
using 会計システム.Domain.PrimitiveObject;
using 会計システム.Domain.BusinessObject.会計伝票;

namespace UnitTest.Domain.BusinessObject.勘定科目
{
    [TestClass]
    public class 勘定科目テスト
    {
        [TestMethod]
        public void 基本テスト()
        {
            //勘定科目
            科目 資産 = new 科目(new コード(100000), new 名称("資産"));
            科目 流動資産 = new 科目(new コード(100001), new 名称("流動資産"), 資産);
            科目 現金預金 = new 科目(new コード(100002), new 名称("現金預金"), 流動資産);
            科目 普通預金 = new 科目(new コード(100003), new 名称("普通預金"), 現金預金);
            科目 その他流動資産 = new 科目(new コード(120000), new 名称("その他流動資産"), 流動資産);
            科目 仮払消費税 = new 科目(new コード(120001), new 名称("仮払消費税"), その他流動資産);

            科目 費用 = new 科目(new コード(400000), new 名称("費用"));

            Assert.AreEqual(資産, 資産.集計科目);
            Assert.AreEqual("資産", 資産.集計科目.名称.値 );

            Assert.AreEqual(100003, 普通預金.コード.値);
            Assert.AreEqual("普通預金", 普通預金.名称.値);
            Assert.AreEqual(現金預金, 普通預金.集計科目);

            //仕訳
            仕訳 貸方仕訳 = new 仕訳(普通預金, new 文字列("コピー用紙代等"), new 金額(1080), 仕訳.貸借区分.貸方);
            Assert.AreEqual(100003, 貸方仕訳.勘定科目.コード.値);
            Assert.AreEqual(1080, 貸方仕訳.金額.値);
            Assert.AreEqual(仕訳.貸借区分.貸方, 貸方仕訳.貸借);
            仕訳 借方仕訳1 = new 仕訳(費用, new 文字列("コピー用紙代"), new 金額(1000), 仕訳.貸借区分.借方);
            仕訳 借方仕訳2 = new 仕訳(仮払消費税, new 文字列("消費税"), new 金額(80), 仕訳.貸借区分.借方);

            //伝票
            日付 計上日 = new 日付(2017, 4, 1);
            番号 月内連番 = new 番号(new 自然数(1), 計上日);
            伝票 伝票 = new 伝票(月内連番, 計上日);
            Assert.AreEqual("201704-00001", 伝票.番号.値);
            Assert.AreEqual("2017年4月1日", 伝票.計上日.西暦年月日());
            伝票.追加する(借方仕訳1);
            伝票.追加する(借方仕訳2);
            伝票.追加する(貸方仕訳);
            Assert.AreEqual(2, 伝票.借方.リスト.Count);
            Assert.AreEqual(1, 伝票.貸方.リスト.Count);
            Assert.AreEqual("費用", 伝票.借方.リスト[0].勘定科目.名称.値);
            Assert.AreEqual("コピー用紙代", 伝票.借方.リスト[0].摘要.値);
            Assert.AreEqual("1,000",伝票.借方.リスト[0].金額.桁区切り値);
            Assert.AreEqual("仮払消費税", 伝票.借方.リスト[1].勘定科目.名称.値);
            Assert.AreEqual("80", 伝票.借方.リスト[1].金額.桁区切り値);
            Assert.AreEqual("普通預金", 伝票.貸方.リスト[0].勘定科目.名称.値);
            Assert.AreEqual("1,080", 伝票.貸方.リスト[0].金額.桁区切り値);
            Assert.AreEqual(1080, 伝票.借方.合計金額.値);
            Assert.AreEqual(1080, 伝票.貸方.合計金額.値);

        }
    }
}
