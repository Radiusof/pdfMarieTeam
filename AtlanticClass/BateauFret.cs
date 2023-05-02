using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic
{
    public class BateauFret : Bateau
    {
        public int poidsMax;

        public BateauFret(string id, string nom, double longueur, double largeur, int poidsMax)
            : base(id, nom, longueur, largeur) 
        {
            this.poidsMax = poidsMax;   
        }

        public int getPoidsMax() 
        { 
            return poidsMax; 
        }
        public void setPoidsMax(int poidsMax) 
        { 
            this.poidsMax = poidsMax;
        }

        public override string ToString()
        {
            return base.ToString() + "Poids Maximum: " + this.poidsMax;
        }

    }
}
