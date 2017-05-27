using System;
using AccountingSystem.Domain.PrimitiveObject;
using System.Linq;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 伝票
    {
        private 伝票番号 m_伝票番号;
        private 日付 m_計上日;
        private 仕訳列 m_借方仕訳 = new 仕訳列();
        private 仕訳列 m_貸方仕訳 = new 仕訳列();
        public 伝票情報 m_伝票情報;

        /// <summary>
        /// 通常伝票用コンストラクタ
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <param name="計上日"></param>
        public 伝票(伝票番号 伝票番号, 日付 計上日)
        {
            m_伝票番号 = 伝票番号;
            m_計上日 = 計上日;
            m_伝票情報 = new 伝票情報(伝票情報.伝票区分リスト.通常伝票);
        }

        /// <summary>
        /// 訂正伝票用コンストラクタ
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <param name="計上日"></param>
        /// <param name="訂正伝票"></param>
        /// <param name="対応伝票番号"></param>
        public 伝票(伝票番号 伝票番号, 日付 計上日, 伝票情報.伝票区分リスト 訂正伝票, string 対応伝票番号)
        {
            m_伝票番号 = 伝票番号;
            m_計上日 = 計上日;
            m_伝票情報 = new 伝票情報(伝票情報.伝票区分リスト.訂正伝票, 対応伝票番号);
        }

        public 伝票(伝票番号 伝票番号, 日付 計上日, int 伝票区分, bool 訂正有無, string 対応伝票番号)
        {
            m_伝票番号 = 伝票番号;
            m_計上日 = 計上日;
            m_伝票情報 = new 伝票情報(伝票区分, 訂正有無, 対応伝票番号);
        }

        /// <summary>
        /// 
        /// </summary>
        public 伝票番号 番号 => m_伝票番号;

        /// <summary>
        /// 
        /// </summary>
        public 日付 計上日 => m_計上日;

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

        internal 伝票 伝票番号を変更したコピーを作成する(伝票番号 新しい伝票番号)
        {
            m_伝票番号 = 新しい伝票番号;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        public 仕訳列 借方 => m_借方仕訳;

        /// <summary>
        /// 
        /// </summary>
        public 仕訳列 貸方 => m_貸方仕訳;

        public 仕訳列 すべての仕訳
        {
            get
            {
                var すべての仕訳 = new 仕訳列();
                m_借方仕訳.リスト.ForEach(o => すべての仕訳.リスト.Add(o));
                m_貸方仕訳.リスト.ForEach(p => すべての仕訳.リスト.Add(p));
                return すべての仕訳;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 金額 貸借金額差額
        {
            get
            {
                var 差額 = new 金額(m_借方仕訳.合計金額.値 - m_貸方仕訳.合計金額.値).絶対値;
                return new 金額(差額);
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
                if (m_借方仕訳.合計金額.値 != m_貸方仕訳.合計金額.値)
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
        public 伝票情報 伝票情報 => m_伝票情報;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public 伝票 訂正伝票を用意する()
        {
            m_伝票情報.訂正元伝票にする();

            var 訂正伝票の計上日 = new 日付(DateTime.Today);
            var 訂正伝票の仮伝票番号 = new 伝票番号(new 自然数(0), 訂正伝票の計上日);
            var 訂正伝票 = new 伝票(訂正伝票の仮伝票番号, 訂正伝票の計上日, 伝票情報.伝票区分リスト.訂正伝票, m_伝票番号.値);
            var 訂正伝票の仕訳列 = new 仕訳列();
            m_借方仕訳.リスト.ForEach(item => 訂正伝票の仕訳列.追加する(item));
            m_貸方仕訳.リスト.ForEach(item => 訂正伝票の仕訳列.追加する(item));
            訂正伝票の仕訳列.リスト.ForEach(item => item.貸借を反転する());
            訂正伝票の仕訳列.リスト.ForEach(item => 訂正伝票.追加する(item));
            return 訂正伝票;
        }
    }
}
