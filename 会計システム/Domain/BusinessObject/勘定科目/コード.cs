using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 会計システム.Domain.BusinessObject.勘定科目
{
    public class コード
    {

        private int m_値;

        public コード(int 値)
        {
            m_値 = 値;
        }

        public int 値
        {
            get
            {
                return m_値;
            }
        }
    }
}
