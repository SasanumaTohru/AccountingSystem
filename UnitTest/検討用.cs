using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class 検討用
    {
        /// <summary>
        /// プログラム詳細設計用
        /// </summary>
        [TestMethod]
        public void foo()
        {
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            //
            int 最大集計区分 = 4;
            for (int 集計区分 = 最大集計区分; 集計区分 > -1; 集計区分--)
            {
                Debug.WriteLine(集計区分);
            }



            //
            Stopwatch.Stop();
            Debug.WriteLine(Stopwatch.Elapsed);
        }
    }
}