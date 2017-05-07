using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 会計システム.ApplicationService
{
    public class 識別子作成サービス
    {

        public string 時間文字列
        {
            get
            {
                DateTime m_時刻 = DateTime.Now;
                return m_時刻.Hour.ToString("00") + m_時刻.Minute.ToString("00") + m_時刻.Second.ToString("00") + m_時刻.Millisecond.ToString("000");
            }
        }

        public string 日付文字列
        {
            get
            {
                会計システム.Domain.PrimitiveObject.日付 m_日付 = new Domain.PrimitiveObject.日付(DateTime.Now);
                return m_日付.数値文字列;
            }
        }

        public string 日時文字列
        {
            get
            {
                return 日付文字列 + 時間文字列;
            }
        }
    }
}
