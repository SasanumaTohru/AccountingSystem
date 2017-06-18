using System;

namespace AccountingSystem.Domain.BusinessObject
{
    public class 四半期
    {
        private FoundationObject.期間 m_第1四半期;
        private FoundationObject.期間 m_第2四半期;
        private FoundationObject.期間 m_第3四半期;
        private FoundationObject.期間 m_第4四半期;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="年度開始日"></param>
        public 四半期(PrimitiveObject.日付 年度開始日)
        {
            m_第1四半期 = 四半期の期間を設定する(年度開始日);
            m_第2四半期 = 四半期の期間を設定する(new PrimitiveObject.日付(m_第1四半期.終了日.値.AddDays(1)));
            m_第3四半期 = 四半期の期間を設定する(new PrimitiveObject.日付(m_第2四半期.終了日.値.AddDays(1)));
            m_第4四半期 = 四半期の期間を設定する(new PrimitiveObject.日付(m_第3四半期.終了日.値.AddDays(1)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="四半期開始日"></param>
        /// <returns></returns>
        private FoundationObject.期間 四半期の期間を設定する(PrimitiveObject.日付 四半期開始日)
        {
            DateTime 二カ月後 = 四半期開始日.値.AddMonths(2);
            int 二ヶ月後の月の日数 = DateTime.DaysInMonth(二カ月後.Year, 二カ月後.Month);
            var 四半期終了日 = new PrimitiveObject.日付(二カ月後.Year, 二カ月後.Month, 二ヶ月後の月の日数);
            return new FoundationObject.期間(四半期開始日, 四半期終了日);
        }

        /// <summary>
        /// 
        /// </summary>
        public FoundationObject.期間 第1四半期 => m_第1四半期;

        /// <summary>
        /// 
        /// </summary>
        public int 第1四半期の開始月 => m_第1四半期.開始日.値.Month;

        /// <summary>
        /// 
        /// </summary>
        public FoundationObject.期間 第2四半期 => m_第2四半期;

        /// <summary>
        /// 
        /// </summary>
        public int 第2四半期の開始月 => m_第2四半期.開始日.値.Month;
        /// <summary>
        /// 
        /// </summary>
        public FoundationObject.期間 第3四半期 => m_第3四半期;

        /// <summary>
        /// 
        /// </summary>
        public int 第3四半期の開始月 => m_第3四半期.開始日.値.Month;
        /// <summary>
        /// 
        /// </summary>
        public FoundationObject.期間 第4四半期 => m_第4四半期;

        /// <summary>
        /// 
        /// </summary>
        public int 第4四半期の開始月 => m_第4四半期.開始日.値.Month;

    }
}
