using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    public class RegistrovaniKupac : Korisnik
    {
        string tip;
        public RegistrovaniKupac(int id, string ime, int godiste) : base(id, ime, godiste)
        {
            tip = "Kupac";
        }
        public RegistrovaniKupac(Korisnik k) : base(k.getId(), k.getIme(), k.getGodiste())
        {
            tip = "Kupac";
        }

        public string getTip()
        {
            return tip;
        }
        public void setTip(string tip)
        {
            this.tip = tip;
        }
        public string toString()
        {
            string kupac = getId() + ", " + getIme() + ", " + getGodiste() + ", " + getTip();
            return kupac;
        }
    }
}
