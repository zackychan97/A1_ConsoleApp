using System;
using System.Text;

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

        public static void PrintRandomStringAction()
        {
            Console.Write("Enter in text string you would like: ");
            string? str = Console.ReadLine();

            if (str != null)
            {
                Console.WriteLine($"Taking random action with your string: {str}");

                Random rnd = new Random();
                int randNum = rnd.Next(0, 10);
                string? alteredStr;
                string? actionTaken;

                switch (randNum)
                {
                    case 0:
                        alteredStr = str.ToLower();
                        actionTaken = "toLower()";
                        break;
                    case 1:
                        alteredStr = str.ToUpper();
                        actionTaken = "toUpper()";
                        break;
                    case 2:
                        alteredStr = str.Length.ToString();
                        actionTaken = "Length";
                        break;
                    case 3:
                        int lastCharIndex = str.Length-1;
                        alteredStr = str.Substring(lastCharIndex);
                        actionTaken = "Substring()";
                        break;
                    case 4:
                        StringBuilder sb = new StringBuilder();
                        sb.Append(str);
                        break;
                    case 5:
                        string secretCode = "C# is awesome";
                        alteredStr = str.Contains(secretCode).ToString();
                        actionTaken = "Contains()";
                        break;
                    case 6:
                        alteredStr = str.GetType().ToString();
                        actionTaken = "GetType()";
                        break;
                    case 7:
                        alteredStr = str.IndexOf("a").ToString();
                        actionTaken = "IndexOf";
                        break;
                    case 8:
                        alteredStr = str.Replace("a", "X").Replace("e", "X").Replace("i", "X").Replace("o", "X").Replace("u", "X").Replace("y", "X");
                        actionTaken = "Replace()";
                        break;
                    case 9:
                        alteredStr = str.Reverse().ToString();
                        actionTaken = "Equals()";
                        break;
                }
            }

        }
    }
}
