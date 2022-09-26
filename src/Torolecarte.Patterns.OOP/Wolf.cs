using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torolecarte.Patterns.OOP
{
    public class Wolf : Dog
    {
        public string Hierarchy { get; set; }

        public Wolf(string hierarchy)
        {
            Sound = "Howls";
            Hierarchy = hierarchy;
        }

        public void Howl()
        {
            Console.WriteLine("Auuuuuuu!");
        }
    }
}
