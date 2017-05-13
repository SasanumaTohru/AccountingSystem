using System;
using System.Collections.Generic;
using 会計システム.Domain.BusinessObject.会計伝票;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム.ApplicationService
{
    class 会計伝票記帳サービス
    {
        private 伝票 m_伝票;
        private Infrastructure.会計伝票ファイリングサービス 会計伝票ファイリングサービス = new Infrastructure.会計伝票ファイリングサービス();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <param name="仕訳リスト"></param>
        public 会計伝票記帳サービス(DateTime 計上日, List<仕訳> 仕訳リスト)
        {
            伝票を用意する(計上日);
            用意した伝票に仕訳を追加する(仕訳リスト);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        private void 伝票を用意する(DateTime 計上日)
        {
            var _計上日 = new 日付(計上日);
            m_伝票 = 会計伝票ファイリングサービス.伝票番号が採番された伝票を取得する(_計上日);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳リスト"></param>
        private void 用意した伝票に仕訳を追加する(List<仕訳> 仕訳リスト)
        {
            foreach (var item in 仕訳リスト)
            {
                m_伝票.追加する(item);
            }
            if (m_伝票.貸借金額不一致)
            {
                throw new Exception("貸借の金額が不一致しているため、仕訳の保存を中止します。");
            }
            会計伝票ファイリングサービス.伝票を保存する(仕訳リスト);
        }

        /// <summary>
        /// 
        /// </summary>
        public 伝票 内容 => m_伝票;
        
    }
}
