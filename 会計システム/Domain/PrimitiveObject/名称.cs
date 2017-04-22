using System;

namespace 会計システム.Domain.PrimitiveObject
{
    public  class 名称
    {
        private string  m_値;

        public 名称(string 値)
        {
            string 空白除去後の値 = 値.Trim();
            名称になり得る文字列がある(空白除去後の値);
            m_値 = 空白除去後の値;
        }

        private static void 名称になり得る文字列がある(string 空白除去後の値)
        {
            if (string.IsNullOrEmpty(空白除去後の値))
            {
                throw new Exception("名称になり得る文字列がありません。");
            }
        }

        public string 値()
        {
            return m_値;
        }
    }
}
