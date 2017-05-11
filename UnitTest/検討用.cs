using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;


namespace UnitTest
{
    [TestClass]
    public class 検討用
    {
        [TestMethod]
        public void foo()
        {

            using (var MyDB = new UnitTest.AccountingDBEntities())
            {
                var rs = MyDB.M_勘定科目.Where(x =>  x.勘定区分 == 1);
                rs.ToList().ForEach(p => Debug.WriteLine(p.勘定科目名));
            }

        }



    }
}
