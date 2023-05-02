using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Atlantic;
using System.Collections.Generic;

namespace testAtlantic2
{
    [TestClass]
    public class initListPasserelle
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Bateau List
            Bateau test1 = new Bateau("12","BoatyBoat",12.05,54.2);
            Bateau test2 = new Bateau("15", "McBoat", 43.02, 14.2);
            Bateau test3 = new Bateau("19", "BigBoat", 65.99, 42.23);
            List<Bateau> listBoat = new List<Bateau>()
            {
                test1,
                test2,
                test3,
            };
            //Equipement List
            Equipement testEquip1 = new Equipement("20", "Equipement1");
            Equipement testEquip2 = new Equipement("22", "Equipement2");
            Equipement testEquip3 = new Equipement("25", "Equipement5");
            List<Equipement> listEquip = new List<Equipement>()
            {
                testEquip1,
                testEquip2,
                testEquip3,
            };

            //Test Bateau
            passerelle testPasserelle = new passerelle(listBoat, listEquip);
            int countBoat = 3;
            List<Bateau> resultBoat = testPasserelle.getBateauList();

            Assert.AreEqual(countBoat, resultBoat.Count, "Liste de bateau incomplète!");

            //Test Equipement
            int countEquip = 3;
            List<Equipement> resultEquip = testPasserelle.getEquipementList();

            Assert.AreEqual(countEquip, resultEquip.Count, "Liste Equipement incomplète");
        }
    }
}
