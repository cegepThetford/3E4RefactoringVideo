using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringVideo_Affaires
{
    public class Location
    {
        private Film _film;
        private int _dureeLocation;

        public Location(Film film, int duree)
        {
            _film = film;
            _dureeLocation = duree; 
        }
        public Film Film { get { return _film; } }
        public int DureeLocation { get { return _dureeLocation; } }
    }
}