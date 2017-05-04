using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 会計システム.ApplicationService
{
    public static class 入力検査
    {
        public static bool 金額に変換できない(string 値)
        {
            bool 戻り値 = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(値, @"[-]?^[0-9]+$"))
            {
                戻り値 =  false;
            }
            return 戻り値;
        }
    }
}
