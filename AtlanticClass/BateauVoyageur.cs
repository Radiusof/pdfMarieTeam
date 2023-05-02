using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic
{
    public class BateauVoyageur : Bateau
    {
        private string image;
        private int vitesse;

        public BateauVoyageur()
        {

        }
        public BateauVoyageur(string id, string nom, double longueur, double largeur,string image, int vitesse) 
            :base(id,nom,longueur,largeur)
        {
            this.image = image;
            this.vitesse = vitesse; 
        }

        //Getter

        public string getImage() { return image; }
        public int getVitesse() { return vitesse; }

        //Setter
        public void setImage(string image) { this.image = image;}
        public void setVitesse(int vitesse) { this.vitesse = vitesse;}

        public double donnerVitesseNoeud(int vitesse)
        {
            double result = vitesse * 1.852;
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + "Image: " + this.image + "Vitesse: "+ this.vitesse ;
        }

    }
}
