using System.Collections.Generic;
using System.Linq;
using 会計システム.Domain.BusinessObject.勘定科目;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム.ApplicationService
{
    class 勘定科目情報サービス
    {

        private List<科目> m_勘定科目リスト = new List<科目>();

        /// <summary>
        /// 
        /// </summary>
        public List<科目> すべての勘定科目リスト
        {
            get
            {
                using(var MyDB = new Infrastructure.AccountingDBEntities())
                {
                    //var rs = from o in MyDB.M_勘定科目 orderby o.勘定科目コード select o;
                    var rs = MyDB.M_勘定科目.OrderBy(o => o.勘定科目コード).Select(o => o);
                    クエリー結果をリストに格納する(rs);
                }
                return m_勘定科目リスト;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public List<科目> 取引科目リスト
        {
            get
            {
                using (var MyDB = new Infrastructure.AccountingDBEntities())
                {
                    //var rs = from o in MyDB.M_勘定科目 where o.集計科目 == false orderby o.勘定科目コード select o;
                    var rs = MyDB.M_勘定科目.Where(o => o.集計科目 == false).OrderBy(o => o.勘定科目コード).Select(o => o);
                    クエリー結果をリストに格納する(rs);
                }
                return m_勘定科目リスト;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="クエリー結果"></param>
        private void クエリー結果をリストに格納する(IQueryable<Infrastructure.M_勘定科目> クエリー結果)
        {
            m_勘定科目リスト.Clear();
            foreach (Infrastructure.M_勘定科目 レコード in クエリー結果)
            {
                var 科目コード = new コード(レコード.勘定科目コード);
                var 集計科目コード = new コード(レコード.集計科目コード);
                var 勘定科目 = new 科目(科目コード, new 名称(レコード.勘定科目名), 集計科目コード);
                m_勘定科目リスト.Add(勘定科目);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <returns></returns>
        public 名称 勘定科目名を照会する(コード 勘定科目コード)
        {
            using (var MyDB = new Infrastructure.AccountingDBEntities())
            {
                //var rs = from o in MyDB.M_勘定科目 where o.勘定科目コード == 勘定科目コード.値  select o;
                var rs = MyDB.M_勘定科目.Where(o => o.勘定科目コード == 勘定科目コード.値).Select(o => o);
                return new 名称(rs.First().勘定科目名);
            }
        }
    }
}
