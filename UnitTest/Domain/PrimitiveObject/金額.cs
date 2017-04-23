using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Domain.PrimitiveObject
{
    public  class 金額
    {
        private decimal m_値;

        public 金額(decimal 値)
        {
            m_値 = 値;
        }

        public decimal 値()
        {
            return m_値;
        }
    }
}
