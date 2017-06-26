namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 四半期末勘定科目残高
    {

        private 勘定科目.コード m_勘定科目コード;
        private 会計年度 m_会計年度;
        private 四半期決算.四半期区分リスト m_四半期区分;
        private PrimitiveObject.金額 m_金額;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <param name="会計年度"></param>
        /// <param name="四半期区分"></param>
        /// <param name="金額"></param>
        public 四半期末勘定科目残高(勘定科目.コード 勘定科目コード, 会計年度 会計年度, 四半期決算.四半期区分リスト 四半期区分, PrimitiveObject.金額 金額)
        {
            m_勘定科目コード = 勘定科目コード;
            m_会計年度 = 会計年度;
            m_四半期区分 = 四半期区分;
            m_金額 = 金額;
        }

        /// <summary>
        /// 
        /// </summary>
        public 勘定科目.コード 勘定科目コード => m_勘定科目コード;

        /// <summary>
        /// 
        /// </summary>
        public 会計年度 会計年度 => m_会計年度;

        /// <summary>
        /// 
        /// </summary>
        public 四半期決算.四半期区分リスト 四半期区分 => m_四半期区分;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 金額 => m_金額;
    }
}
