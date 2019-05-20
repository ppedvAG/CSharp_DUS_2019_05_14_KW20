﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTestFahrzeugpark
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgeführt werden sie
    ///über den Test-Explorer
    [TestClass]
    public class UnitTestPKW
    {
        [TestMethod]
        public void Beschleunige_PKW_über_MaxG()
        {
            PKW pkw1 = new PKW("BMW", 190, 23000, 5);

            pkw1.StarteMotor();
            pkw1.Beschleunige(300);

            //Dies ASSERT-Klasse enthält diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden können. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Beschleunige_PKW_auf_150()
        {
            PKW pkw1 = new PKW("BMW", 190, 23000, 5);

            pkw1.StarteMotor();
            pkw1.Beschleunige(150);

            Assert.AreEqual(150, pkw1.AktGeschwindigkeit);

        }
    }
}
