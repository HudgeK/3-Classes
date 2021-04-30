using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            drink ChocolateMilk = new drink();
            ChocolateMilk.Name = "Chocolate Milk";
            ChocolateMilk.Flavor = "Rich";
            food BuffaloWings = new food();
            BuffaloWings.Name = "Buffalo Chicken Wings";
            BuffaloWings.Flavor = "Spicy";
            utensil Fork = new utensil();
            Fork.Name = "Fork";
            Fork.Material = "Plastic";
            Console.ReadLine();
        }
    }
}