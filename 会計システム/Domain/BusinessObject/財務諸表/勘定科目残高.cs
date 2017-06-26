using System;
using AccountingSystem.Domain.PrimitiveObject;

namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 勘定科目残高
    {
        private 勘定科目.科目 m_勘定科目;
        private 金額 m_金額;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目"></param>
        /// <param name="金額"></param>
        public 勘定科目残高(勘定科目.科目 勘定科目, 金額 金額)
        {
            m_勘定科目 = 勘定科目;
            m_金額 = 金額;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目"></param>
        /// <param name="借方金額"></param>
        /// <param name="貸方金額"></param>
        public 勘定科目残高(勘定科目.科目 勘定科目, 金額 借方金額, 金額 貸方金額)
        {
            m_勘定科目 = 勘定科目;
            switch (m_勘定科目.貸借区分)
            {
                case 貸借.区分.借方:
                    m_金額 = new 金額(借方金額.値 - 貸方金額.値);
                    break;
                case 貸借.区分.貸方:
                    m_金額 = new 金額(貸方金額.値 - 借方金額.値);
                    break;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="金額"></param>
        internal void 金額を加算する(金額 金額)
        {
            m_金額 = new 金額(m_金額.値 + 金額.値);
       
        }

        /// <summary>
        /// 
        /// </summary>
        public string 勘定科目と金額 => $"{m_勘定科目.名称.値} {m_金額.桁区切り値}";

        /// <summary>
        /// 
        /// </summary>
        public 勘定科目.科目 勘定科目 => m_勘定科目;

        /// <summary>
        /// 
        /// </summary>
        public 金額 金額 => m_金額;
    }
}
