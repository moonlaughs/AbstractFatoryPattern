namespace AbstractFactory
{
    public class Bison : IHebivore
    {
        public void Graze()
        {
            System.Console.WriteLine("Bison graze");
        }
    }
}