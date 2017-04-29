using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 会計システム.Domain.BusinessObject.勘定科目
{
    public  class 科目
    {
        private コード m_コード;
        private PrimitiveObject.名称 m_名称;
        private 科目 m_集計科目;

        public 科目(コード コード, PrimitiveObject.名称 名称)
        {
            m_コード = コード;
            m_名称 = 名称;
            m_集計科目 = this;
        }

        public 科目(コード コード, PrimitiveObject.名称 名称, 科目 集計科目)
        {
            m_コード = コード;
            m_名称 = 名称;
            m_集計科目 = 集計科目;
        }
        
        public コード コード => m_コード;

        public PrimitiveObject.名称 名称 => m_名称;

        public 科目 集計科目 => m_集計科目;
    }
}
