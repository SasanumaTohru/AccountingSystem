using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 四半期決算
    {
        public enum 四半期区分リスト
        {
            第1四半期 = 1,
            第2四半期 = 2,
            第3四半期 = 3,
            第4四半期 = 4
        }

        private 会計年度 m_会計年度;
        private 四半期区分リスト m_四半期区分;
        private List<四半期末勘定科目残高> m_科目別残高 = new List<四半期末勘定科目残高>();

        public 四半期決算(会計年度 会計年度, 四半期区分リスト 四半期)
        {
            m_会計年度 = 会計年度;
            m_四半期区分 = 四半期;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="科目別残高"></param>
        public void 追加する(四半期末勘定科目残高 科目別残高)
        {
            if (科目別残高.会計年度.値 != m_会計年度.値 | 科目別残高.四半期区分 != m_四半期区分)
            {
                throw new Exception("指定された残高の年度と四半期区分が正しくありません。");
            }
            //ToDo:同じ科目の追加は例外
            m_科目別残高.Add(科目別残高);
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyCollection<四半期末勘定科目残高> 科目別残高リスト
        {
            get
            {
                return m_科目別残高.AsReadOnly();
            }
        }
    }
}
