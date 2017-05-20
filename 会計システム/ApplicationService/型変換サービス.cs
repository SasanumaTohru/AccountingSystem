using System;

namespace AccountingSystem.ApplicationService
{
    /// <summary>
    /// UIからの入力された値を型変換もしくは検査します。
    /// </summary>
    public static class 型変換サービス
    {

        private static (bool 変換できる, decimal 金額) 金額変換文字列;
        
       /// <summary>
       /// 変換に失敗した場合、金額はゼロを返します。
       /// </summary>
       /// <param name="値"></param>
       /// <returns></returns>
        public static (bool 変換できる, decimal 金額) 文字列を金額に変換する(string 値)
        {
            金額変換文字列.変換できる =  decimal.TryParse(値, out decimal 変換された値);
            金額変換文字列.金額 = 変換された値;
            return 金額変換文字列;
        }
               
        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        /// <returns></returns>
        public static int コードと名称から勘定科目コードを抽出する(string 値)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(値, @"\d{6}") == false)
            {
                throw new Exception("勘定科目を選択してください。");
            }
            return int.Parse(値.Substring(0, 6));
        }

    }
}
