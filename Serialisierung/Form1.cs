using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugpark;
//Json ist eine Serialisierungs-Methode, welche über den NuGet-Marketspace installiert und dem Projekt hinzugefügt wurde
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> FahrzeugListe { get; set; }
        public Random generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            FahrzeugListe = new List<Fahrzeug>();
            generator = new Random();
        }

        //Click-Methoden der Buttons

        //Methode zur zufälligen Erstellung von Fahrzeugen
        private void BtnNew_Click(object sender, EventArgs e)
        {
            switch (generator.Next(1, 4))
            {
                //Erzeugung von Objekten je nach zufälliger Zahl
                case 1:
                    FahrzeugListe.Add(new Flugzeug($"Boing", 800, 3600000, 9999));
                    break;
                case 2:
                    FahrzeugListe.Add(new Schiff($"Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                    break;
                case 3:
                    FahrzeugListe.Add(PKW.ErzeugeZufälligenPKW($""));
                    break;
            }

            ShowFzs();
        }

        //Methode zum Löschen von Fahrzeugen
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FahrzeugListe.RemoveAt(LbxFahrzeuge.SelectedIndex);

            ShowFzs();
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void BtnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(@"C:\Beispiel\Fahrzeuge.txt");

                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                //Iteration über die FahrzeugListe
                foreach (var item in FahrzeugListe)
                {
                    string umgewandeltesFz = JsonConvert.SerializeObject(item, settings);

                    writer.WriteLine(umgewandeltesFz);
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                writer?.Close();
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.BtnLoad_Click())
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@"C:\Beispiel\Fahrzeuge.txt");

                //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
                //zu ladenden/speichernden Objekte mit abspeichert
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                FahrzeugListe.Clear();

                while (!reader.EndOfStream)
                {
                    //Lesen einer Textzeile aus der Datei
                    //und Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                    //und Hinzufügen des Fahrzeugs zur Liste
                    FahrzeugListe.Add(JsonConvert.DeserializeObject<Fahrzeug>(reader.ReadLine(), settings));
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                reader?.Close();
            }

            ShowFzs();
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        private void ShowFzs()
        {
            LbxFahrzeuge.Items.Clear();

            foreach (var item in FahrzeugListe)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }
    }
}
