﻿namespace AccountingSystem.Domain.PrimitiveObject
{
    public  class 金額
    {
        private decimal m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        public 金額(decimal 値)
        {
            m_値 = 値;
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal 値 => m_値;

        /// <summary>
        /// 
        /// </summary>
        public string 桁区切り値 => m_値.ToString("#,##0;△#,##0;");
    }
}
