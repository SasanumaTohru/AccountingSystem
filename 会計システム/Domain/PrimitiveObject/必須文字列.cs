using System;

namespace 会計システム.Domain.PrimitiveObject
{
    public  class 必須文字列
    {
        private string m_値;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        public 必須文字列(string 値)
        {
            string 文末の空白を除去した値 = 値.TrimEnd();
            文字列となり得る文字がある(文末の空白を除去した値);
            m_値 = 文末の空白を除去した値;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        private static void 文字列となり得る文字がある(string 値)
        {
            if ( string.IsNullOrWhiteSpace(値) )
            {
                throw new Exception("文字列となり得る文字がありません。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 値 => m_値;
    }
}
