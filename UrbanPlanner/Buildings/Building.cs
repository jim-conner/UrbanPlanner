using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Buildings
{
    class Building
    {
        // fields (private)
        string _designer;
        DateTime _dateConstructed;
        string _address;
        string _owner;

        // properties (public)
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                double calcStories = Convert.ToDouble(Stories);
                return Width * Depth * (calcStories * 3);
            }
        }

        //constructor method for address
        public Building(int stories, double width, double depth, string address, string designer)
        {
            // set field's value to arg value
            Stories = stories;
            Width = width;
            Depth = depth;
            _designer = designer;
            _address = address; //I'm setting this field here only and not for class?

            var formattedAddress = address.PadRight(15 + address.Length, '-');
            Console.WriteLine(
                $"{formattedAddress}\r\n" +
                $"Designed By {designer}\r\n" +
                $"{Volume} cubic meters of space"
                );
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            Console.WriteLine($"Consructed on {_dateConstructed}");
        }

        public void Purchase(string name)
        {
            //name = _owner; this is wrong
            _owner = name; //this is correct - you're passing in name
            Console.WriteLine($"Owned by {name}");
            Console.WriteLine();
        }
    }
}
