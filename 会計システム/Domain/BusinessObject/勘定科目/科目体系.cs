using System.Collections.Generic;

namespace 会計システム.Domain.BusinessObject.勘定科目
{
    /// <summary>
    /// 研究中
    /// </summary>
    public class 科目体系
    {
        private  List<科目> m_一覧 = new List<科目>();
        
        public 科目体系()
        {
            科目 資産 = new 科目(new コード(100001), new PrimitiveObject.名称("資産"));
            科目 流動資産 = new 科目(new コード(100002), new PrimitiveObject.名称("流動資産"));
            科目 現金預金 = new 科目(new コード(100003), new PrimitiveObject.名称("現金預金"));
            科目 普通預金 = new 科目(new コード(100004), new PrimitiveObject.名称("普通預金"));
            m_一覧.Add(資産);
            m_一覧.Add(流動資産);
            m_一覧.Add(現金預金);
            m_一覧.Add(普通預金);           
        }

        public List<科目> 一覧
        {
            get
            {
                return m_一覧;
            }
        }
    }
}
