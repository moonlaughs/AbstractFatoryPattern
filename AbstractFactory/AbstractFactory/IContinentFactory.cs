using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IContinentFactory
    {
        public IHebivore CreateHerbivore();

        public ICarnivore CreateCarnivore();
    }
}
