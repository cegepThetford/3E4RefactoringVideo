using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringVideo_Affaires;

namespace RefactoringVideo_Tests
{
    [TestClass]
    public class TestLocation
    {
        [TestMethod]
        public void LocationCreationTests()
        {
            Film film = new Film("Maison Blanche en Péril", Film.REGULIER);
            Location location = new Location(film, 2);
            Assert.IsNotNull(location.Film);
            Assert.AreEqual(film, location.Film);
            Assert.AreEqual(2, location.DureeLocation);
        }
    }
}

