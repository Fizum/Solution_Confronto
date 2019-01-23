using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Confronto_Library;

namespace Confronto_Library_Tests
{
    [TestClass]
    public class Confronto_Tests
    {
        [TestMethod]
        public void TestMax()
        {
            int n1 = 0;
            int n2 = 7;
            int max_aspetto = 7;

            int max_calcolato = Confronto_Library.Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspetto, max_calcolato);
        }

        public void TestMax2()
        {
            int n1 = -5;
            int n2 = 10;
            int max_aspetto = 10;

            int max_calcolato = Confronto_Library.Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspetto, max_calcolato);
        }
    }
}
