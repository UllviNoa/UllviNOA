using System;

namespace ShowTheClassFirstConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Skriv ditt namn:");
            string namn = Console.ReadLine();


            Console.WriteLine("Vad är din adress?");
            string adress = Console.ReadLine();



            Console.WriteLine("Ditt namn är alltså: " + namn 
                              + " och din adress är " + adress
                              + " Hej då!");

        }
    }
}
