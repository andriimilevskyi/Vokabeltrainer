using System;
using System.Collections;


public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string('-', 10));
        Console.WriteLine("Vokabeltrainer");
        Console.WriteLine("MILEVSKYI");
        Console.WriteLine(new string('-', 10));
        Console.ResetColor();


        Hashtable vocabluary = new Hashtable();

        while (true) 
        {

            Console.WriteLine("\n=== Vokabeltrainer ===");
            Console.WriteLine("1 - Vokabel hinzufügen");
            Console.WriteLine("2 - Vokabeln anzeigen");
            Console.WriteLine("3 - Lernen");
            Console.WriteLine("4 - Beenden");
            Console.Write("Auswahl: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    break;

                case "2":
                    
                    break;

                case "3":
                    
                    break;

                case "4":
                    Console.WriteLine("Programm beendet.");
                    return;

                default:
                    Console.WriteLine("Ungültige Auswahl!");
                    break;
            }
        }

    }

}
}