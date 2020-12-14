namespace AbstractFactory
{
    public class Wolf : ICarnivore
    {
        public void Hunt()
        {
            System.Console.WriteLine("Wolf hunts");
        }
    }
}