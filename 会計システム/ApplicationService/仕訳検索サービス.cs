using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.ApplicationService
{
    public class 仕訳検索サービス
    {
        public List<Domain.BusinessObject.会計伝票.仕訳> 伝票番号と勘定科目が一致する仕訳を検索する(Domain.BusinessObject.会計伝票.伝票 伝票, Domain.BusinessObject.勘定科目.科目 勘定科目)
        {
            var 仕訳RI = new Infrastructure.RepositoryImplementation仕訳();
            List<Infrastructure.T_仕訳> 検索した仕訳 = 仕訳RI.伝票番号と勘定科目が一致する仕訳を検索する(伝票, 勘定科目);
            var 仕訳ビルダー = new AccountingSystem.ApplicationService.仕訳構築サービス();
            foreach (var p in 検索した仕訳)
            {
                仕訳ビルダー.追加する(p.勘定科目コード, p.金額, p.摘要, p.貸借);
            }
            return 仕訳ビルダー.リスト;
        }
    }
}
