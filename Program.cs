namespace A1_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Random Number section of code
            Console.WriteLine("Printing random number. Intense computation incoming!");
            Random rnd = new Random();
            int randNum = rnd.Next(1, 11);
            Console.WriteLine($"Random number: {randNum}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
