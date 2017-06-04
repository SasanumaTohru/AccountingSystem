namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public  class 伝票番号
    {
        private string m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="月間伝票番号"></param>
        /// <param name="計上日"></param>
        public 伝票番号(PrimitiveObject.自然数 月間伝票番号,PrimitiveObject.日付 計上日)
        {
            m_値 = 計上日.西暦年月文字列6桁 + "-" + 月間伝票番号.指定桁0埋め文字列を取得する(5);
        }

        public 伝票番号(string 値)
        {
            m_値 = 値;
        }

        /// <summary>
        /// 
        /// </summary>
        public string 値 => m_値;

    }
}
