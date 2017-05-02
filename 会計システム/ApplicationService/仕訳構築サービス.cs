using 会計システム.Domain.BusinessObject.会計伝票;
using 会計システム.Domain.BusinessObject.勘定科目;
using 会計システム.Domain.PrimitiveObject;
using System.Collections.Generic;

namespace 会計システム.ApplicationService
{
    class 仕訳構築サービス
    {
        private List<仕訳> m_仕訳リスト = new List<仕訳>();
        private 勘定科目情報サービス 勘定科目情報 = new 勘定科目情報サービス();

        public void 追加する(int 勘定科目コード, decimal 金額, string 摘要, int 貸借区分番号)
        {
            コード _勘定科目コード = new コード(勘定科目コード);
            名称 _勘定科目名 = 勘定科目情報.勘定科目名を照会する(_勘定科目コード);
            科目 _勘定科目 = new 科目(_勘定科目コード, _勘定科目名);
            金額 _金額 = new 金額(金額);
            文字列 _摘要 = new 文字列(摘要);
            m_仕訳リスト.Add(new 仕訳(_勘定科目, _摘要, _金額, (仕訳.貸借区分)貸借区分番号));
        }

        public List<仕訳> リスト => m_仕訳リスト;

    }
}
