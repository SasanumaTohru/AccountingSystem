using AccountingSystem.Domain.BusinessObject.会計伝票;

namespace AccountingSystem.ApplicationService.会計伝票
{
    public class 会計伝票記帳サービス
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票"></param>
        /// <returns></returns>
        public 伝票 伝票を記帳する(伝票 伝票)
        {
            var 伝票ファイリングサービス = new Infrastructure.RepositoryImplementation会計伝票();
            if (伝票.貸借金額不一致)
            {
                throw new System.Exception("貸借の金額が一致していません。");
            }
            return 伝票ファイリングサービス.伝票を保存する(伝票);
        }
          
    }
}
