using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHebivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
