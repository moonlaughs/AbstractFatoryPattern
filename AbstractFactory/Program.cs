using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            string continent = "";
            if (args.Length >= 1)
            {
                continent = args[0]; //properties of the project >> Debug >> Aplication Arguments
            }

            //here we can see that the class (AnimalWorld) has private constructor
            IContinentFactory myContinent1 = AnimalWorld.CreateContinent(continent);  //factory
           
            ICarnivore myCarnivore1 = myContinent1.CreateCarnivore();                 //factory
            IHebivore myHarbivore1 = myContinent1.CreateHerbivore();
            myCarnivore1.Hunt();
            myHarbivore1.Graze();

            Console.WriteLine(myCarnivore1.GetType().FullName);


            //Console.WriteLine("Choose continent");
            //string continent = "america";
            //Console.WriteLine("Choose continent");
            //string continent2 = Console.ReadLine();
            //var myContinent2 = AnimalWorld.CreateContinent(continent2);
            //var myC2 = myContinent2.CreateCarnivore();
            //myC2.Hunt();

            Console.ReadKey();
        }
    }
}
