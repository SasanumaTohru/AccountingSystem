using AccountingSystem.Domain.BusinessObject.勘定科目;
using AccountingSystem.Domain.PrimitiveObject;
using System.Collections.Generic;

namespace AccountingSystem.ApplicationService
{
    public class 勘定科目情報サービス
    {
        private Infrastructure.RepositoryImplementation勘定科目 勘定科目RI = new Infrastructure.RepositoryImplementation勘定科目();
        private List<科目> m_勘定科目リスト = new List<科目>();

        /// <summary>
        /// 
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<科目> すべての勘定科目リスト
        {
            get
            {
                クエリー結果をリストに格納する(勘定科目RI.すべての勘定科目を取得する());
                return m_勘定科目リスト.AsReadOnly();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<科目> 取引勘定科目リスト
        {
            get
            {
                クエリー結果をリストに格納する(勘定科目RI.取引勘定科目を取得する());
                return m_勘定科目リスト.AsReadOnly();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="クエリー結果"></param>
        private void クエリー結果をリストに格納する(List<Infrastructure.M_勘定科目> クエリー結果)
        {
            m_勘定科目リスト.Clear();
            foreach (var レコード in クエリー結果)
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
            return 勘定科目RI.勘定科目名を照会する(勘定科目コード);
        }
    }
}
