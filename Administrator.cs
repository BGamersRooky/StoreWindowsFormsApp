using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    public class Administrator : Korisnik
    {
        string tip;

        public Administrator(int id, string ime, int godiste) : base (id, ime, godiste)
        {
            tip = "Admin";
        }
        public Administrator(Korisnik k) : base (k.getId(), k.getIme(), k.getGodiste())
        {
            tip = "Admin";
        }

        public string getTip()
        {
            return tip;
        }
        public void setTip(string tip)
        {
            this.tip = tip;
        }

        override public string ToString()
        {
            string admin = getId() + ", " + getIme() + ", " + getGodiste() + ", " + getTip();
            return admin;
        }
    }
}
