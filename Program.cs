using System;

namespace A1_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Random Number section of code
            PrintRandomNumber();
            Console.WriteLine();
            // Todays Date section of code
            PrintTodaysDate();
            Console.WriteLine();
            // List of dinos section of code
            PrintRandomDino();
            Console.WriteLine();

        }

        public static void PrintRandomNumber()
        {
            Console.WriteLine("Printing random number. Intense computation incoming!");
            Random rnd = new Random();
            int randNum = rnd.Next(1, 11);
            Console.WriteLine($"Random number: {randNum}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void PrintTodaysDate()
        {
            string today = DateTime.Now.ToShortDateString();
            Console.WriteLine($"Todays date is: {today}");
        }

        public static void PrintRandomDino()
        {
            Console.WriteLine("Printing random dino.");
            Random rnd = new Random();
            int randNum = rnd.Next(0, 10);

            List<string> Dinosaurs = new List<string>();
            Dinosaurs.Add("Tyrannosaurus Rex");
            Dinosaurs.Add("Velociraptor");
            Dinosaurs.Add("Stegosaurus");
            Dinosaurs.Add("Triceratops");
            Dinosaurs.Add("Spinosaurus");
            Dinosaurs.Add("Ankylosaurus");
            Dinosaurs.Add("Brachiosaurus");
            Dinosaurs.Add("Dilophosaurus");
            Dinosaurs.Add("Argentinosaurus");
            Dinosaurs.Add("Parasaurolophus");

            var SortedDinosaursList = Dinosaurs.OrderBy(dino => dino).ToList();
            Console.WriteLine(SortedDinosaursList[randNum]);
        }

        public static void PrintRandomStringAlteration(string str)
        {
            Console.WriteLine($"Altering your string: {str}");

        }
    }
}
