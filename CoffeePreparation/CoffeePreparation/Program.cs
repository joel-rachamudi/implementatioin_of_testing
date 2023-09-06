namespace CoffeePreparation
{   public class Coffee
    {
        public Coffee() { }
        public string PrepareCoffee() 
        {
            Console.WriteLine("coffee prepared");
            return "CP";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Program begins here");
            Coffee coffee = new Coffee();
            coffee.PrepareCoffee();
        }
    }
}