using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_4
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        private string miejsceZamieszkania;

        public string MiejsceZamieszkania
        {
            get { return miejsceZamieszkania; }
            set { miejsceZamieszkania = value; }
        }

        public Osoba()
        {
            this.imie = "Jan";
            this.nazwisko = "Janowicz";
            this.rokUrodzenia = 2018;
        }
        public Osoba(string imie, string nazwisko, int rokUrodzenia) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }
         public string WypiszInfo()
        {
            return imie + " " + nazwisko + " " + rokUrodzenia;
        }

         public int ObliczWiek()
         {
             return DateTime.Now.Year - rokUrodzenia;
         }
    }
}
