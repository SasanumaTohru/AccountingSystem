namespace AccountingSystem.Domain.FoundationObject
{
    public class 期間
    {
        private PrimitiveObject.日付 m_開始日;
        private PrimitiveObject.日付 m_終了日;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="開始日"></param>
        /// <param name="終了日"></param>
        public 期間(PrimitiveObject.日付 開始日, PrimitiveObject.日付 終了日)
        {
            m_開始日 = 開始日;
            m_終了日 = 終了日;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.日付 開始日 => m_開始日;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.日付 終了日 => m_終了日;

        /// <summary>
        /// 
        /// </summary>
        public int 年数
        {
            get
            {
                int 年数 = m_終了日.値.Year - m_開始日.値.Year;
                if(m_終了日.値 < m_開始日.値.AddYears(年数))
                {
                    年数--;
                }
                return 年数;
            }
        }
    }
}
