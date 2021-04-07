using Chifoumi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChifoumi
{
    [TestClass]
    public class TestChoix
    {
        [TestMethod]
        public void InitialisationChoixUsuel()
        {
            var test = new Choix("Ciseaux", 2);

            Assert.AreEqual("Ciseaux", test.Libelle);
        }

        [TestMethod]
        public void InitialisationChoixAvecLibelleVide()
        {
            var test = new Choix("", 2);

            // TODO : Cas d'erreur, libellé vide
            Assert.Fail("Non implémenté");
        }

        [TestMethod]
        public void InitialisationChoixAvecValeurNonValide()
        {
            var test = new Choix("Ciseaux", 3);

            // TODO : Cas d'erreur, valeur non valide
            Assert.Fail("Non implémenté");
        }

        [TestMethod]
        public void AffronterUnAutreChoixPlusFort()
        {
            // Arrange
            var test = new Choix("Pierre", 0);
            var autre = new Choix("Papier", 1);
            
            // Act
            var actual = test.Affronter(autre);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void AffronterUnAutreChoixMoinsFort()
        {
            var test = new Choix("Pierre", 0);
            var autre = new Choix("Papier", 1);
            
            var actual = autre.Affronter(test);
            
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AffronterUnAutreChoixIdentique()
        {
            var test = new Choix("Pierre", 0);
            var autre = new Choix("Pierre", 0);
            
            var actual = test.Affronter(autre);
            
            Assert.AreEqual(0, actual);
        }
    }
}