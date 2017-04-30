namespace 会計システム.Domain.BusinessObject.会計伝票
{
    public class 仕訳
    {
        public enum 貸借区分
        {
            借方=1,
            貸方=2,
        }

        private 勘定科目.科目 m_勘定科目;
        private PrimitiveObject.文字列 m_摘要;
        private PrimitiveObject.金額 m_金額;
        private 貸借区分 m_貸借区分;

        public 仕訳(勘定科目.科目 勘定科目,PrimitiveObject.文字列 摘要, PrimitiveObject.金額 金額,貸借区分 貸借)
        {
            m_勘定科目 = 勘定科目;
            m_摘要 = 摘要;
            m_金額 = 金額;
            m_貸借区分 = 貸借;
        }

        public 勘定科目.科目 勘定科目 => m_勘定科目;

        public PrimitiveObject.文字列 摘要 => m_摘要;

        public PrimitiveObject.金額 金額 => m_金額;

        public 貸借区分 貸借 => m_貸借区分;
    }
}
