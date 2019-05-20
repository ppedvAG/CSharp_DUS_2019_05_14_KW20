using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    class Program
    {
        //ENUMERATOREN sind spezialisierte selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
        ///Dabei ist jeder Zustand an einen Integer-Wert gekoppelt, wodurch eine explizite Umwandlung (Cast) möglich ist.
        enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}

        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heute = Wochentag.Mittwoch;
            Console.WriteLine(heute);

            //Cast: Int -> Wochentag
            heute = (Wochentag)5;
            Console.WriteLine(heute);

            //For-Schleife über die möglichen Zustande des Enumerators
            Console.WriteLine("Welcher Wochentag ist heute?");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }

            //Speichern einer Benutzereingabe (Int) als Enumerator
            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine(heute);

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochestart");
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Arbeitstage");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Schönes Wochenende");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            string a = "Hallo";
            switch (a)
            {
                case string b when b.Length > 4:
                    Console.WriteLine(b);
                    break;
                default:
                    break;
            }

            //Programmpause
            Console.ReadKey();
        }
    }
}
