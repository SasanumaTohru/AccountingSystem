namespace 会計システム.Domain.BusinessObject.勘定科目
{
    public  class 科目
    {
        private コード m_コード;
        private PrimitiveObject.名称 m_名称;
        private コード m_集計科目コード;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        public 科目(コード コード, PrimitiveObject.名称 名称)
        {
            コードと名称を格納する(コード, 名称);
            m_集計科目コード = m_コード;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        /// <param name="集計科目コード"></param>
        public 科目(コード コード, PrimitiveObject.名称 名称, コード 集計科目コード)
        {
            コードと名称を格納する(コード, 名称);
            m_集計科目コード = 集計科目コード;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        private void コードと名称を格納する(コード コード, PrimitiveObject.名称 名称)
        {
            m_コード = コード;
            m_名称 = 名称;
        }

        /// <summary>
        /// 
        /// </summary>
        public コード コード => m_コード;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.名称 名称 => m_名称;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.文字列 コードと名称 => new PrimitiveObject.文字列( m_コード.値.ToString() + " : " + m_名称.値);

        /// <summary>
        /// 
        /// </summary>
        public コード 集計科目コード => m_集計科目コード;
       
    }
}
