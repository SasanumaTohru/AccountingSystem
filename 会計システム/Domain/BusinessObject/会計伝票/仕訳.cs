namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 仕訳
    {
        public enum 貸借区分
        {
            借方=1,
            貸方=2,
        }

        private 勘定科目.科目 m_勘定科目;
        private PrimitiveObject.必須文字列 m_摘要;
        private PrimitiveObject.金額 m_金額;
        private 貸借区分 m_貸借区分;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目"></param>
        /// <param name="摘要"></param>
        /// <param name="金額"></param>
        /// <param name="貸借"></param>
        public 仕訳(勘定科目.科目 勘定科目,PrimitiveObject.必須文字列 摘要, PrimitiveObject.金額 金額,貸借区分 貸借)
        {
            金額は0円以下ではない(金額);
            m_勘定科目 = 勘定科目;
            m_摘要 = 摘要;
            m_金額 = 金額;
            m_貸借区分 = 貸借;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="金額"></param>
        private static void 金額は0円以下ではない(PrimitiveObject.金額 金額)
        {
            if (金額.値 <= 0)
            {
                throw new System.Exception("仕訳に0円以下の金額を入力することはできません。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 勘定科目.科目 勘定科目 => m_勘定科目;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.必須文字列 摘要 => m_摘要;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 金額 => m_金額;

        /// <summary>
        /// 
        /// </summary>
        public 貸借区分 貸借 => m_貸借区分;
    }
}
