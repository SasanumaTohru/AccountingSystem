using System;

namespace AccountingSystem.Domain.FoundationObject
{
    public class 消費税課税金額
    {
        private PrimitiveObject.金額 m_課税対象金額;
        private PrimitiveObject.金額 m_消費税額;
        private 消費税率 m_適用消費税率;

        public enum 計算方法
        {
            課税対象金額=1,
            税込金額 =2,
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="金額"></param>
        /// <param name="入力値"></param>
        public 消費税課税金額(PrimitiveObject.金額 金額, 計算方法 入力値 = 計算方法.課税対象金額 ,decimal 消費税率 = 0.08m) 
        {
            m_適用消費税率 = new 消費税率(消費税率);
            switch ( 入力値 )
            {
                case 計算方法.課税対象金額:
                    m_課税対象金額 = 金額;
                    decimal 消費税の計算結果 = 小数点以下は切り捨てる();
                    m_消費税額 = new PrimitiveObject.金額(消費税の計算結果);
                    break;
                case 計算方法.税込金額:
                    decimal 課税対象金額の計算結果 = 小数点以下は切り上げる(金額);
                    m_課税対象金額 = new PrimitiveObject.金額(課税対象金額の計算結果);
                    m_消費税額 = new PrimitiveObject.金額(金額.値 - m_課税対象金額.値);
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="金額"></param>
        /// <returns></returns>
        private decimal 小数点以下は切り上げる(PrimitiveObject.金額 金額)
        {
            return Math.Ceiling(金額.値 / m_適用消費税率.課税対象金額を求める除数);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private decimal 小数点以下は切り捨てる()
        {
            return Math.Floor(m_課税対象金額.値 * m_適用消費税率.値);
        }

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 課税対象金額 => m_課税対象金額;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 消費税額 => m_消費税額;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 税込金額 => new PrimitiveObject.金額(m_課税対象金額.値 + m_消費税額.値);

        /// <summary>
        /// 
        /// </summary>
        public 消費税率 税率 => m_適用消費税率;
    }
}
