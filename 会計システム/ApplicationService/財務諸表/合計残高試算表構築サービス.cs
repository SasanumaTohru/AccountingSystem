using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.BusinessObject.財務諸表;
using AccountingSystem.Domain.PrimitiveObject;
using System.Collections.ObjectModel;

namespace AccountingSystem.ApplicationService.財務諸表
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

            var 勘定科目情報サービス = new 勘定科目.勘定科目情報サービス();
            ReadOnlyCollection<科目> m_取引勘定科目リスト = 勘定科目情報サービス.すべての勘定科目リスト;

            var 伝票検索サービス = new 会計伝票.会計伝票検索サービス();
            ReadOnlyCollection<伝票> m_伝票リスト = 伝票検索サービス.期間で検索する(m_会計年度.期間);

            var 仕訳検索サービス = new 会計伝票.仕訳検索サービス();

            科目 売上総利益 = 勘定科目情報サービス.科目を検索する(600000);
            科目 売上 = 勘定科目情報サービス.科目を検索する(510030);
            科目 売上原価 = 勘定科目情報サービス.科目を検索する(410030);
            科目 営業利益 = 勘定科目情報サービス.科目を検索する(600100);
            科目 販売費及び一般管理費 = 勘定科目情報サービス.科目を検索する(410150);
            科目 経常利益 = 勘定科目情報サービス.科目を検索する(600200);
            科目 営業外収益 = 勘定科目情報サービス.科目を検索する(520000);
            科目 営業外費用 = 勘定科目情報サービス.科目を検索する(420000);
            科目 純利益 = 勘定科目情報サービス.科目を検索する(600300);
            科目 特別利益 = 勘定科目情報サービス.科目を検索する(530000);
            科目 特別損失 = 勘定科目情報サービス.科目を検索する(430000);
            var 利益計算情報 = new 利益計算情報(売上総利益, 売上, 売上原価, 営業利益, 販売費及び一般管理費, 経常利益, 営業外収益, 営業外費用, 純利益, 特別利益, 特別損失);
            var 合計残高試算表 = new 合計残高試算表(利益計算情報);

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
