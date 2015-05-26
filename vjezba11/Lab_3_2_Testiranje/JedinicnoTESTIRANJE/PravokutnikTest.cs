using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_2_Testiranje;

namespace JedinicnoTESTIRANJE
{
    [TestClass]
    public class PravokutnikTest
    {
        [TestMethod]
        public void IzracunajDijagonaluTest()
        {
            Pravokutnik p1 = new Pravokutnik(0f, 0f);
            float d1 = p1.IzracunajDijagonalu();
            Assert.AreEqual(0, d1, "Izračunaj dijagonale nije točan");

            Pravokutnik p2 = new Pravokutnik(-5, 1);
            float d2 = p2.IzracunajDijagonalu();
            Assert.IsTrue(d2 >= 0, "Dijagnoala mora biti veća od nule");
            Pravokutnik p3 = new Pravokutnik(4, 3);
            float d3 = p3.IzracunajDijagonalu();
            Assert.AreEqual(5, d3, "Izračun dijagonale nije točan");
            //u Assertu parametar poruka - u slučaju da ne odgovarao očekivana(u 1. i drugom parametru) i stvarna vrijednost izračuna

        }
                [TestMethod]
        public void IzracunajPovrsinuTest()
        {
            Pravokutnik p1 = new Pravokutnik(0, 0);
            float povrsina1 = p1.IzracunajPovrsinu();
            Assert.AreEqual(0, povrsina1, "Izračun površine nije točan!");
            Pravokutnik p2 = new Pravokutnik(-1, 5);
            float povrsina2 = p2.IzracunajPovrsinu();
            Assert.IsTrue(povrsina2 >= 0, "Površina mora biti veća od nule!");
            Pravokutnik p3 = new Pravokutnik(5, 6.5f);
            float povrsina3 = p3.IzracunajPovrsinu();
            Assert.AreEqual(32.5f, povrsina3, "Izračun površine nije točan!");
        }
        /// <summary>
        /// Testna metoda za testiranje izračuna opsega pravokutnika.
        /// </summary>
        [TestMethod]
        public void IzracunajOpsegTest() 
        {
            Pravokutnik p1 = new Pravokutnik(0, 0);
            float opseg1 = p1.IzracunajOpseg();
            Assert.AreEqual(0, opseg1, "Izračun opsega nije točan!");
            Pravokutnik p2 = new Pravokutnik(-1, 5);
            float opseg2 = p2.IzracunajOpseg();
            Assert.IsTrue(opseg2 >= 0, "Opseg mora biti veći od nule!");
            Pravokutnik p3 = new Pravokutnik(5, 6.5f);
            float opseg3 = p3.IzracunajOpseg();
            Assert.AreEqual(23, opseg3, "Izračun opsega nije točan!");
        }
        
    }
}
