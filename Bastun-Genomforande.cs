using System;

namespace Bastun_Genomförande
{
    class Program
    {

        // =========== METOD ==============
        // FahrToCels, konverterar helt enkelt Fahrenheit till Celsius 
        // Överlagring 1 - med int

        public static double FahrToCels(int fahr)
        {
            int val1 = fahr;
            float fahrenheit = (float)val1;

            //double grader = 0;
            //int myInt = (int)grader;

            fahrenheit = (fahrenheit - 32) * 5 / 9;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            // Deklarera variabler för alla temperaturer i programmet

            int minTemp = 73;
            int maxTemp = 77;
            int perfectTemp = 75;
            int fahrenheit = 0;
            double celsius = 0;


            // Välkomnar användaren till programmet

            Console.WriteLine("Välkommen till bastun!");
            Console.WriteLine("______________________");
            Console.WriteLine();

            // ======================== do-while-loop ==============================
            do
            {
                // ================= Try-Catch =====================
                // För att fånga in om användaren skriver in någonting annat än ett heltal

                Console.WriteLine("Skriv in ett temperatur, om du skriver in en nolla så kommer det att slumpas fram en temperatur istället: ");
                string strNr = Console.ReadLine();

                try
                {
                    fahrenheit = Convert.ToInt32(strNr);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Fel! Endast nummer!");
                    Console.WriteLine("GE DETTA TILL PROGRAMMERAREN: ");
                    Console.WriteLine(e);
                }

                // Här kommer vi ifall användaren matar in en nolla att slumpa fram en lämplig temperatur
                Random rnd = new Random();
                if (fahrenheit == 0)
                    fahrenheit = rnd.Next(163, 171);

                // Det inmatade värdet skickas vidare till metoden och omvandlas till Celsius och skrivs ut till användaren
                celsius = FahrToCels(fahrenheit);
                Console.WriteLine("Det du har matat in i Fahrenheit motsvarar {0:0.00} grader Celsius.", celsius);

                // if satser med olika villkor beroende på vilken temperatur som matats in
                if (celsius < minTemp)
                {
                    Console.WriteLine("För kallt höj värmen lite.");
                    Console.WriteLine();

                }
                else if (celsius > maxTemp)
                {
                    Console.WriteLine("För varmt sänk värmen lite.");
                    Console.WriteLine();

                }


                // Om dessa villkor blir till "true" så börjar vi om programmet igen, är villkoren false så går vi ur while loopen.

            } while (celsius < minTemp || celsius > maxTemp);

            // En sista if else sats för att skilja på om graderna är inställd på perfekt temperatur eller om det är acceptabelt.

            if (celsius == perfectTemp)
            {
                Console.WriteLine("Perfekt temperatur!");
            }
            else
            {
                Console.WriteLine("Temperaturen är nu acceptabel, det går bra att basta.");
            }

            // Programmet avslutas och väntar på att användaren ska trycka in valfri tangent
            Console.WriteLine("Programmet avslutas.");
            Console.ReadKey();
        }
    }
}
