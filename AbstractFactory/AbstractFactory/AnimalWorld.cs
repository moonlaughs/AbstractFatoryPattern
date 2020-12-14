using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AnimalWorld
    {
        public static IContinentFactory CreateContinent(string continet)
        {
            IContinentFactory cf;
            if(continet.ToLower().Trim() == "america")
            {
                cf = new AmericaFactory();
            }
            else
            {
                cf = new AfricaFactory();
            }

            return cf;
        }

        private AnimalWorld()
        {

        }
    }
}
