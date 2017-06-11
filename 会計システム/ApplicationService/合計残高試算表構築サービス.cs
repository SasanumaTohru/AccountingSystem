using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.BusinessObject.財務諸表;
using AccountingSystem.Domain.PrimitiveObject;
using System.Collections.ObjectModel;

namespace AccountingSystem.ApplicationService
{
    public class 合計残高試算表構築サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="会計年度"></param>
        /// <returns></returns>
        public 合計残高試算表 合計残高試算表を取得する(会計年度 会計年度)
        {
            var m_会計年度 = 会計年度;

            var 勘定科目情報サービス = new 勘定科目情報サービス();
            ReadOnlyCollection<科目> m_取引勘定科目リスト = 勘定科目情報サービス.すべての勘定科目リスト;

            var 伝票検索サービス = new 会計伝票検索サービス();
            ReadOnlyCollection<伝票> m_伝票リスト = 伝票検索サービス.期間で検索する(m_会計年度.期間);

            var 仕訳検索サービス = new 仕訳検索サービス();

            var 合計残高試算表 = new 合計残高試算表();

            foreach (var 勘定科目 in m_取引勘定科目リスト)
            {
                var 集計対象仕訳 = new 仕訳列();
                foreach (var 伝票 in m_伝票リスト)
                {
                    foreach (var 仕訳 in 仕訳検索サービス.伝票番号と勘定科目が一致する仕訳を検索する(伝票, 勘定科目))
                    {
                        集計対象仕訳.追加する(仕訳);
                    }
                }
                金額 借方金額 = 集計対象仕訳.貸借別合計金額を取得する(貸借.区分.借方);
                金額 貸方金額 = 集計対象仕訳.貸借別合計金額を取得する(貸借.区分.貸方);
                var 勘定科目別残高 = new 勘定科目残高(勘定科目, 借方金額, 貸方金額);
                合計残高試算表.追加する(勘定科目別残高);
            }
            return 合計残高試算表;
        }
    }
}
