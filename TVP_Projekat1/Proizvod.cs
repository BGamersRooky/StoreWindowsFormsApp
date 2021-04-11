using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    public class Proizvod
    {
        int id;
        string naziv;
        double cena;

        public Proizvod(int id, string naziv, double cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
        }

        public string toString()
        {
            string text = id + ", " + naziv + ", " + cena;
            return text;
        }

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }

        public string getNaziv()
        {
            return naziv;
        }

        public void setCena(double cena)
        {
            this.cena = cena;
        }

        public double getCena()
        {
            return cena;
        }

        public int getId()
        {
            return id;
        }
    }
}
