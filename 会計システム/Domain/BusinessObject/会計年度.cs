using System;

namespace AccountingSystem.Domain.BusinessObject
{
    public class 会計年度
    {
        private 四半期 m_四半期;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="年度開始月"></param>
        public 会計年度(int 年度, int 年度開始月 = 4)
        {
            var 開始日 = new PrimitiveObject.日付(年度, 年度開始月, 1);
            m_四半期 = new 四半期(開始日);
        }

        /// <summary>
        /// 
        /// </summary>
        public int 値 => m_四半期.第1四半期.開始日.値.Year;

        /// <summary>
        /// 
        /// </summary>
        public FoundationObject.期間 期間 => new FoundationObject.期間(m_四半期.第1四半期.開始日,m_四半期.第4四半期.終了日);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        public string 指定した日付の会計年度(PrimitiveObject.日付 基準日)
        {
            return $"{帰属年度を取得する(基準日).ToString()}年度";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        private int 帰属年度を取得する(PrimitiveObject.日付 基準日)
        {
            int 帰属年 = 基準日.値.Year;
            if(基準日.値.Month < m_四半期.第1四半期の開始月)
            {
                --帰属年;
            }
            return 帰属年;
        }

        /// <summary>
        /// 
        /// </summary>
        public string 現在の会計年度 => $"{帰属年度を取得する(new PrimitiveObject.日付(DateTime.Today)).ToString()}年度";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        public string 指定した日付の会計年度を和暦で取得する(PrimitiveObject.日付 基準日)
        {
            int 西暦会計年度 = 帰属年度を取得する(基準日);
            PrimitiveObject.日付 和暦変換用日付 = new PrimitiveObject.日付(西暦会計年度, 1, 1);
            return $"{和暦変換用日付.和暦年}度";
        }

        /// <summary>
        /// 
        /// </summary>
        public string 現在の和暦会計年度 => 指定した日付の会計年度を和暦で取得する(new PrimitiveObject.日付(DateTime.Today));

        /// <summary>
        /// 
        /// </summary>
        public 四半期 四半期 => m_四半期;
    }
}
