﻿using AccountingSystem.Domain.BusinessObject.会計伝票;

namespace AccountingSystem.ApplicationService
{
    public class 会計伝票記帳サービス
    {

        public 伝票 伝票を記帳する(伝票 伝票)
        {
            var 伝票ファイリングサービス = new Infrastructure.会計伝票ファイリングサービス();
            if (伝票.貸借金額不一致)
            {
                throw new System.Exception("貸借の金額が一致していません。");
            }
            return 伝票ファイリングサービス.伝票を保存する(伝票);
        }
          
    }
}
