using System.Collections.Generic;

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

        /// <summary>
        /// 
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<勘定科目残高> 勘定科目別残高リスト
        {
            get
            {
                return m_勘定科目別残高.AsReadOnly();
            }
        }
    }
}
