﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBsp
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class Form1 : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public Form1()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet
            InitializeComponent();

            BtnKlickMich.BackColor = Color.LightPink;

            this.BtnKlickMich.Top = 50;

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            this.BtnKlickMich.Click += BtnKlickMich_Click_2;

            CbbAuswahl.SelectedIndex = 2;
        }

        //Click-Methoden, der einzelnen Buttons
        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
            //Farbwechsel
            this.BtnKlickMich.BackColor = Color.HotPink;
        }

        private void BtnKlickMich_Click_2(object sender, EventArgs e)
        {
            this.BtnKlickMich.Left += 100;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fenster schließen
            this.Close();

            //Programm beenden
            Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Öffnen eines weiteren Fensters
            Form1 neuesFenster = new Form1();

            neuesFenster.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Abfrage der Wahl des Benutzers
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Aber nicht mehr lange");
            }
            else
            {
                MessageBox.Show("Geht jedem mal so");
            }
        }

        //Methode, welche von dem Timer ausgeführt wird
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Top += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start/Stop des Timers
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }
    }
}
