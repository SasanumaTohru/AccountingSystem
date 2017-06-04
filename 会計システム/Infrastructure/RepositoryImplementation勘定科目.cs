using System.Collections.Generic;
using System.Linq;

namespace AccountingSystem.Infrastructure
{
    public class RepositoryImplementation勘定科目
    {
        List<M_勘定科目> m_勘定科目リスト = new List<M_勘定科目>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<M_勘定科目> すべての勘定科目を取得する()
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.M_勘定科目.OrderBy(o => o.勘定科目コード);
                クエリー結果をリストに格納する(rs);
                return m_勘定科目リスト;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<M_勘定科目> 取引勘定科目を取得する()
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.M_勘定科目.Where(o => o.集計科目 == false).OrderBy(p => p.勘定科目コード);
                クエリー結果をリストに格納する(rs);
                return m_勘定科目リスト;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rs"></param>
        private void クエリー結果をリストに格納する(IOrderedQueryable<M_勘定科目> rs)
        {
            m_勘定科目リスト.Clear();
            foreach (var p in rs)
            {
                m_勘定科目リスト.Add(p);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <returns></returns>
        public Domain.PrimitiveObject.名称 勘定科目名を照会する(Domain.BusinessObject.勘定科目.コード 勘定科目コード)
        {
            using (var MyDB = new AccountingDBEntities())
            {
                var rs = MyDB.M_勘定科目.Where(o => o.勘定科目コード == 勘定科目コード.値);
                return new Domain.PrimitiveObject.名称(rs.First().勘定科目名);
            }
        }

    }
}
