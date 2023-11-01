using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringVideo_Affaires;

namespace RefactoringVideo_Tests
{
    [TestClass]
    public class TestClient
    {
        private Client client;

        [ClassInitialize]
        public static void initialisationUnique(TestContext context)
        {
            Thread.CurrentThread.CurrentCulture =
               new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo("en-US");
        }

        [TestInitialize]
        public void initialiser()
        {
            client = new Client("Marco");
            client.ajouter(new Location(new Film("Maison Blanche en Péril", Film.REGULIER), 3));
        }
        [TestMethod]
        public void ClientCreationTests()
        {
            Assert.AreEqual("Marco", client.Nom);
            Assert.IsNotNull(client.Locations);
            Assert.AreEqual(1, client.Locations.Count);
        }
        [TestMethod]
        public void ClientAjoutLocationTest()
        {
            client.ajouter(new Location(new Film("Université des Monstres", Film.ENFANTS),4));
            Assert.AreEqual(2, client.Locations.Count);
            Assert.AreEqual("Université des Monstres", client.Locations[1].Film.Titre);
            Assert.AreEqual("Maison Blanche en Péril", client.Locations[0].Film.Titre);
        }
        [TestMethod]
        public void ClientFactureTests()
        {
            client.ajouter(new Location(new Film("Université des Monstres", Film.ENFANTS), 4));
            client.ajouter(new Location(new Film("Après la Terre", Film.NOUVEAUTE), 2));
            string fact = client.produireFacture();
            Assert.AreEqual("Facture pour Marco\n\tMaison Blanche en Péril\t3.50\n\tUniversité des Monstres\t3.00\n\tAprès la Terre\t6.00\nMontant dû: 12.50\nPoints    : 4\n", fact);
        }
    }
}