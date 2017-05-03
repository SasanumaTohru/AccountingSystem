using System;

namespace 会計システム.Domain.BusinessObject
{
    public class 会計年度
    {
        private int m_年度開始月;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="年度開始月"></param>
        public 会計年度(int 年度開始月)
        {
            m_年度開始月 = 年度開始月;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        public string 指定した日付の会計年度(PrimitiveObject.日付 基準日)
        {
            return 帰属年度を取得する(基準日).ToString() + "年度";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        private int 帰属年度を取得する(PrimitiveObject.日付 基準日)
        {
            int 年度終了月 = m_年度開始月 - 1;
            int 帰属年 = 基準日.値.Year;
            int 基準月 = 基準日.値.Month;
            if (1 <= 基準月 && 基準月 <= 年度終了月)
            {
                --帰属年;
            }
            return 帰属年;
        }

        /// <summary>
        /// 
        /// </summary>
        public string 現在の会計年度
        {
            get
            {
                return 帰属年度を取得する(new PrimitiveObject.日付(DateTime.Today)).ToString() + "年度";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        public string 和暦で指定した日付の会計年度を取得する(PrimitiveObject.日付 基準日)
        {
            int 西暦会計年度 = 帰属年度を取得する(基準日);
            PrimitiveObject.日付 和暦変換用日付 = new PrimitiveObject.日付(西暦会計年度, 1, 1);
            return 和暦変換用日付.和暦年 + "度";
        }

        /// <summary>
        /// 
        /// </summary>
        public string 現在の和暦会計年度
        {
            get
            {
                return 和暦で指定した日付の会計年度を取得する(new PrimitiveObject.日付(DateTime.Today));
            }
        }
    }
}
