using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testesDeUnidade
{
    [TestClass]
    [Ignore("Não pode ser testado")]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
        }
    }
}
