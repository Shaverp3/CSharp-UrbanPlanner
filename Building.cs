using System;
// Private Fields
// _designer of type string. It will hold your name.
// _dateConstructed of type DateTime. This will hold the exact time the building was created.
// _address of type string.
// _owner of type string. This will store the same of the person who owns the building.
// Public Properties
// Stories typed as an integer.
// Width typed as a double.
// Depth typed as a double.
// Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
// Constructor
// Define a constructor method that accepts a single string argument - address - so that you can send as a parameter when you create each instance with new Building("800 8th Street");.

// The constructor's logic should set the _address field's value to the argument value
// Public Methods
// Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
// Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.
// Neither of these methods will return a value.
namespace Planner
{
    public class Building
    {

        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        private int _id;
        private string _name;

        public int Id { get { return _id; } set { _id = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Owner { get { return _owner; } set { _owner = value; } }
        public string Designer { get { return _designer; } set { _designer = value; } }
        public DateTime DateConstructed { get { return _dateConstructed; } set { _dateConstructed = DateTime.Now; } }
        //The following is a constructor method
        public Building(string addressParam)
        {
            _address = addressParam;
        }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct()
        {

            this._dateConstructed = DateTime.Now;
        }

        public void Purchase(string Buyer)
        {
            this._owner = Buyer;
        }
        public void printValues()
        {
            Console.WriteLine();
            Console.WriteLine(this._address);
            Console.WriteLine("--------------");
            Console.WriteLine($"Designed by {this._designer}");
            Console.WriteLine($"Constructed on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
        }

    }
}