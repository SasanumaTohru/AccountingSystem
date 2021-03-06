﻿using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.PrimitiveObject;
using System.Collections.ObjectModel;

namespace AccountingSystem.ApplicationService.会計伝票
{
    public class 仕訳構築サービス
    {
        private 仕訳列 m_仕訳列 = new 仕訳列();
        private 勘定科目.勘定科目情報サービス 勘定科目情報 = new 勘定科目.勘定科目情報サービス();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <param name="金額"></param>
        /// <param name="摘要"></param>
        /// <param name="貸借区分番号"></param>
        public void 追加する(int 勘定科目コード, decimal 金額, string 摘要, int 貸借区分番号)
        {
            var _勘定科目コード = new コード(勘定科目コード);
            名称 _勘定科目名 = 勘定科目情報.勘定科目名を照会する(_勘定科目コード);
            var _勘定科目 = new 科目(_勘定科目コード, _勘定科目名);
            var _金額 = new 金額(金額);
            var _摘要 = new 必須文字列(摘要);
            m_仕訳列.追加する(new 仕訳(_勘定科目, _摘要, _金額, (Domain.BusinessObject.貸借.区分)貸借区分番号));
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyCollection<仕訳> リスト => m_仕訳列.リスト;

    }
}
