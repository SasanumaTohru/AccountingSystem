namespace AccountingSystem.Domain.BusinessObject.勘定科目
{
    public class 利益計算情報
    {
        
        private 科目 m_売上総利益;
        private 科目 m_売上;
        private 科目 m_売上原価;
        private 科目 m_営業利益;
        private 科目 m_販売費及び一般管理費;
        private 科目 m_経常利益;
        private 科目 m_営業外収益;
        private 科目 m_営業外費用;
        private 科目 m_純利益;
        private 科目 m_特別利益;
        private 科目 m_特別損失;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="売上総利益"></param>
        /// <param name="売上"></param>
        /// <param name="売上原価"></param>
        /// <param name="営業利益"></param>
        /// <param name="販売費及び一般管理費"></param>
        /// <param name="経常利益"></param>
        /// <param name="営業外収益"></param>
        /// <param name="営業外費用"></param>
        /// <param name="純利益"></param>
        /// <param name="特別利益"></param>
        /// <param name="特別損失"></param>
        public 利益計算情報(科目 売上総利益, 科目 売上, 科目 売上原価, 
            科目 営業利益, 科目 販売費及び一般管理費, 
            科目 経常利益, 科目 営業外収益, 科目 営業外費用,
            科目 純利益, 科目 特別利益, 科目 特別損失)
        {
            m_売上総利益 = 売上総利益;
            m_売上= 売上;
            m_売上原価 = 売上原価;
            m_営業利益= 営業利益;
            m_販売費及び一般管理費 = 販売費及び一般管理費;
            m_経常利益 = 経常利益;
            m_営業外収益= 営業外収益;
            m_営業外費用= 営業外費用;
            m_純利益= 純利益;
            m_特別利益= 特別利益;
            m_特別損失= 特別損失;
        }

        /// <summary>
        /// 
        /// </summary>
        public 科目 売上総利益 => m_売上総利益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 売上 => m_売上;
        /// <summary>
        /// 
        /// </summary>
        public 科目 売上原価 => m_売上原価;
        /// <summary>
        /// 
        /// </summary>
        public 科目 営業利益 => m_営業利益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 販売費及び一般管理費 => m_販売費及び一般管理費;
        /// <summary>
        /// 
        /// </summary>
        public 科目 経常利益 => m_経常利益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 営業外収益 => m_営業外収益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 営業外費用 => m_営業外費用;
        /// <summary>
        /// 
        /// </summary>
        public 科目 純利益 => m_純利益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 特別利益 => m_特別利益;
        /// <summary>
        /// 
        /// </summary>
        public 科目 特別損失 => m_特別損失;
    }
}
