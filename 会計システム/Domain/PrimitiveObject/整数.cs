namespace 会計システム.Domain.PrimitiveObject
{
    public  class 整数
    {
        private int m_値;

        public 整数(int 値)
        {
            m_値 = 値;
        }

        public int 値 => m_値;
    }
}
