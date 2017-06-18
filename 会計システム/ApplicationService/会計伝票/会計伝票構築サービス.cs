using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.PrimitiveObject;
using System;
using System.Collections.Generic;

namespace AccountingSystem.ApplicationService.会計伝票
{
    class 会計伝票構築サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票番号"></param>
        /// <returns></returns>
        public 伝票 伝票を構築する(string 伝票番号)
        {
            var 会計伝票RI = new Infrastructure.RepositoryImplementation会計伝票();
            Infrastructure.T_会計伝票 検索結果 = 会計伝票RI.伝票番号で検索する(伝票番号);
            var 検索した伝票番号 = new 伝票番号(検索結果.伝票番号);
            var 検索した伝票の日付 = new 日付(検索結果.計上日);
            var 構築した伝票 = new 伝票(検索した伝票番号, 検索した伝票の日付, 検索結果.伝票区分, 検索結果.訂正有無, 検索結果.対応伝票番号);

            var 仕訳RI = new Infrastructure.RepositoryImplementation仕訳();
            List<Infrastructure.T_仕訳> 検索した仕訳 = 仕訳RI.検索する(構築した伝票.番号.値);
            var 仕訳ビルダー = new 仕訳構築サービス();
            foreach (var p in 検索した仕訳)
            {
                仕訳ビルダー.追加する(p.勘定科目コード, p.金額, p.摘要, p.貸借);
            }
            構築した伝票.追加する(仕訳ビルダー.リスト);
            return 構築した伝票;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="計上日"></param>
        /// <param name="伝票仕訳"></param>
        /// <returns></returns>
        internal 伝票 伝票を構築する(DateTime 計上日, 仕訳構築サービス 伝票仕訳)
        {
            var _計上日 = new 日付(計上日);
            var 伝票番号 = new 伝票番号(new 自然数(0), _計上日);
            var 伝票 = new 伝票(伝票番号, _計上日);
            伝票.追加する(伝票仕訳.リスト);
            return 伝票;
        }
    }
}
