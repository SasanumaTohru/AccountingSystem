using AccountingSystem.Infrastructure;

namespace AccountingSystem.Domain.BusinessObject.勘定科目
{
    public class 科目
    {
        private コード m_コード;
        private PrimitiveObject.名称 m_名称;
        private 貸借区分リスト m_貸借区分;
        private コード m_集計科目コード;

        public enum 貸借区分リスト
        {
            借方 = 1,
            貸方 = 2
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        public 科目(コード コード, PrimitiveObject.名称 名称)
        {
            フィールド設定の共通処理(コード, 名称);
            m_集計科目コード = m_コード;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        /// <param name="集計科目コード"></param>
        public 科目(コード コード, PrimitiveObject.名称 名称, コード 集計科目コード)
        {
            フィールド設定の共通処理(コード, 名称);
            m_集計科目コード = 集計科目コード;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="コード"></param>
        /// <param name="名称"></param>
        private void フィールド設定の共通処理(コード コード, PrimitiveObject.名称 名称)
        {
            m_コード = コード;
            switch (コード.勘定区分)
            {
                case 1:
                    m_貸借区分 = 貸借区分リスト.借方;
                    break;
                case 2:
                    m_貸借区分 = 貸借区分リスト.貸方;
                    break;
                case 3:
                    m_貸借区分 = 貸借区分リスト.貸方;
                    break;
                case 4:
                    m_貸借区分 = 貸借区分リスト.借方;
                    break;
                case 5:
                    m_貸借区分 = 貸借区分リスト.貸方;
                    break;
            }
            m_名称 = 名称;
        }

        /// <summary>
        /// 
        /// </summary>
        public コード コード => m_コード;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.名称 名称 => m_名称;

        /// <summary>
        /// 
        /// </summary>
        public 貸借区分リスト 貸借区分 => m_貸借区分;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.必須文字列 コードと名称 => new PrimitiveObject.必須文字列($"{m_コード.値.ToString()} : {m_名称.値}");

        /// <summary>
        /// 
        /// </summary>
        public コード 集計科目コード => m_集計科目コード;

    }
}
