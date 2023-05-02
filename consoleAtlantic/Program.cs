// See https://aka.ms/new-console-template for more information
using Atlantic;

Bateau test1 = new Bateau("12", "BoatyBoat", 12.05, 54.2);
Bateau test2 = new Bateau("15", "McBoat", 43.02, 14.2);
Bateau test3 = new Bateau("19", "BigBoat", 65.99, 42.23);
List<Bateau> listBoat = new List<Bateau>()
            {
                test1,
                test2,
                test3,
            };

foreach (Bateau boat in listBoat)
{
    Console.WriteLine(boat.ToString());
}
