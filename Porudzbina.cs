using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    public class Porudzbina
    {
        int id;
        DateTime datum;
        Korisnik kupac;
        List<Proizvod> proizvod;
        List<int> kolicina;

        public Porudzbina(int id, Administrator kupac, List<Proizvod> proizvod, List<int> kolicina)
        {
            this.id = id;
            this.kupac = kupac;
            this.proizvod = proizvod;
            this.kolicina = kolicina;
            datum = DateTime.Now/*.ToLongDateString()*/;
        }

        public Porudzbina(int id, RegistrovaniKupac kupac, List<Proizvod> proizvod, List<int> kolicina)
        {
            this.id = id;
            this.kupac = kupac;
            this.proizvod = proizvod;
            this.kolicina = kolicina;
            datum = DateTime.Now/*.ToLongDateString()*/;
        }

        public Porudzbina(int id, Administrator kupac, List<Proizvod> proizvod, List<int> kolicina, DateTime datum)
        {
            this.id = id;
            this.kupac = kupac;
            this.proizvod = proizvod;
            this.kolicina = kolicina;
            this.datum = datum;
        }
        public Porudzbina(int id, RegistrovaniKupac kupac, List<Proizvod> proizvod, List<int> kolicina, DateTime datum)
        {
            this.id = id;
            this.kupac = kupac;
            this.proizvod = proizvod;
            this.kolicina = kolicina;
            this.datum = datum;
        }

        public string toString()
        {
            string porudzbina;
            if (kupac is Administrator)
            {
                porudzbina = "{" + getId() + "}, {" + ((Administrator)getKupac()).toString() + ", Admin" + "}, {";
                for (int i = 0; i < proizvod.Count; i++)
                {
                    porudzbina += "{" + ProizvodToString(i) + "}";
                }
                porudzbina += "}, {";
                for (int i = 0; i < proizvod.Count; i++)
                {
                    porudzbina += "{" + KolicinaToInt(i) + "}";
                }
                porudzbina += "}, {" + datum.ToString() + "}";
            }
            else
            {
                porudzbina = "{" + getId() + "}, {" + ((RegistrovaniKupac)getKupac()).toString() + ", Kupac" + "}, {";
                for (int i = 0; i < proizvod.Count; i++)
                {
                    porudzbina += "{" + ProizvodToString(i) + "}";
                }
                porudzbina += "}, {";
                for (int i = 0; i < proizvod.Count; i++)
                {
                    porudzbina += "{" + KolicinaToInt(i) + "}";
                }
                porudzbina += "}, {" + datum.ToString() + "}";
            }
            //string porudzbina = getId() + ", {" + getKupac() + "}, {" + getProizvod() + "} * " + getKolicina() + " komada, datum: " + datum.ToString();
            return porudzbina;
        }

        public int getId()
        {
            return id;
        }

        public Korisnik getKupac()
        {
            return kupac;
        }

        public void setKupac(Korisnik kupac)
        {
            this.kupac = kupac;
        }

        public string ProizvodToString(int indeks)
        {
            return proizvod[indeks].toString();
        }

        public List<Proizvod> getProizvod()
        {
            return proizvod;
        }

        public void setProizvod(List<Proizvod> proizvod)
        {
            this.proizvod = proizvod;
        }

        public int KolicinaToInt(int indeks)
        {
            return kolicina[indeks];
        }
        public List<int> getKolicina()
        {
            return kolicina;
        }

        public void setKolicina(List<int> kolicina)
        {
            this.kolicina = kolicina;
        }

        public DateTime getDate()
        {
            return datum;
        }
    }
}
