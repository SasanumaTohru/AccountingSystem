namespace AccountingSystem.Domain.BusinessObject
{
    public class 四半期
    {
        private int m_第1四半期開始月;
        private int m_第2四半期開始月;
        private int m_第3四半期開始月;
        private int m_第4四半期開始月;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="年度開始月"></param>
        public 四半期(int 年度開始月)
        {
            m_第1四半期開始月 = 年度開始月;
            m_第2四半期開始月 = 次の四半期の開始月(m_第1四半期開始月);
            m_第3四半期開始月 = 次の四半期の開始月(m_第2四半期開始月);
            m_第4四半期開始月 = 次の四半期の開始月(m_第3四半期開始月);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="前の四半期の開始月"></param>
        /// <returns></returns>
        private int 次の四半期の開始月(int 前の四半期の開始月)
        {
            int 次の四半期の開始月 = 前の四半期の開始月 + 3;
            if (次の四半期の開始月 > 12)
            {
                次の四半期の開始月 = 次の四半期の開始月 - 12;
            }
            return 次の四半期の開始月;
        }

        /// <summary>
        /// 
        /// </summary>
        public int 第1四半期の開始月 => m_第1四半期開始月;

        /// <summary>
        /// 
        /// </summary>
        public int 第2四半期の開始月 => m_第2四半期開始月;

        /// <summary>
        /// 
        /// </summary>
        public int 第3四半期の開始月 => m_第3四半期開始月;

        /// <summary>
        /// 
        /// </summary>
        public int 第4四半期の開始月 => m_第4四半期開始月;

    }
}
