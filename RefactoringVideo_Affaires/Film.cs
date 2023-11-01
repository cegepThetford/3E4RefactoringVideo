using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringVideo_Affaires
{
    public class Film
    {
        public const int ENFANTS = 2;
        public const int REGULIER = 0;
        public const int NOUVEAUTE = 1;

        private string _titre;
        private int _codePrix;

        public Film(string titre, int codePrix)
        {
            _titre = titre;
            _codePrix = codePrix;
        }
        public string Titre { get { return _titre; } }
        public int CodePrix { get { return _codePrix; } set { _codePrix = value; } }

        public override bool Equals(object obj)
        {
            bool egal = false;
            if (obj is Film)
                if (((Film)obj).Titre.Equals(_titre))
                    egal = true;
            return egal;
        }
        public override int GetHashCode()
        {
            return _titre.GetHashCode();
        }
    }
}