using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringVideo_Affaires;

namespace RefactoringVideo_Tests
{
    [TestClass]
    public class TestFilm
    {
        private Film nouveauFilm, filmEnfant, filmRegulier;

        [TestInitialize]
        public void initialiser()
        {
            filmRegulier = new Film("Maison Blanche en Péril", Film.REGULIER);
            filmEnfant = new Film("Université des Monstres", Film.ENFANTS);
            nouveauFilm = new Film("Après la Terre", Film.NOUVEAUTE);
        }
        [TestMethod]
        public void FilmCreationTests()
        {
            Assert.AreEqual("Maison Blanche en Péril", filmRegulier.Titre);
            Assert.AreEqual(Film.NOUVEAUTE, nouveauFilm.CodePrix);
            Assert.AreEqual(Film.ENFANTS, filmEnfant.CodePrix);
            Assert.AreEqual(Film.REGULIER, filmRegulier.CodePrix);
        }
        [TestMethod]
        public void FilmMutateurTest()
        {
            filmRegulier.CodePrix = Film.ENFANTS;
            Assert.AreEqual(Film.ENFANTS, filmRegulier.CodePrix);
        }
    }
}