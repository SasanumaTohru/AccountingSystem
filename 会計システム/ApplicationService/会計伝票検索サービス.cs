using System;
using System.Collections.Generic;
using System.Linq;
using AccountingSystem.Domain.BusinessObject.会計伝票;

namespace AccountingSystem.ApplicationService
{
    public class 会計伝票検索サービス
    {

        private List<伝票> m_伝票リスト = new List<伝票>();
        ApplicationService.会計伝票構築サービス 伝票構築サービス = new 会計伝票構築サービス();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <returns></returns>
        public 伝票 伝票番号で検索する(string 伝票番号)
        {
            return 伝票構築サービス.伝票を構築する(伝票番号);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        public List<伝票> 計上日で検索する(DateTime 計上日)
        {
            m_伝票リスト.Clear();
            using (var MyDB = new Infrastructure.AccountingDBEntities())
            {
                var rs = MyDB.T_会計伝票.Where(o => o.計上日 == 計上日);
                foreach (var item in rs)
                {
                    m_伝票リスト.Add(伝票構築サービス.伝票を構築する(item.伝票番号));
                }
            }
            return m_伝票リスト;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目コード"></param>
        /// <returns></returns>
        public List<伝票> 勘定科目で検索する(int 勘定科目コード)
        {
            m_伝票リスト.Clear();
            using (var MyDB = new Infrastructure.AccountingDBEntities())
            {
                var rs = MyDB.T_仕訳.Where(o => o.勘定科目コード == 勘定科目コード).GroupBy(p => p.伝票番号);
                foreach (var item in rs)
                {
                    m_伝票リスト.Add(伝票構築サービス.伝票を構築する(item.Key));
                }
                return m_伝票リスト;
            }
        }
        
    }
}
