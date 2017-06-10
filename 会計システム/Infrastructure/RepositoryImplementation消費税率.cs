using System;
using System.Linq;

namespace AccountingSystem.Infrastructure
{
    public class RepositoryImplementation消費税率
    {

        private DateTime m_消費税法施行日 = new DateTime(1989, 4, 1);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="基準日"></param>
        /// <returns></returns>
        public decimal 適用消費税率(DateTime 基準日)
        {
            if(基準日 < m_消費税法施行日)
            {
                throw new Exception("消費税法の施行前です。");
            }

            using (var MyDB = new AccountingDBEntities())
            {
                var 施行済み消費税の適用開始日 = MyDB.M_消費税率.Where(o => o.適用開始日 <= 基準日).Select(p => p.適用開始日);
                DateTime 直近適用開始日 = 施行済み消費税の適用開始日.Max();

                var 摘要消費税 = MyDB.M_消費税率.Where(o => o.適用開始日 == 直近適用開始日.Date);
                return (decimal)摘要消費税.First().税率;
            }

        }
    }
}
