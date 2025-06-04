namespace Task2_Backpackbag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool minBool = true;
            string item = "";

            while (minBool)
            {
                Console.WriteLine("Välkommen till Ryggsäcken");
                Console.WriteLine("[1] - Lägg till ett föremål:");
                Console.WriteLine("[2] - Skriv ut det tillagda föremålet:");
                Console.WriteLine("[3] - Rensa ryggsäcken:");
                Console.WriteLine("[4] - Avsluta programmet:");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("Skriv ett föremål du vill lägga till i ryggsäcken:");
                    item = Console.ReadLine();
                }
                else if (input == 2)
                {
                    Console.WriteLine("Du har lagt till:" + item);
                }
                else if (input == 3)
                {
                    //Menyval 3
                }
                else if (input == 4)
                {
                    minBool = false;
                    Console.WriteLine("Programmet avslutas...");
                    Console.ReadLine();
                }
            }
        }
    }
}
