namespace 会計システム.Domain.BusinessObject.勘定科目
{
    public class コード
    {

        private int m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        public コード(int 値)
        {
            m_値 = 値;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int 値 => m_値;

    }
}
