using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torolecarte.Patterns.OOP;

namespace Torolecarte.Patterns.OOP
{
    public class Dog : Animal
    {
        // Constructors.
        public Dog() : base()
        {
            Sound = "Bark";
        }

        // Methods.
        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }

        // Private Methods.
    }
}