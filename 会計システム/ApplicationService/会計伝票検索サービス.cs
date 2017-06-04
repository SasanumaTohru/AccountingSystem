using AccountingSystem.Domain.BusinessObject.会計伝票;
using System;
using System.Collections.Generic;

namespace AccountingSystem.ApplicationService
{
    public class 会計伝票検索サービス
    {

        private List<伝票> m_伝票リスト = new List<伝票>();
        会計伝票構築サービス 伝票構築サービス = new 会計伝票構築サービス();

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
            var 会計伝票RI = new Infrastructure.RepositoryImplementation会計伝票();
            List<Infrastructure.T_会計伝票> 検索した会計伝票 = 会計伝票RI.計上日で検索する(計上日);
            foreach (var item in 検索した会計伝票)
            {
                m_伝票リスト.Add(伝票構築サービス.伝票を構築する(item.伝票番号));
            }
            return m_伝票リスト;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="開始日"></param>
        /// <param name="終了日"></param>
        /// <returns></returns>
        public List<伝票> 期間で検索する(DateTime 開始日,DateTime 終了日) 
        {
            m_伝票リスト.Clear();
            var 会計伝票RI = new Infrastructure.RepositoryImplementation会計伝票();
            List<Infrastructure.T_会計伝票> 検索した会計伝票 = 会計伝票RI.期間で検索する(開始日, 終了日);
            foreach (var item in 検索した会計伝票)
            {
                m_伝票リスト.Add(伝票構築サービス.伝票を構築する(item.伝票番号));
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
            var 会計伝票RI = new Infrastructure.RepositoryImplementation会計伝票();
            List<string> 検索した伝票番号 = 会計伝票RI.勘定科目で検索する(勘定科目コード);
            foreach (var item in 検索した伝票番号)
            {
                m_伝票リスト.Add(伝票構築サービス.伝票を構築する(item));
            }
            return m_伝票リスト;
        }
    }
}
