using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.OOP
{
    public class Animal
    {
        // Fields.
        private string _name;
        private int _weigth;
        private string _sound;

        // Properties.
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Weight
        {
            get { return _weigth; }
            set
            {
                if (value > 0)
                    _weigth = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Weight), "Should be greater than 0.");
            }
        }
        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        public Animal()
        {

        }
    }
}