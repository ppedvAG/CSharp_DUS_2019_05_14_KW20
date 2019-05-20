using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallsZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schleife zum Wdh des Programms
            do
            {
                //Deklaration und Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                Random generator = new Random();
                int benutzerZahl;
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                int zufallsZahl = generator.Next(1, 11);

                //Schleife für erneuten Versuch
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
                    benutzerZahl = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
                    if (benutzerZahl > zufallsZahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu groß!");
                    }
                    else if (benutzerZahl == zufallsZahl)
                    {
                        Console.WriteLine("Treffer!");
                    }
                    else
                    {
                        Console.WriteLine("Deine Zahl ist zu klein");
                    }

                    //Bedingung für neuen Versuch
                } while (benutzerZahl != zufallsZahl);

                Console.WriteLine("Möchtest du nochmal raten? (y/n)");
                
                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken)
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
            
        }
    }
}
