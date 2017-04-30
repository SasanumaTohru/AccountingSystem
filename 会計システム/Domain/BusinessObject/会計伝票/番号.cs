namespace 会計システム.Domain.BusinessObject.会計伝票
{
    public  class 番号
    {
        private string m_値;

        public 番号(PrimitiveObject.自然数 番号,PrimitiveObject.日付 計上日)
        {
            m_値 = 計上日.西暦年月文字列6桁 + "-" + 番号.指定桁0埋め文字列を取得する(5);
        }

        public string 値 => m_値;

    }
}
