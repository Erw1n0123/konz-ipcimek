using Microsoft.VisualStudio.TestTools.UnitTesting;
using csudh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace csudh.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void functionTest()
        {
            Assert.AreEqual("edu", Program.function("dhvx20.csudh.edu", 1));
        }

        [TestMethod()]
        public void functionTest2()
        {
            Assert.AreEqual("edu", Program.function("dhvx20.csudh.edu", 2));
        }
    }
}