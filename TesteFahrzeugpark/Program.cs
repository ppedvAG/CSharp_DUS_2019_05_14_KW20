using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul04 OOP
            ////Instanzierung von Fahrzeugen
            //Fahrzeug fz = new Fahrzeug("BMW", 270);
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 310);

            ////Ausgabe der Maximalgeschwindigkeit von fz
            //Console.WriteLine(fz.MaxGeschwindigkeit);

            ////Änderung des Namens von fz1
            //fz.Name = "VW";

            ////Ausgabe der BeschreibeMich()-Methoden der Fahrzeuge
            //Console.WriteLine(fz.BeschreibeMich());
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Neuzuweisung der fz1-Variable auf Objekt in fz-Variable
            //fz1 = fz;

            ////Manueller Aufruf der Garbage Collection
            //GC.Collect(); 
            #endregion

            #region Lab04 Fahrzeug_Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen zum Testen der Fahrzeug-Funktionen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Modul05 Vererbung
            ////Instantiierung der Beispiel-Fahrzeuge
            //PKW pkw1 = new PKW("BMW", 190, 23000, 5);
            //PKW pkw2 = new PKW("BMW", 190, 23000, 5);
            //PKW pkw3 = new PKW("BMW", 190, 23000, 5);
            //PKW pkw4 = new PKW("BMW", 190, 23000, 5);
            //PKW pkw5 = new PKW("BMW", 190, 23000, 5);

            ////Testen der überschriebenen BeschreibeMich()-Methode (vgl. PKW)
            //Console.WriteLine(pkw1.BeschreibeMich());

            ////Testen der überschriebenen ToString()-Methode (vgl. PKW)
            //Console.WriteLine(pkw1);

            ////Testen der statischen Property und Methode (vgl. PKW)
            //Console.WriteLine(Fahrzeug.AnzahlFahrzeuge);
            //Fahrzeug.ZeigeAnzahlFahrzeuge();
            #endregion

            #region Lab05 PKW-, Schiff- und Flugzeug-Klasse

            ////Instanziierung der unterschiedlichen Fahrzeug-Arten und Ausgabe der BeschreibeMich()-Methoden
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());

            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Modul06 Interfaces und Polymorphismus
            ////Initialisierung einer PKW-Variablen mit einem Beispiel-PKW
            //PKW pkw1 = new PKW("BMW", 190, 23000, 5);

            ////Initialisierung einer Fahrezug- und einer IBewegbar-Variablen mit demselben PKW 
            ////(alle Variablen zeigen auf das selbe Objekt im Speicher, können aber nur au die in der jeweiligen Klasse/Interface definierten Eigenschaften
            ////und Methoden zugreifen)
            //Fahrzeug fz1 = pkw1;
            //IBewegbar bewegbaresObjekt = pkw1;

            ////Demonstration der Zugriffsmöglichkeiten der einzelnen Variablen
            //pkw1.BeschreibeMich();
            //fz1.Beschleunige(0);
            //bewegbaresObjekt.Crash();

            ////Aufruf einer Beispiel-Funktion (s.u.) welche ein Objekt vom Typ IBewegbar erwartet
            //RadAb(pkw1); 
            #endregion

            #region Lab06 IBeladbar

            ////Instanziierung der Beispiel-Fahrzeuge
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            ////Aufruf der BeladeFahrzeuge()-Methode (s.u.)
            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            ////Ausgabe der BeschreibeMich()-Methode des beladenen Fahrzeugs
            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            #region Generische Listen
            //List<string> stringListe = new List<string>();

            //stringListe.Add("Hallo");
            //stringListe.Add("Moin");
            //stringListe.Add("Servus");
            //stringListe.Add("Guten Tag");

            //foreach (var item in stringListe)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stringListe[2]);

            //List<Fahrzeug> fzListe = new List<Fahrzeug>();

            //fzListe.Add(new PKW("BMW", 250, 23000, 5));
            //fzListe.Add(new Flugzeug("Boing", 750, 3000000, 9990));
            //fzListe.Add(new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));


            //foreach (var item in fzListe)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Dictionary<string, Fahrzeug> dict = new Dictionary<string, Fahrzeug>();

            //dict.Add("Mein Auto", new PKW("BMW", 250, 23000, 5));
            //dict.Add("Mein Flugzeug", new Flugzeug("Boing", 750, 3000000, 9990));

            //if (dict.ContainsKey("Mein Flugzeug"))
            //    Console.WriteLine(dict["Mein Flugzeug"].Name); 
            #endregion

            #region Lab07_ZufälligeFahrzeuglisten

            //            Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            //            Random generator = new Random();
            //            Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //            Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //            Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            //            Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe
            //            int AnzahlFZs = 10000;

            //            Schleife zur zufälligen Befüllung von Queue und Stack
            //            for (int i = 0; i < AnzahlFZs; i++)
            //            {
            //                Würfeln einer zufälligen Zahl im Switch
            //                switch (generator.Next(1, 4))
            //                {
            //                    Erzeugung von Objekten je nach zufälliger Zahl
            //                    case 1:
            //                        fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
            //                fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
            //                break;
            //                    case 2:
            //                        fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //                fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //                break;
            //                    case 3:
            //                        fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
            //                fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
            //                break;
            //            }
            //        }

            //        Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //            for (int i = 0; i<AnzahlFZs; i++)
            //            {
            //                Prüfung, ob das Interface vorhanden ist(mittels Peek(), da die Objekte noch benötigt werden)...
            //                if (fzQueue.Peek() is IBeladbar)
            //                {
            //                    ...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode(mittels Peek())...
            //                    ((IBeladbar) fzQueue.Peek()).Belade(fzStack.Peek());
            //                    ...sowie Hinzufügen zum Dictionary(mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //                    fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //                }
            //                else
            //                {
            //                    ... wenn nein, dann Löschung der obersten Objekte(mittels Pop()/Dequeue())
            //                    fzQueue.Dequeue();
            //                    fzStack.Pop();
            //                }
            //            }

            //            Programmpause
            //            Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            //            Schleife zur Ausgabe des Dictionaries
            //            foreach (var item in fzDict)
            //            {
            //                Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            //            }

            #endregion

            //ArrayLists sind Listen, welche mit Objekten beliebiger Datentypen gefüllt werden können.
            ArrayList list = new ArrayList(3);

            list.Add(78);
            list.Add("Hallo");
            list.Add(new PKW());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Vorbereitung
            Fahrzeug fz1 = new PKW("BMW", 190, 23000, 5);
            Flugzeug flugzeug1 = new Flugzeug("Boing", 990, 300000000, 9999);
            Random generator = new Random();

            //Bsp für die Verwendung der in der Fahrzeug-Klasse definierten Operatoren
            Console.WriteLine(fz1 == fz1);
            Console.WriteLine(fz1 == new Flugzeug("Boing", 999, 500000000, 9999));


            //Bsp für die Verwendung von IEnumerable
            foreach (var item in flugzeug1)
            {
                Console.WriteLine(item);
            }

            //Bsp für die Verwendung der Indexer-Property
            Console.WriteLine(flugzeug1[1]);

            //Bsp für die Verwendung einer Erweiterungsmethode (s.u.)
            int a = generator.NextInclusive(1, 8);


            Console.ReadKey();
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            //Prüfung, ob eins der übergebenen Fahrzeuge IBeladbar implementiert hat
            if (fz1 is IBeladbar)
            {
                //Cast des Fahrzuegs in ein 'beladbares Objekt' und Aufruf der Belade()-Methode
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                //Alternativer Cast
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

        //Bsp-Methode Modul 06
        public static void RadAb(IBewegbar bewegbaresObjekt)
        {
            bewegbaresObjekt.AnzahlRäder--;

            if (bewegbaresObjekt is PKW)
            {
                ((PKW)bewegbaresObjekt).StarteMotor();

                PKW pkw1 = (PKW)bewegbaresObjekt;

                pkw1.Beschleunige(45);
            }
        }
    }

    public static class Hilfsmethoden
    {
        //Mittels des THIS-Stichworts in der Parameterübergabe kann eine Methode als Erweiterungsmethode einer Klasse definiert
        //werden. Diese muss in einer statischen Klasse beschrieben werden und wird dann als Teil der zugeordneten Klasse betrachtet.
        public static int NextInclusive(this Random generator, int a, int b)
        {
            return generator.Next(a, b + 1);
        }
    }
}
