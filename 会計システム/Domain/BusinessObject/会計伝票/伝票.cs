namespace 会計システム.Domain.BusinessObject.会計伝票
{
    public class 伝票
    {
        private 番号 m_番号;
        private PrimitiveObject.日付 m_計上日;
        private 仕訳列 m_借方仕訳 = new 仕訳列();
        private 仕訳列 m_貸方仕訳 = new 仕訳列();

        public 伝票(番号 伝票番号,PrimitiveObject.日付 計上日)
        {
            m_番号 = 伝票番号;
            m_計上日 = 計上日;
        }

        public 番号 番号 => m_番号;

        public PrimitiveObject.日付 計上日 => m_計上日;

        public void 追加する(仕訳 仕訳)
        {
            switch (仕訳.貸借)
            {
                case 仕訳.貸借区分.借方:
                    m_借方仕訳.追加する(仕訳);
                    break;
                case 仕訳.貸借区分.貸方:
                    m_貸方仕訳.追加する(仕訳);
                    break;
            }
        }

        public 仕訳列 借方 => m_借方仕訳;

        public 仕訳列 貸方 => m_貸方仕訳;

    }
}
