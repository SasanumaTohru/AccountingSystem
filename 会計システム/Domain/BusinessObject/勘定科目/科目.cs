﻿namespace AccountingSystem.Domain.BusinessObject.勘定科目
{
    public class 科目
    {
        private コード m_コード;
        private PrimitiveObject.名称 m_名称;
        private 貸借.区分 m_貸借区分;
        private コード m_集計科目コード;
        private int m_集計区分;
        private string m_勘定区分;

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
       /// <param name="集計区分"></param>
        public 科目(コード コード, PrimitiveObject.名称 名称, コード 集計科目コード, int 集計区分 = 0)
        {
            フィールド設定の共通処理(コード, 名称);
            m_集計区分 = 集計区分;
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
                    m_貸借区分 = 貸借.区分.借方;
                    m_勘定区分 = "資産";
                    break;
                case 2:
                    m_貸借区分 = 貸借.区分.貸方;
                    m_勘定区分 = "負債";
                    break;
                case 3:
                    m_貸借区分 = 貸借.区分.貸方;
                    m_勘定区分 = "資本";
                    break;
                case 4:
                    m_貸借区分 = 貸借.区分.借方;
                    m_勘定区分 = "費用";
                    break;
                case 5:
                    m_貸借区分 = 貸借.区分.貸方;
                    m_勘定区分 = "収益";
                    break;
                case 6:
                    m_貸借区分 = 貸借.区分.貸方;
                    m_勘定区分 = "利益";
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
        public 貸借.区分 貸借区分 => m_貸借区分;

        /// <summary>
        /// 
        /// </summary>
        public string 勘定区分 => m_勘定区分; 

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.必須文字列 コードと名称 => new PrimitiveObject.必須文字列($"{m_コード.値.ToString()} : {m_名称.値}");

        /// <summary>
        /// 
        /// </summary>
        public int 集計区分 => m_集計区分;

        /// <summary>
        /// 
        /// </summary>
        public コード 集計科目コード => m_集計科目コード;

    }
}
