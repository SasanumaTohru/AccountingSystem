using AccountingSystem.Domain.BusinessObject;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.BusinessObject.財務諸表;
using AccountingSystem.Domain.PrimitiveObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.ApplicationService
{
    public class 合計残高試算表参照サービス
    {
        public 合計残高試算表 勘定科目別残高リスト(会計年度 会計年度)
        {
            var m_会計年度 = 会計年度;

            var 勘定科目情報サービス = new 勘定科目情報サービス();
            List<科目> m_取引勘定科目リスト = 勘定科目情報サービス.取引勘定科目リスト;

            var 伝票検索サービス = new 会計伝票検索サービス();
            List<伝票> m_伝票リスト = 伝票検索サービス.期間で検索する(m_会計年度.期間.開始日.値, m_会計年度.期間.終了日.値);

            var 仕訳検索サービス = new 仕訳検索サービス();

            var 合計残高試算表 = new 合計残高試算表();

            foreach (var 勘定科目 in m_取引勘定科目リスト)
            {
                var 抽出した集計対象仕訳 = new List<仕訳>();
                foreach (var 伝票 in m_伝票リスト)
                {
                    foreach (var p in 仕訳検索サービス.伝票番号と勘定科目が一致する仕訳を検索する(伝票, 勘定科目))
                    {
                        抽出した集計対象仕訳.Add(p);
                    }
                }
                var 借方仕訳 = 抽出した集計対象仕訳.Where(o => o.貸借 == 仕訳.貸借区分.借方);
                var 貸方仕訳 = 抽出した集計対象仕訳.Where(o => o.貸借 == 仕訳.貸借区分.貸方);
                decimal 借方金額 = 0;
                decimal 貸方金額 = 0;
                if (借方仕訳.Count() != 0)
                {
                    借方金額 = 借方仕訳.Select(o => o.金額.値).Sum();
                }
                if (貸方仕訳.Count() != 0)
                {
                    貸方金額 = 貸方仕訳.Select(o => o.金額.値).Sum();
                }
                var 勘定科目別残高 = new 勘定科目残高(勘定科目, new 金額(借方金額), new 金額(貸方金額));
                合計残高試算表.追加する(勘定科目別残高);
            }
            return 合計残高試算表;
        }
    }
}
