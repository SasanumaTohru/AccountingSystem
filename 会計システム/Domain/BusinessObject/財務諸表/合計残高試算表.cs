using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 合計残高試算表
    {
        private List<勘定科目残高> m_勘定科目別残高 = new List<勘定科目残高>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目残高"></param>
        public void 追加する(勘定科目残高 勘定科目残高)
        {
            m_勘定科目別残高.Add(勘定科目残高);
        }

        /// <summary>
        /// 
        /// </summary>
        private void 集計する()
        {
            int 最大集計区分 = m_勘定科目別残高.Select(o => o.勘定科目.集計区分).Max();
            int 最小集計区分 = m_勘定科目別残高.Select(o => o.勘定科目.集計区分).Min();
            for (int 集計区分 = 最大集計区分; 集計区分 > 最小集計区分; 集計区分--)
            {
                var 集計元勘定 = m_勘定科目別残高.Where(o => o.勘定科目.集計区分 == 集計区分);
                foreach (var p in 集計元勘定)
                {
                    var rs = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == p.勘定科目.集計科目コード.値);
                    if (rs.Count() != 0)
                    {
                        勘定科目残高 集計先 = rs.First();
                        集計先.金額を加算する(p.金額);
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public System.Collections.ObjectModel.ReadOnlyCollection<勘定科目残高> 勘定科目別残高リスト
        {
            get
            {
                集計する();
                利益を計算する();
                return m_勘定科目別残高.AsReadOnly();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void 利益を計算する()
        {
            // ToDo:利益計算
            // コレクションにして
            const int 利益科目コード = 599999;
            const string 利益科目名 = "純利益";
            const int 計算対象収益科目コード = 500000;
            const int 計算対象費用科目コード = 400000;

            // foreach にする
            勘定科目.科目 純利益 = new 勘定科目.科目(new 勘定科目.コード(利益科目コード), new PrimitiveObject.名称(利益科目名));
            勘定科目残高 収益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == 計算対象収益科目コード).First();
            勘定科目残高 費用 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == 計算対象費用科目コード).First();
            m_勘定科目別残高.Add(new 勘定科目残高(純利益, new PrimitiveObject.金額(収益.金額.値 - 費用.金額.値)));
        }
    }
}
