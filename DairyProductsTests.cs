using Microsoft.VisualStudio.TestTools.UnitTesting;
using Management_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project.Tests
{
    [TestClass()]
    public class DairyProductsTests
    {
        private int actual;
        [TestMethod()]
        public void DairyProductsTest()
        {
            var expected = 4;
            var stock = new DairyProducts();

            var actual = stock.dairystock(10,6);

            Assert.AreEqual(expected, actual);
        }
    }
}