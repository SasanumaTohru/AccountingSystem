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




            //
            Stopwatch.Stop();
            Debug.WriteLine(Stopwatch.Elapsed);
        }
    }
}