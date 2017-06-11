using AccountingSystem.Domain.PrimitiveObject;
using System;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 訂正伝票作成サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="訂正元伝票"></param>
        /// <returns></returns>
        public 伝票 訂正伝票を作成する(伝票 訂正元伝票)
        {
            訂正元伝票.伝票情報.訂正元伝票にする();

            var 訂正伝票の計上日 = new 日付(DateTime.Today);
            var 訂正伝票の仮伝票番号 = new 伝票番号(new 自然数(0), 訂正伝票の計上日);
            var 訂正伝票 = new 伝票(訂正伝票の仮伝票番号, 訂正伝票の計上日, 伝票情報.伝票区分リスト.訂正伝票, 訂正元伝票.番号.値);
            var 訂正伝票の仕訳列 = new 仕訳列();
            訂正伝票の仕訳列.追加する(訂正元伝票.借方);
            訂正伝票の仕訳列.追加する(訂正元伝票.貸方);
            訂正伝票の仕訳列.すべての仕訳の貸借を反転する();
            訂正伝票.追加する(訂正伝票の仕訳列.リスト);
            return 訂正伝票;
        }
    }
}
