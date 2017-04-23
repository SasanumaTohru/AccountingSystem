namespace 会計システム.Domain.PrimitiveObject
{
    public  class 金額
    {
        private decimal m_値;

        public 金額(decimal 値)
        {
            m_値 = 値;
        }

        public decimal 値()
        {
            return m_値;
        }

        public string 桁区切り値()
        {
            return m_値.ToString("#,##0;△#,##0;");
        }
    }
}
