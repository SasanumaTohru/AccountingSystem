using System;
using System.Globalization;

namespace 会計システム.Domain.PrimitiveObject
{
    public class 日付
    {
        private DateTime m_値;

        public enum 曜日表示
        {
            あり=1,
            なし=2,
        }
          
        public 日付(int 年, int 月, int 日)
        {
            m_値 = new DateTime(年, 月, 日);
        }

        public 日付(DateTime 日付)
        {
            m_値 = 日付;
        }

        public DateTime 値 => m_値;

        public string 西暦年月日(曜日表示 曜日表示 =曜日表示.なし)
        {
            string レスポンス;
            switch ( 曜日表示 )
            {
                case 曜日表示.なし:
                    レスポンス = m_値.ToString("yyyy年M月d日");
                    break;
                case 曜日表示.あり:
                    レスポンス = m_値.ToString("yyyy年M月d日(ddd)");
                    break;
                default:
                    throw new Exception("曜日表示設定に誤りがあります。");
            }
            return レスポンス;
        }

        public string 和暦年月日(曜日表示 曜日表示 = 曜日表示.なし)
        {
            CultureInfo 日本のカルチャー = new CultureInfo("ja-JP", true);
            日本のカルチャー.DateTimeFormat.Calendar = new JapaneseCalendar();
            string レスポンス;
            switch ( 曜日表示 )
            {
                case 曜日表示.なし:
                    レスポンス = m_値.ToString("ggyy年M月d日", 日本のカルチャー);
                    break;
                case 曜日表示.あり:
                    レスポンス = m_値.ToString("ggyy年M月d日(ddd)", 日本のカルチャー);
                    break;
                default:
                    throw new Exception("曜日表示設定に誤りがあります。");
            }
            return レスポンス;
        }

        public string 西暦文字列 => m_値.Year.ToString();

        public string 月文字列2桁 => m_値.Month.ToString("00");

        public string 西暦年月文字列6桁 => 西暦文字列 + 月文字列2桁;


    }
}
