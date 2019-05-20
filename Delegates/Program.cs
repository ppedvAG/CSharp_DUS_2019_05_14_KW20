using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
        ///vorher definiert werden.
        public delegate int MeinDelegate(int a, int b);

        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MeinDelegate delegateVariable = Addiere;

            //Ausführung der Delegate-Variablen
            int erg = delegateVariable(78, 45);
            Console.WriteLine(erg);

            //Neuzuweisung der Variable
            delegateVariable = Subtrahiere;

            erg = delegateVariable(78, 45);
            Console.WriteLine(erg);

            //Zuweisung einer zweiten Methode zur Delegate-Variablen
            delegateVariable += Addiere;

            //Bei Ausführung einer Delegate-Variablen werden alle referenzierten Methoden in der Reihenfolge ihrer Zuweisung ausgeführt.
            ///Nur die letzte Methode gibt einen Rückgabewert zurück
            erg = delegateVariable(78, 45);
            Console.WriteLine(erg);

            //Erstellen und Ausgabe einer Liste der in der Variablen gespeicherten Methode
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }

            //Löschen einer Referenz aus der Variablen
            delegateVariable -= Subtrahiere;

            delegateVariable = null;

            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> meinFunc = Addiere;

            meinFunc(78, 12);

            FühreAus(Subtrahiere);

            List<string> städteListe = new List<string>();

            städteListe.Add("Düsseldorf");
            städteListe.Add("Berlin");
            städteListe.Add("Hamburg");
            städteListe.Add("Köln");

            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren

            //Übergabe einer Methode an eine andere Methode
            string gefundeneStadt = städteListe.Find(SucheStadtMitH);

            //Übergabe der Methode als anonyme Methode
            gefundeneStadt = städteListe.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith("H");
                    }
                );

            //Weiteres Bsp für die Übergabe einer anonymen Methode in Lambda (Sortierung der Einträge nach dem ersten Buchstaben)
            gefundeneStadt = städteListe.Find((string stadt) => { return stadt.StartsWith("H"); });
            gefundeneStadt = städteListe.Find(stadt => stadt.StartsWith("H"));

            Console.WriteLine(gefundeneStadt);

            //Weiteres Bsp für die Übergabe einer anonymen Methode in Lambda (Sortierung der Einträge nach dem ersten Buchstaben)
            städteListe = städteListe.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in städteListe)
            {
                Console.WriteLine(item);
            }

            //weiteres Bsp der Lambda-Schreibweise (Methode empfängt zwei int und gibt deren Summe als String zurück)
            Func<int, int, string> funky = (x, y) => (x + y).ToString();

            Console.ReadKey();

        }

        //Bsp-Methode zur Übergabe an eine Liste
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(MeinDelegate dele)
        {
            dele(45, 45);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        //Bsp-Methoden zur Demonstration der Delegate-Funktionalität
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addieren");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahieren");
            return a - b;
        }
    }
}
