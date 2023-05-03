using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic
{
    public class Equipement : BateauVoyageur
    {
        public string id;
        public string libelle;


        public Equipement (string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        //Getter
        public string getIdEquip() { return id; }
        public string getLibelle() { return libelle; }

        //Setter
        public void setIdEquip(string id) { this.id = id;}
        public void setLibelle(string libelle) { this.libelle = libelle;}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
