using System;
using UrbanPlanner.Buildings;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Capitol = new Building(5, 1141, 131, "123 Main Street", "Jim");
            Capitol.Construct();
            Capitol.Purchase("We, the People");

            Building Library = new Building(10, 1245, 111, "456 Read Ave", "Jim");
            Library.Construct();
            Library.Purchase("Mr. Rogers");


            Building Batman = new Building(33, 1832, 666, "333 Commerce Street", "Jim");
            Batman.Construct();
            Batman.Purchase("At&t or Bruce Waye");
            //Console.WriteLine($"{Batman.Volume} cubic meters of space");
        }
    }
}
