using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 400,
                Depth = 400.5,
                Stories = 7,
                Designer = "Pat Shaver",

            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Marylin McKeown");

            // FiveOneTwoEigth.printValues();

            Building OneNineFortyLincoln = new Building("1940 Lincoln Avenue")
            {
                Width = 40,
                Depth = 45.5,
                Stories = 2,
                Designer = "Bob Shaver",

            };
            OneNineFortyLincoln.Construct();
            OneNineFortyLincoln.Purchase("Charlotte Shaver");

            City metropolis = new City(){
                Name = "Metropolis",
                Mayor = "Charlotte Shaver",
                YearEstablished = "2014",
            };

            metropolis.AddBuildingToCity(FiveOneTwoEigth);
            metropolis.AddBuildingToCity(OneNineFortyLincoln);
            
            foreach(Building building in metropolis.Buildings){
            // building.printValues();
            Console.WriteLine();
            Console.WriteLine($"{building.Address}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Designed by {building.Designer}");
            Console.WriteLine($"Constructed on {building.DateConstructed}");
            Console.WriteLine($"Owned by {building.Owner}");
            Console.WriteLine($"{building.Volume} cubic meters of space");
        };
    }
}
}
