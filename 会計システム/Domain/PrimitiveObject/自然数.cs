using System;

namespace 会計システム.Domain.PrimitiveObject
{
    public  class 自然数
    {
        private int m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        public 自然数(int 値)
        {
            ゼロ以上の整数である(値);
            m_値 = 値;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        private static void ゼロ以上の整数である(int 値)
        {
            if ( 値 < 0 )
            {
                throw new Exception("0以上の整数ではありません。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int 値 => m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="桁数"></param>
        /// <returns></returns>
        public string 指定桁0埋め文字列を取得する(int 桁数)
        {
            return String.Format("{0:D" + 桁数.ToString() + "}", m_値); 
        }
    }
}
