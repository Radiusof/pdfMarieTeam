using System.Xml;

namespace Atlantic
{
    public class Bateau
    {
        private string id;
        private string nom;
        private double longueur;
        private double largeur;
        //private Int32 numeroInterne;

        public Bateau()
        {

        }

        public Bateau(string id, string nom, double longueur, double largeur)
            {
            this.id = id;
            this.nom = nom;
            this.longueur = longueur;
            this.largeur = largeur;
            }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getNom()
        {
                return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public double getLongueur() 
        { return longueur;
        }
        public void setLongueur(double longueur) 
        { 
            this.longueur = longueur;
        }
        public double getLargeur()
        {
            return largeur; 
        }
        public void setLargeur(double largeur)
        {
            this.largeur = largeur; 
        }

        public override string ToString()
        {
            return "ID: " + this.id + 
                "\n Nom: " + this.nom +
                "\n Longueur: " + this.longueur+
                "\n Largeur: " + this.largeur;
        }

    }
}