using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic
{
    public class passerelle
    {
        List<Bateau> bateauList = new List<Bateau>();
        List<Equipement> equipementList = new List<Equipement>();
        
        public passerelle()
        {

        }

        public passerelle(List<Bateau> bateauList, List<Equipement> equipementList)
        {
            this.bateauList = bateauList;
            this.equipementList = equipementList;
        }

        //Getter
        public List<Bateau> getBateauList()
        {
            return bateauList;
        }
        public List<Equipement> getEquipementList()
        {
            return equipementList;
        }

        public List<BateauVoyageur> getListBateauVoyageur()
        {
            List<BateauVoyageur> tempList = new List<BateauVoyageur>();
            foreach(Bateau boat in bateauList)
            {
                if (boat is BateauVoyageur)
                {
                    tempList.Add((BateauVoyageur)boat);
                }
            }
            return tempList;

        }

        public List<BateauFret> getListBateauFret()
        {
            List<BateauFret> tempList = new List<BateauFret>();
            foreach (Bateau boat in bateauList)
            {
                if (boat is BateauFret)
                {
                    tempList.Add((BateauFret)boat);
                }
            }
            return tempList;
        }
        
        //Setter
        public void setBateauList(List<Bateau> bateauList)
        {
            this.bateauList= bateauList;
        }
        public void setEquipementList(List<Equipement> equipementList)
        {
            this.equipementList= equipementList;
        }

        public void initPasserelle ()
        {
            //Bateau List
            Bateau boat1 = new BateauVoyageur("12", "BoatyBoat", 12.05, 54.2,"Boaty",30);
            Bateau boat2 = new BateauFret("15", "McBoat", 43.02, 14.2,88);
            Bateau boat3 = new BateauVoyageur("19", "BigBoat", 65.99, 42.23,"Big",08);
            Bateau boat4 = new BateauVoyageur("11", "SmolBoat", 9.99, 8.23,"Smol",19);
            Bateau boat5 = new BateauFret("13", "SmokeBoat", 54.99, 23.23,99);
            Bateau boat6 = new BateauFret("14", "WoodBoat", 23.04, 214.2,120);
            Bateau boat7 = new BateauVoyageur("15", "MetalBoat", 63.02, 19.2,"Metal",08);
            Bateau boat8 = new BateauFret("19", "BlackPearlBoat", 95.99, 33.23,200);
            Bateau boat9 = new BateauFret("11", "IronBoat", 34.99, 21.43,250);
            Bateau boat10 = new BateauVoyageur("13", "TheBoat", 59.99, 33.33,"Boat",43);

            bateauList.Add(boat1);
            bateauList.Add(boat2);
            bateauList.Add(boat3);
            bateauList.Add(boat4);
            bateauList.Add(boat5);
            bateauList.Add(boat6);
            bateauList.Add(boat7);
            bateauList.Add(boat8);
            bateauList.Add(boat9);
            bateauList.Add(boat10);
            //Equipement List

            Equipement equip1 = new Equipement("20", "Proue");
            Equipement equip2 = new Equipement("22", "Barque");
            Equipement equip3 = new Equipement("25", "Rames");
            Equipement equip4 = new Equipement("21", "Bouée");
            Equipement equip5 = new Equipement("26", "Vivres");
            Equipement equip6 = new Equipement("27", "Bar");
            Equipement equip7 = new Equipement("23", "Ponton");
            Equipement equip8 = new Equipement("24", "Extincteurs");
            Equipement equip9 = new Equipement("28", "Restaurant");
            Equipement equip10 = new Equipement("29", "Arcades");

            equipementList.Add(equip1);
            equipementList.Add(equip2);
            equipementList.Add(equip3);
            equipementList.Add(equip4);
            equipementList.Add(equip5);
            equipementList.Add(equip6);
            equipementList.Add(equip7);
            equipementList.Add(equip8);
            equipementList.Add(equip9);
            equipementList.Add(equip10);
        }

    }
}
