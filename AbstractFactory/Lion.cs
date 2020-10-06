namespace AbstractFactory
{
    internal class Lion : ICarnivore
    {
        public void Hunt()
        {
            System.Console.WriteLine("Lion hunts");
        }
    }
}