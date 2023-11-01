using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringVideo_Affaires
{
    public class Client
    {
        private string _nom;
        private List<Location> _locations;
        public Client(string nom)
        {
            _nom = nom;
            _locations = new List<Location>();
        }
        public string Nom { get { return _nom; } }
        public List<Location> Locations { get { return _locations; } }
        public void ajouter(Location loc)
        {
            _locations.Add(loc);
        }
        public string produireFacture()
        {
            decimal montantTotal = 0.0m;
            int pointsFrequenceLocation = 0;
            string res = String.Format("Facture pour {0}\n", _nom, null); ;
            foreach (Location loc in _locations)
            {
                decimal ceMontant = 0.0m;
                switch (loc.Film.CodePrix)
                {
                    case Film.REGULIER:
                        ceMontant += 2.0m;
                        if (loc.DureeLocation > 2)
                            ceMontant += (loc.DureeLocation - 2) * 1.5m;
                        break;
                    case Film.NOUVEAUTE:
                        ceMontant += loc.DureeLocation * 3.0m;
                        break;
                    case Film.ENFANTS:
                        ceMontant += 1.5m;
                        if (loc.DureeLocation > 3)
                            ceMontant += (loc.DureeLocation - 3) * 1.5m;
                        break;
                }
                pointsFrequenceLocation++;
                if (loc.Film.CodePrix == Film.NOUVEAUTE && loc.DureeLocation > 1)
                    pointsFrequenceLocation++;
                res += String.Format("\t{0}\t{1:F2}\n", loc.Film.Titre, ceMontant); ;
                montantTotal += ceMontant;
            }
            res += String.Format("Montant dû: {0:F2}\n", montantTotal,null);
            res += String.Format("Points    : {0}\n", pointsFrequenceLocation);
            return res;
        }
    }
}
