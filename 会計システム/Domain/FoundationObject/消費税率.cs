namespace AccountingSystem.Domain.FoundationObject
{
    public class 消費税率
    {
        private decimal m_値;

        /// <summary>
        /// 
        /// </summary>
        public 消費税率(decimal 消費税率)
        {
            m_値 = 消費税率;
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal 値 => m_値;

        public string パーセント表示 => m_値.ToString("0%");

        /// <summary>
        /// 
        /// </summary>
        public decimal 課税対象金額を求める除数 => 1m + m_値;
    }
}
