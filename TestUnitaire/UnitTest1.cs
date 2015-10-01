using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculatrice;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNombre()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(45.0, calcul.calculerOperation("45"));
        }

        [TestMethod]
        public void TestAddition()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(35.0, calcul.calculerOperation("25 + 10"));
        }

        [TestMethod]
        public void TestSoustraction()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(15.0, calcul.calculerOperation("25 - 10"));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(250.0, calcul.calculerOperation("25 x 10"));
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(2.5, calcul.calculerOperation("25 / 10"));
        }

        [TestMethod]
        public void TestMultipleAddition()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(93.0, calcul.calculerOperation("25 + 10 + 10 + 48"));
        }

        [TestMethod]
        public void TestPriorite()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(29.5, calcul.calculerOperation("5 x 5 + 9 / 2"));
        }

        [TestMethod]
        public void TestParenthese()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(35.0, calcul.calculerOperation("5 x (5 + 9) / 2"));
        }

        [TestMethod]
        public void TestParenthese2()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(17.0, calcul.calculerOperation("(5 x 5 + 9) / 2"));
        }

        [TestMethod]
        public void TestParenthese3()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(47.5, calcul.calculerOperation("5 x (5 + (9 / 2))"));
        }

        [TestMethod]
        public void TestParenthese4()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(35.0, calcul.calculerOperation("(5 x (5 + 9)) / 2"));
        }

        [TestMethod]
        public void TestParenthese5()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(47.5, calcul.calculerOperation("(5 x (5 + 9 / 2))"));
        }

        [TestMethod]
        public void TestParenthese6()
        {
            Calculateur calcul = new Calculateur();
            // erreur de saisie
            Assert.AreEqual(0.0, calcul.calculerOperation("(5 x (5 + 9 / 2)"));
        }

        [TestMethod]
        public void TestParenthese7()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(680.0, calcul.calculerOperation("(5 x 8 x 2) + 300 x (32/2/2 - 6)"));
        }


        [TestMethod]
        public void TestParenthese8()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(0.0, calcul.calculerOperation("((5 x 8 x 2) + 300 x (32/2/2 - 6))-((5 x 8 x 2) + 300 x (32/2/2 - 6))"));
        }

        [TestMethod]
        public void TestCosinusDeg()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(Math.Sqrt(2) / 2, calcul.calculerOperation("cos(45)"));
        }

        [TestMethod]
        public void TestCosinusDeg2()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(5 + Math.Sqrt(2) / 2, calcul.calculerOperation("5 + cos(45)"));
        }

        [TestMethod]
        public void TestCosinusDeg3()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(100 * (Math.Sqrt(2) / 2), calcul.calculerOperation("100 x cos(45)"));
        }

        [TestMethod]
        public void TestSinusDeg()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(5, calcul.calculerOperation("5sin(90)"));
        }

        [TestMethod]
        public void TestCosinusRad()
        {
            Calculateur calcul = new Calculateur("Rad");
            Assert.AreEqual(Math.Cos(Math.PI / 3), calcul.calculerOperation("cos(Pi/3)"));
        }

        [TestMethod]
        public void TestNeperien()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(1, calcul.calculerOperation("ln(powe(1))"));
        }

        [TestMethod]
        public void TestLog()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(5, calcul.calculerOperation("5log(10)"));
        }

        [TestMethod]
        public void TestFactorielle()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(120, calcul.calculerOperation("fact(5)"));
        }

        [TestMethod]
        public void TestNombreNegatif()
        {
            Calculateur calcul = new Calculateur();
            Assert.AreEqual(299, calcul.calculerOperation("-1 + 50 x 6"));
        }
    }
}
