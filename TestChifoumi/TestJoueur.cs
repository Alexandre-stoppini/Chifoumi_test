using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chifoumi;

namespace TestChifoumi
{
    [TestClass]
    public class TestJoueur
    {
        [TestMethod]
        public void InitialisationNomUsuel() // Cas nominal
        {
            // Arrange
            var nomUsuel = "Toto";
            
            // Act
            var test = new Joueur(nomUsuel);

            // Assert
            Assert.AreEqual("Toto",test.Nom);

        }

        [TestMethod]
        public void InitialisationNomVide() // Cas Extrème
        {
            // Arrange & Act
            var test = new Joueur("");
            
            // Assert
            Assert.AreEqual("",test.Nom);
        }

        [TestMethod]
        public void InitialisationNomNull() // Cas Erreur
        {
            // TODO : Vérifier qu'une erreur est générée sur un nom "null"
            
           Assert.Fail("Non implemnte");
        }
    }
}