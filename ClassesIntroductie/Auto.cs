using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntroductie
{
    class Auto
    {
        private int benzine;
        public int Benzine
        {
            get { return benzine; }
            set 
            { 
                if (value >= 0)
                    benzine = value;
            }
        }

        private int myVar;
        public int MyProperty
        {
            set { myVar = value; }
        }



        //propfull tab tab
        /*private int gas;

        public int Gas
        {
            get { return gas; }
            set { gas = value; }
        }*/
    }
}
