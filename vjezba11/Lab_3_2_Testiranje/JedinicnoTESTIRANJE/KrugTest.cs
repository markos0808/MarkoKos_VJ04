using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_2_Testiranje;

namespace JedinicnoTESTIRANJE
{
    [TestClass]
    public class KrugTest
    {
        [TestMethod]
        public void krugPovrsinaTest()
        {
            Krug krug = new Krug(0f);
            float p1 = krug.Povrsina();
            Assert.AreEqual(0, p1, "Površina nije 0, a radius je stavljen na 0!");

            Krug krug2 = new Krug(-4f);
            float p2 = krug2.Povrsina();
            Assert.IsTrue(p2>=0, "Površina mora biti >=0!");


        }
        [TestMethod]
        public void krugOpsegTest()
        {
            Krug krug = new Krug(0f);
            float p1 = krug.Opseg();
            Assert.AreEqual(0, p1, "Opseg nije 0, a radius je stavljen na 0!");

            Krug krug2 = new Krug(-4f);
            float p2 = krug2.Opseg();
            Assert.IsTrue(p2 >= 0, "Opseg mora biti >0!"); //stavi na Abs radius kod Opseg()


        }
    }
}
