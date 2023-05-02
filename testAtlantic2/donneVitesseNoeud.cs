using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Atlantic;

namespace testAtlantic2
{
    [TestClass]
    public class donneVitesseNoeud
    {
        [TestMethod]
        public void TestMethod1()
        {
            string id = "4";
            string nom = "boatyBoat";
            double longueur = 12.5;
            double largeur = 6.5;
            int testVitesse = 14;
            string uneImage = "Imageimage";
            //"UnId", "BoatMcBottyBoat", 12.02, 5.52
            //string id, string nom, double longueur, double largeur,string image, int vitesse
            BateauVoyageur test = new BateauVoyageur(id,nom,longueur,largeur,uneImage,testVitesse) ;

            //test
            double result = test.donnerVitesseNoeud(testVitesse);
            double attendu = 25.928;
            //Assert
            Assert.AreEqual(result, attendu, "La vitesse ne correspond pas");

        }
    }
}
