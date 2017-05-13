using System;

namespace 会計システム.Domain.FoundationObject
{
    public class 消費税率
    {
        private decimal m_値;

        /// <summary>
        /// 
        /// </summary>
        public 消費税率()
        {
            var 消費税率検索サービス = new Infrastructure.消費税率検索サービス();
            m_値 = 消費税率検索サービス.適用消費税率(DateTime.Now.Date);
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal 値 => m_値;

        /// <summary>
        /// 
        /// </summary>
        public decimal 課税対象金額を求める除数 => 1m + m_値;
    }
}
