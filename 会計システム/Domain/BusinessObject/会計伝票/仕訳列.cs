using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 仕訳列
    {
        private List<仕訳> m_仕訳列 = new List<仕訳>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳"></param>
        public void 追加する(仕訳 仕訳)
        {
            m_仕訳列.Add(仕訳);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳列"></param>
        public void 追加する(仕訳列 仕訳列)
        {
            foreach (var p in 仕訳列.リスト)
            {
                m_仕訳列.Add(p);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyCollection<仕訳> リスト => m_仕訳列.AsReadOnly();
        
        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 合計金額
        {
            get
            {
                decimal 合計金額 = 0m;
                if (m_仕訳列.Count() != 0)
                {
                    合計金額 = m_仕訳列.Select(仕訳 => 仕訳.金額.値).Sum();
                }
                return new PrimitiveObject.金額(合計金額);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="貸借区分"></param>
        /// <returns></returns>
        public PrimitiveObject.金額 貸借別合計金額を取得する(貸借.区分 貸借区分)
        {
            decimal 貸借別合計金額 = 0m;
            switch (貸借区分)
            {
                case 貸借.区分.借方:
                    var 借方仕訳 = m_仕訳列.Where(o => o.貸借 == 貸借.区分.借方);
                    if (借方仕訳.Count() != 0)
                    {
                        貸借別合計金額 = 借方仕訳.Select(o => o.金額.値).Sum();
                    }
                    break;
                case 貸借.区分.貸方:
                    var 貸方仕訳 = m_仕訳列.Where(o => o.貸借 == 貸借.区分.貸方);
                    if (貸方仕訳.Count() != 0)
                    {
                        貸借別合計金額 = 貸方仕訳.Select(o => o.金額.値).Sum();
                    }
                    break;
            }
            return new PrimitiveObject.金額(貸借別合計金額);
        }

        /// <summary>
        /// 
        /// </summary>
        internal void すべての仕訳の貸借を反転する()
        {
            foreach (var p in m_仕訳列)
            {
                p.貸借を反転する();
            }
        }
    }
}
