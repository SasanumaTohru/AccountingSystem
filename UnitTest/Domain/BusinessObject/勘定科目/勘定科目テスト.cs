using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 会計システム.Domain.BusinessObject.勘定科目;
using 会計システム.Domain.PrimitiveObject;
using 会計システム.Domain.BusinessObject.伝票;

namespace UnitTest.Domain.BusinessObject.勘定科目
{
    [TestClass]
    public class 勘定科目テスト
    {
        [TestMethod]
        public void 基本テスト()
        {

            科目 資産 = new 科目(new コード(100000), new 名称("資産"));
            科目 流動資産 = new 科目(new コード(100001), new 名称("流動資産"), 資産);
            科目 現金預金 = new 科目(new コード(100002), new 名称("現金預金"), 流動資産);
            科目 普通預金 = new 科目(new コード(100003), new 名称("普通預金"), 現金預金);

            科目 費用 = new 科目(new コード(400000), new 名称("費用"));

            Assert.AreEqual(資産, 資産.集計科目);
            Assert.AreEqual("資産", 資産.集計科目.名称.値 );

            Assert.AreEqual(100003, 普通預金.コード.値);
            Assert.AreEqual("普通預金", 普通預金.名称.値);
            Assert.AreEqual(現金預金, 普通預金.集計科目);

            仕訳 貸方 = new 仕訳(普通預金, new 金額(123), 仕訳.貸借区分.貸方);
            Assert.AreEqual(100003, 貸方.勘定科目.コード.値);
            Assert.AreEqual(123, 貸方.金額.値);
            Assert.AreEqual(仕訳.貸借区分.貸方, 貸方.貸借);
            仕訳 借方 = new 仕訳(費用, 貸方.金額, 仕訳.貸借区分.借方);

        }
    }
}
