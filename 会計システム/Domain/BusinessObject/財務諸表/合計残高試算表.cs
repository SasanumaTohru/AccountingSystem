using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 合計残高試算表
    {
        private List<勘定科目残高> m_勘定科目別残高 = new List<勘定科目残高>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目残高"></param>
        public void 追加する(勘定科目残高 勘定科目残高)
        {
            m_勘定科目別残高.Add(勘定科目残高);
        }

        private void 集計する()
        {
            int 最大集計区分 = 3;
            for (int 集計区分 = 最大集計区分; 集計区分 > -1; 集計区分--)
            {
                foreach (var p in m_勘定科目別残高.Where(o => o.勘定科目.集計区分 == 集計区分))
                {
                    var rs = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == p.勘定科目.集計科目コード.値);
                    if (rs.Count() != 0)
                    {
                        勘定科目残高 集計先 = rs.First();
                        集計先.金額を加算する(p.金額);
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<勘定科目残高> 勘定科目別残高リスト
        {
            get
            {
                //集計する();
                return m_勘定科目別残高.AsReadOnly();
            }
        }
    }
}
