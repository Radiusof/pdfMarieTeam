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

        public int donnerVitesseNoeud()
        {
            return this.vitesse;
        }

        public string getImage() 
        {
            return this.image;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
