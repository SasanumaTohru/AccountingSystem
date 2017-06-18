using System;

namespace AccountingSystem.ApplicationService.共通
{
    public class 識別子作成サービス
    {
        /// <summary>
        /// 
        /// </summary>
        public string 時間文字列
        {
            get
            {
                DateTime m_時刻 = DateTime.Now;
                return m_時刻.Hour.ToString("00") + m_時刻.Minute.ToString("00") + m_時刻.Second.ToString("00") + m_時刻.Millisecond.ToString("000");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 日付文字列
        {
            get
            {
                var m_日付 = new Domain.PrimitiveObject.日付(DateTime.Now);
                return m_日付.数値文字列;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 日時文字列 => 日付文字列 + 時間文字列;
    }
}
