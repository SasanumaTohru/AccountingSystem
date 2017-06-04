namespace AccountingSystem.Domain.BusinessObject.勘定科目
{
    public class コード
    {

        private int m_値;

        /// <summary>
        ///
        /// </summary>
        /// <param name="値"></param>
        public コード(int 値)
        {
            コードは適正な範囲である(値);
            m_値 = 値;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        private static void コードは適正な範囲である(int 値)
        {
            const int 下限 = 100000;
            const int 上限 = 599999;
            if (値 < 下限 | 値 > 上限)
            {
                throw new System.Exception("勘定科目コードの値が設定できる範囲を超えています。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int 値 => m_値;

        /// <summary>
        /// 
        /// </summary>
        public int 勘定区分 => m_値 / 100000;
    }
}
