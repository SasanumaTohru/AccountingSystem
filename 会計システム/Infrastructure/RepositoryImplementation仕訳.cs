using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using System.Collections.Generic;
using System.Linq;

namespace AccountingSystem.Infrastructure
{
    public class RepositoryImplementation仕訳
    {
        private List<T_仕訳> m_仕訳リスト = new List<T_仕訳>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <returns></returns>
        public List<T_仕訳> 検索する(string 伝票番号)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_仕訳.Where(o => o.伝票番号 == 伝票番号);
                return rs.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票"></param>
        /// <param name="勘定科目"></param>
        /// <returns></returns>
        public List<T_仕訳> 伝票番号と勘定科目が一致する仕訳を検索する(伝票 伝票, 科目 勘定科目)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.T_仕訳.Where(o => o.伝票番号 == 伝票.番号.値 & o.勘定科目コード == 勘定科目.コード.値);
                return rs.ToList();
            }
        }
    }
}
