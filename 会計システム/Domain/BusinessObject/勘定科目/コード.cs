namespace 会計システム.Domain.BusinessObject.勘定科目
{
    public class コード
    {

        private int m_値;

        public コード(int 値)
        {
            m_値 = 値;
        }

        public int 値 => m_値;
    }
}
