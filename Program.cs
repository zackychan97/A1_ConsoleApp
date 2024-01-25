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

            // Todays Date section of code
            string today = DateTime.Now.ToShortDateString();
            Console.WriteLine($"Todays date is: {today}");

            // List of dinos section of code
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

        }
    }
}
