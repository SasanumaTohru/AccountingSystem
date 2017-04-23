using System;

namespace 会計システム.Domain.PrimitiveObject
{
    public  class 自然数
    {
        private int m_値;

        public 自然数(int 値)
        {
            ゼロ以上の整数である(値);
            m_値 = 値;
        }

        private static void ゼロ以上の整数である(int 値)
        {
            if ( 値 < 0 )
            {
                throw new Exception("0以上の整数ではありません。");
            }
        }

        public int 値()
        {
            return m_値;
        }
    }
}
