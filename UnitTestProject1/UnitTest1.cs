using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var michaelMassTerm = new DateRange(new DateTime(2016, 9, 8), 1);
            DateTime a = new DateTime(2016, 6, 7);
            Assert.IsFalse(michaelMassTerm.Contains(a));
        }
    }
}
