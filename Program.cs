using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomTomClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Address moma = new Address();
            moma.Street = "West 53 Street";
            moma.Number = "11";
            moma.ZIP = "10019";
            moma.City = "New York";
            moma.State = "NY";
            moma.Country = "USA";

 
            TomTomClient gc = new TomTomClient("YOUR KEY");

            Console.WriteLine("Geocoding location of Moma NY: " + moma.ToString());
            var momaLocations = gc.CodeAddress(moma, 20);
            foreach (var momaPos in momaLocations)
            {
                Console.WriteLine(momaPos);
            }

            Console.WriteLine("Geocoding Central Park Zoo:");
            foreach(var pos in gc.CodeAddress("64 Fifth Avenue, New York, 10021", "USA", 20))
            {
                Console.WriteLine(pos);
            }
               
            Console.WriteLine("Press [any key]");
            Console.In.Read();
        }
    }
}
