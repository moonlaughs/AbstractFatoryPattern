using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHebivore CreateHerbivore() //this is a factory itself
        {
            return new WildeBeest();
        }
    }
}
