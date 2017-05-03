using System;
using System.Collections.Generic;
using 会計システム.Domain.BusinessObject.会計伝票;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム.ApplicationService
{
    class 会計伝票記帳サービス
    {
        private 伝票 m_伝票;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <param name="仕訳リスト"></param>
        public 会計伝票記帳サービス(DateTime 計上日, List<仕訳> 仕訳リスト)
        {
            伝票を記帳する(計上日);
            記帳済み伝票に仕訳を追加する(仕訳リスト);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        private void 伝票を記帳する(DateTime 計上日)
        {
            日付 _計上日 = new 日付(計上日);
            Infrastructure.会計伝票ファイリングサービス 会計伝票ファイリングサービス = new Infrastructure.会計伝票ファイリングサービス();
            m_伝票 = 会計伝票ファイリングサービス.記帳した伝票を取得する(_計上日);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳リスト"></param>
        private void 記帳済み伝票に仕訳を追加する(List<仕訳> 仕訳リスト)
        {
            foreach (仕訳 p in 仕訳リスト)
            {
                m_伝票.追加する(p);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public 伝票 内容 => m_伝票;
        
    }
}
