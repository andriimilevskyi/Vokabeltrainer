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
            Console.WriteLine("Esc - Beenden");
            Console.Write("Auswahl: \n");

            var choice = Console.ReadKey(true);

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    AddWord(vocabluary);
                    break;

                case ConsoleKey.D2:
                    ShowWords(vocabluary);
                    break;

                case ConsoleKey.D3:
                    LearnWords(vocabluary);
                    break;

                case ConsoleKey.Escape:
                    Console.WriteLine("Programm beendet.");
                    return;

                default:
                    Console.WriteLine("\nUngültige Auswahl!");
                    break;
            }


            static void AddWord(Hashtable vocabluary)
            {
                Console.WriteLine("Wort:");
                var word = Console.ReadLine();
                Console.WriteLine("Ubersetzung");
                var ubersetzung = Console.ReadLine(); //translation value

                if (!string.IsNullOrEmpty(word) && !string.IsNullOrWhiteSpace(ubersetzung)) // Check input
                {
                    vocabluary[word] = ubersetzung;
                    Console.WriteLine("Vokabel hinzugefügt!");
                }
                else { Console.WriteLine("Ungultige eingabe!"); }
            }


            static void ShowWords(Hashtable vocab)
            {
                if (vocab.Count == 0)
                {
                    Console.WriteLine("Keine Vokabeln vorhanden.");
                    return;
                }

                Console.WriteLine("\n--- Vokabeln ---");

                foreach (DictionaryEntry entry in vocab)
                {
                    Console.WriteLine($"{entry.Key} = {entry.Value}");
                }
                Console.WriteLine("Beliebige Taste drücken, um fortzufahren.");
                Console.ReadKey();
            }


            static void LearnWords(Hashtable vocab)
            {
                if (vocab.Count == 0)
                {
                    Console.WriteLine("Keine Vokabeln.");
                    return;
                }

                var random = new Random();
                var keys = new ArrayList(vocab.Keys); // Copy vocabulary keys (words) into a list

                // words shuffle
                keys = new ArrayList(keys.Cast<object>()
                                         .OrderBy(x => random.Next())
                                         .ToList()); // Shuffle keys randomly using LINQ


                foreach (var key in keys) // Iterate through all shuffled words
                {
                    Console.WriteLine($"\nÜbersetze: {key}");

                    var answer = Console.ReadLine(); // Read user's input


                    var correctValue = vocab[key]; // Get correct translation from Hashtable
                    if (correctValue == null)
                    {
                        Console.WriteLine("Fehler: Kein Wert gefunden.");
                        return;
                    }
                    var correct = correctValue.ToString(); // Convert correct answer to strin


                    if (answer != null && answer.ToLower() == correct?.ToLower()) // Check answer
                    {
                        Console.WriteLine("Richtig!");
                    }
                    else
                    {
                        Console.WriteLine($"Falsch! Richtige Antwort: {correct}");
                    }
                }
            }

        }
    } 
}
