using System;
using System.Collections.Generic;
using 会計システム.Domain.BusinessObject.会計伝票;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム.ApplicationService
{
    class 会計伝票作成サービス
    {
        private 伝票 m_伝票;

        public 会計伝票作成サービス(DateTime 計上日, List<仕訳> 仕訳リスト)
        {
            伝票を作成する(計上日);
            伝票に仕訳を追加する(仕訳リスト);
        }
        
        private void 伝票を作成する(DateTime 計上日)
        {
            日付 _計上日 = new 日付(計上日);
            自然数 _採番ロジック = new 自然数(1);   //仮実装：要、採番ロジック
            番号 _伝票番号 = new 番号(_採番ロジック, _計上日);
            m_伝票 = new 伝票(_伝票番号, _計上日);
        }

        private void 伝票に仕訳を追加する(List<仕訳> 仕訳リスト)
        {
            foreach (仕訳 p in 仕訳リスト)
            {
                m_伝票.追加する(p);
            }
        }

        public 伝票 内容 => m_伝票;
        
    }
}
