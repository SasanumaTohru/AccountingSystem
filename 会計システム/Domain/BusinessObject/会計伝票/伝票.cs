using System;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 伝票
    {
        private 番号 m_番号;
        private PrimitiveObject.日付 m_計上日;
        private 仕訳列 m_借方仕訳 = new 仕訳列();
        private 仕訳列 m_貸方仕訳 = new 仕訳列();

        public 訂正情報 m_訂正情報 = new 訂正情報();
        //private bool m_訂正伝票の有無 = false;
        //private bool m_訂正伝票 = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <param name="計上日"></param>
        public 伝票(番号 伝票番号,PrimitiveObject.日付 計上日, bool 訂正伝票 = false)
        {
            m_番号 = 伝票番号;
            m_計上日 = 計上日;
            m_訂正情報.訂正伝票である = 訂正伝票;
        }

        /// <summary>
        /// 
        /// </summary>
        public 番号 番号 => m_番号;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.日付 計上日 => m_計上日;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳"></param>
        public void 追加する(仕訳 仕訳)
        {
            switch (仕訳.貸借)
            {
                case 仕訳.貸借区分.借方:
                    m_借方仕訳.追加する(仕訳);
                    break;
                case 仕訳.貸借区分.貸方:
                    m_貸方仕訳.追加する(仕訳);
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 仕訳列 借方 => m_借方仕訳;

        /// <summary>
        /// 
        /// </summary>
        public 仕訳列 貸方 => m_貸方仕訳;

        /// <summary>
        /// 
        /// </summary>
        public PrimitiveObject.金額 貸借金額差額
        {
            get
            {
                var 差額 = new PrimitiveObject.金額(m_借方仕訳.合計金額.値 - m_貸方仕訳.合計金額.値).絶対値;
                return new PrimitiveObject.金額(差額);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool 貸借金額不一致
        {
            get
            {
                bool 判定 = false;
                if(m_借方仕訳.合計金額.値 != m_貸方仕訳.合計金額.値)
                {
                    判定 = true;
                }
                return 判定;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 帰属会計年度
        {
            get
            {
                var 帰属年度 = new 会計年度(4);
                return 帰属年度.指定した日付の会計年度(m_計上日);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 訂正情報 訂正情報 => m_訂正情報;
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public 伝票 訂正伝票を用意する()
        {
            var 訂正伝票の計上日 = new PrimitiveObject.日付(DateTime.Today);
            var 訂正伝票の仮伝票番号 = new 番号(new PrimitiveObject.自然数(0), 訂正伝票の計上日);
            var 訂正伝票 = new 伝票(訂正伝票の仮伝票番号, 訂正伝票の計上日, true);
            var 訂正伝票の仕訳列 = new 仕訳列();
            m_借方仕訳.リスト.ForEach(item => 訂正伝票の仕訳列.追加する(item));
            m_貸方仕訳.リスト.ForEach(item => 訂正伝票の仕訳列.追加する(item));
            訂正伝票の仕訳列.リスト.ForEach(item => item.貸借を反転する());
            訂正伝票の仕訳列.リスト.ForEach(item => 訂正伝票.追加する(item));
            m_訂正情報.訂正の有無 = true;
            return 訂正伝票;
        }
    }
}
