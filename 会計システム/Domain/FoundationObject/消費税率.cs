namespace 会計システム.Domain.FoundationObject
{
    public class 消費税率
    {
        private decimal m_値;

        public 消費税率()
        {
            m_値 = 0.08m;    //ToDo:仮実装
        }

        public decimal 値 => m_値;

        public decimal 課税対象金額を求める除数 => 1m + m_値;
    }
}
