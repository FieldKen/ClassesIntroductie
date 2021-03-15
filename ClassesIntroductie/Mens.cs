using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntroductie
{
    class Mens
    {
        private string crush = "niemand";

        private string voornaam = "Tim";
        private string achternaam = "Audenaert";

        private int geboortejaar;
        public int Geboortejaar
        {
            get { return geboortejaar; }
            private set
            {
                if (value >= 1900)
                    geboortejaar = value;
            }
        }

        public bool Geslacht { get; private set; }

        public string VolledigeNaam
        {
            get { return $"{achternaam} {voornaam}"; }
        }

        public string Email
        {
            get 
            { 
                //Als {tim} nog niet bestaat:
                return $"{voornaam}@multimedi.be"; 
                //else
                //return {voornaam}{achternaam}@multimedi.be
            }
        }

        public void VeranderGeboortejaar(int nieuwGeboortejaar)
        {
            Geboortejaar = nieuwGeboortejaar;
        }

        public void Spreek()
        {
            Console.WriteLine("Ik ben een mens.");
            Geheim();
        }

        private void Geheim()
        {
            if (crush != "niemand")
                Console.WriteLine($"Ik ben verliefd op {crush}.");
            else
                Console.WriteLine("Ik ben op niemand verliefd.");
        }

        public void VeranderCrush(string nieuweCrush)
        {
            crush = nieuweCrush;
        }
    }
}
