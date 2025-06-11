namespace Task2_Backpackbag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en meny som låter användaren lägga till ett föremål i ryggsäcken, skriva ut det tillagda föremålet och rensa ryggsäcken.
            bool minBool = true;

            // Skapa en variabel som lagrar det tillagda föremålet.
            string item = "";

            // Skapa en meny som låter användaren välja mellan att lägga till ett föremål, skriva ut det tillagda föremålet, rensa ryggsäcken eller avsluta programmet.
            while (minBool)
            {
                // Skriver ut Menyval
                Console.WriteLine("Välkommen till Ryggsäcken");
                Console.WriteLine("[1] - Lägg till ett föremål:");
                Console.WriteLine("[2] - Skriv ut det tillagda föremålet:");
                Console.WriteLine("[3] - Rensa ryggsäcken:");
                Console.WriteLine("[4] - Avsluta programmet:");

                // Läs in användarens val
                int input = Convert.ToInt32(Console.ReadLine());

                // Hantera användarens val
                if (input == 1)
                {
                    Console.Write("Skriv ett föremål du vill lägga till i ryggsäcken:");
                    item = Console.ReadLine();
                }
                // Om användaren väljer 2, skriv ut det tillagda föremålet
                else if (input == 2)
                {
                    Console.WriteLine("Du har lagt till:" + item);
                }
                // Om användaren väljer 3, rensa ryggsäcken
                else if (input == 3)
                {
                    // Rensa ryggsäcken genom att sätta item till en tom sträng
                    item = ""; 
                    Console.WriteLine("Ryggsäcken har rensats.");
                }
                // Om användaren väljer 4, avsluta programmet
                else if (input == 4)
                {
                    // Sätt minBool till false för att avsluta loopen
                    minBool = false;

                    // Skriv ut ett meddelande om att programmet avslutas
                    Console.WriteLine("Programmet avslutas...");
                    Console.ReadLine();
                }
            }
        }
    }
}
