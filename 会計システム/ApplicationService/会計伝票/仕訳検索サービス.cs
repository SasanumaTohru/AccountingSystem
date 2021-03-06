﻿using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.BusinessObject.勘定科目;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AccountingSystem.ApplicationService.会計伝票
{
    public class 仕訳検索サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票"></param>
        /// <param name="勘定科目"></param>
        /// <returns></returns>
        public ReadOnlyCollection<仕訳> 伝票番号と勘定科目が一致する仕訳を検索する(伝票 伝票, 科目 勘定科目)
        {
            var 仕訳RI = new Infrastructure.RepositoryImplementation仕訳();
            List<Infrastructure.T_仕訳> 検索した仕訳 = 仕訳RI.伝票番号と勘定科目が一致する仕訳を検索する(伝票, 勘定科目);
            var 仕訳ビルダー = new 仕訳構築サービス();
            foreach (var p in 検索した仕訳)
            {
                仕訳ビルダー.追加する(p.勘定科目コード, p.金額, p.摘要, p.貸借);
            }
            return 仕訳ビルダー.リスト;
        }
    }
}
