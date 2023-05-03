using System.Xml;

namespace Atlantic
{
    public class Bateau
    {
        protected String id;
        protected String nom;
        protected Double longueur;
        protected Double largeur;
        //protected Int32 numeroInterne;

        public Bateau()
        {

        }

        public Bateau(string unId, string unNom, double uneLongueur, double unelargeur, int unNumeroInterne)
            {
            id = unId;
            nom = unNom;
            longueur = uneLongueur;
            largeur = unelargeur;
            }

        public String getId()
        {
            return id;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public String getNom()
        {
                return nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }
    }
}