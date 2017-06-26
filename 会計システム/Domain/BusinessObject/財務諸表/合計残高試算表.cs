using System.Collections.Generic;
using System.Linq;

namespace AccountingSystem.Domain.BusinessObject.財務諸表
{
    public class 合計残高試算表
    {
        private List<勘定科目残高> m_勘定科目別残高 = new List<勘定科目残高>();
        private 勘定科目.利益計算情報 m_利益計算情報;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="利益計算情報"></param>
        public 合計残高試算表(勘定科目.利益計算情報 利益計算情報)
        {
            m_利益計算情報 = 利益計算情報;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="勘定科目残高"></param>
        public void 追加する(勘定科目残高 勘定科目残高)
        {
            //ToDo:同じ科目の追加は例外
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
            var 売上総利益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.売上総利益.コード.値).First();
            var 売上 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.売上.コード.値).First();
            var 売上原価 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.売上原価.コード.値).First();
            売上総利益.金額を加算する(new PrimitiveObject.金額(売上.金額.値 - 売上原価.金額.値));

            var 営業利益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.営業利益.コード.値).First();
            var 販売費及び一般管理費 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.販売費及び一般管理費.コード.値).First();
            営業利益.金額を加算する(new PrimitiveObject.金額(売上総利益.金額.値 - 販売費及び一般管理費.金額.値));

            var 経常利益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.経常利益.コード.値).First();
            var 営業外収益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.営業外収益.コード.値).First();
            var 営業外費用 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.営業外費用.コード.値).First();
            経常利益.金額を加算する(new PrimitiveObject.金額(営業利益.金額.値 + 営業外収益.金額.値 - 営業外費用.金額.値));

            var 純利益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.純利益.コード.値).First();
            var 特別利益 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.特別利益.コード.値).First();
            var 特別損失 = m_勘定科目別残高.Where(o => o.勘定科目.コード.値 == m_利益計算情報.特別損失.コード.値).First();
            純利益.金額を加算する(new PrimitiveObject.金額(経常利益.金額.値 + 特別利益.金額.値 - 特別損失.金額.値));
        }
    }
}
