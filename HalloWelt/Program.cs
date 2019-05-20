﻿//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWelt
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Deklaration einer Integer-Variable 
            int alter;
            //Initialisierung der Integer-Variablen
            alter = 30;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string stadt = "Düsseldorf";

            //Ausgabe eines String-Literals
            Console.WriteLine("Mein Name ist Klaas");
            //Ausgabe einer Integer-Variablen
            Console.WriteLine(alter);

            //Ausgabe einer Berchnung in Strings
            int a = 45;
            int b = 126;
            Console.WriteLine(a + b);

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell'
            Console.WriteLine("Mein Alter ist " + alter + " und bin momentan in " + stadt + ".");
            //Index
            Console.WriteLine("Mein Alter ist {0} und bin momentan in {1}.", alter, stadt);
            //$-Operator
            Console.WriteLine($"Mein Alter ist {alter} und bin momentan in {stadt}.");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine("Dies ist eine neue \nZeile und dies ein \tTabulator");

            // String-Formatierung mittels VerbaTim-String(Einleitung mittels @ / Escape - Sequenzen sind nicht möglich,
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine($@"Die ist eine neue
Zeile und dies ein  Tabulator");

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib eine ganze Zahl ein: ");
            string inputAlsString = Console.ReadLine();
            Console.WriteLine(inputAlsString);

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein: ");
            int inputInt = int.Parse(Console.ReadLine());
            Console.WriteLine(inputInt * 2);

            //Verwendung der Rundungs-Methode der Math-Klasse
            double x = Math.Round(8.6);
            Console.WriteLine(x);
            Console.WriteLine(Math.Round(8.6));

            //Programmpause
            Console.ReadKey();


        }
    }
}
