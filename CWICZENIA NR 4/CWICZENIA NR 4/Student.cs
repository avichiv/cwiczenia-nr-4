using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_4
{
    class Student : Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }
        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
            :base(imie,nazwisko,rokUrodzenia)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public string WypiszInfo()
        {
            base.WypiszInfo();
            return imie + " " + nazwisko + " " + rokUrodzenia + " " + rok + " " + numerGrupy + " " + numerAlbumu;
            
        }
    }
}
