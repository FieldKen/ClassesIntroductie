using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntroductie
{
    class Program
    {
        static void Main(string[] args)
        {
            Mens mens = new Mens();
            mens.Spreek();
            mens.VeranderCrush("Bart");
            mens.Spreek();

            mens.VeranderGeboortejaar(1950);
            Console.WriteLine(mens.Geboortejaar);
            mens.VeranderGeboortejaar(1850);
            Console.WriteLine(mens.Geboortejaar);
            Console.WriteLine(mens.VolledigeNaam);
            mens.Geslacht = true;
            mens.Geslacht = false;

            Auto auto = new Auto();
            auto.Benzine = -50;
            Console.WriteLine($"Er zit nog {auto.Benzine} liter in.");
            auto.Benzine = 50;
            Console.WriteLine($"Er zit nog {auto.Benzine} liter in.");

            auto.MyProperty = 10;
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
