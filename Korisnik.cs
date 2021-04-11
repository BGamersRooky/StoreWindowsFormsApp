using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    public class Korisnik
    {
        private int id;
        private string ime;
        private int godiste;

        public Korisnik(int id, string ime, int godiste)
        {
            this.id = id;
            this.ime = ime;
            this.godiste = godiste;
        }

        public string toString()
        {
            string kupac = getId() + ", " + getIme() + ", " + getGodiste();
            return kupac;
        }

        public int getId()
        {
            return id;
        }
        public string getIme()
        {
            return ime;
        }
        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public int getGodiste()
        {
            return godiste;
        }
        public void setGodiste(int godiste)
        {
            this.godiste = godiste;
        }
    }
}
