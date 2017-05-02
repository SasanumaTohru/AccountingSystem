using System.Collections.Generic;
using System.Linq;

namespace 会計システム.Domain.BusinessObject.会計伝票
{
    public class 仕訳列
    {
        private List<仕訳> m_仕訳列 = new List<仕訳>();
        
        public void 追加する(仕訳 仕訳)
        {
          m_仕訳列.Add(仕訳);
        }

        public List<仕訳> リスト => m_仕訳列;

        public PrimitiveObject.金額 合計金額
        {
            get
            {
                decimal 合計金額 = m_仕訳列.Select(仕訳 => 仕訳.金額.値).Sum();
                return new PrimitiveObject.金額(合計金額);
            }
        }

    }
}
