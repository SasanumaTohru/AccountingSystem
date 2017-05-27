using System;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 伝票情報
    {
        public enum 伝票区分リスト
        {
            通常伝票 = 1,
            訂正伝票 = 2
        }

        public enum 訂正リスト
        {
            なし = 1,
            あり = 2
        }

        private 訂正リスト m_訂正区分 = 訂正リスト.なし;
        private 伝票区分リスト m_伝票区分 = 伝票区分リスト.通常伝票;
        private string m_対応伝票番号 = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票区分"></param>
        public 伝票情報(伝票区分リスト 伝票区分 = 伝票区分リスト.通常伝票, string 対応伝票番号 = "")
        {
            if (伝票区分 == 伝票区分リスト.訂正伝票)
            {
                m_伝票区分 = 伝票区分リスト.訂正伝票;
                m_対応伝票番号 = 対応伝票番号;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票区分"></param>
        /// <param name="訂正有無"></param>
        /// <param name="対応伝票番号"></param>
        public 伝票情報(int 伝票区分, bool 訂正有無, string 対応伝票番号)
        {
            m_伝票区分 = (伝票区分リスト)伝票区分;
            switch (訂正有無)
            {
                case true:
                    m_訂正区分 = 訂正リスト.あり;
                    break;
                case false:
                    m_訂正区分 = 訂正リスト.なし;
                    break;
            }
            m_対応伝票番号 = 対応伝票番号;
        }

        /// <summary>
        /// 
        /// </summary>
        public 訂正リスト 訂正有無 => m_訂正区分;
        public bool 訂正伝票がある
        {
            get
            {
                bool レスポンス;
                switch (m_訂正区分)
                {
                    case 訂正リスト.あり:
                        レスポンス = true;
                        break;
                    default:
                        レスポンス = false;
                        break;
                }
                return レスポンス;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 伝票区分リスト 伝票区分 => m_伝票区分;

        /// <summary>
        /// 
        /// </summary>
        public bool 訂正伝票である
        {
            get
            {
                bool レスポンス;
                switch (m_伝票区分)
                {
                    case 伝票区分リスト.訂正伝票:
                        レスポンス = true;
                        break;
                    default:
                        レスポンス = false;
                        break;
                }
                return レスポンス;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 対応伝票番号 => m_対応伝票番号;

        /// <summary>
        /// 
        /// </summary>
        public void 訂正元伝票にする()
        {
            if (m_訂正区分 == 訂正リスト.あり || m_伝票区分 == 伝票区分リスト.訂正伝票)
            {
                throw new Exception("この伝票を訂正することはできません。");
            }
            m_訂正区分 = 訂正リスト.あり;
        }
    }
}
