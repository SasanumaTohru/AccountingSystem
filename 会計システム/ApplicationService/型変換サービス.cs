using System;

namespace 会計システム.ApplicationService
{
    /// <summary>
    /// UIからの入力された値を型変換もしくは検査します。
    /// </summary>
    public static class 型変換サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        /// <returns></returns>
        public static decimal 文字列を金額に変換する(string 値)
        {
            if (金額に変換できる(値) == false)
            {
                throw new Exception("金額を正しく入力してください。");
            }
            return decimal.Parse(値);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="値"></param>
        /// <returns></returns>
        public static bool 金額に変換できる(string 値)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(値, @"^[-]?[0-9]+$");
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
