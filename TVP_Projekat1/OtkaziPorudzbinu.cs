using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat1
{
    public partial class OtkaziPorudzbinu : Form
    {
        List<Porudzbina> porudzbina;
        Korisnik ulogovani;

        static string proizvodFile = "ListPorudzbina.txt";
        TextWriter twP;

        public OtkaziPorudzbinu()
        {
            InitializeComponent();
        }
        private void OtkaziPorudzbinu_Load(object sender, EventArgs e)
        {
            IspisiPorudzbine();
        }
        private void IspisiPorudzbine()
        {
            lstPorudzbine.Items.Clear();
            foreach(Porudzbina p in porudzbina)
            {                
                if(p.getKupac().ToString() == ulogovani.ToString())
                {
                    if (p.getKupac() is Administrator)
                    {
                        lstPorudzbine.Items.Add(p.getDate().ToString());
                    }
                    else
                    {
                        lstPorudzbine.Items.Add(p.getDate().ToString());
                    }
                }
            }
        }
        public void setPorudzbina(List<Porudzbina> porudzbina) => this.porudzbina = porudzbina;
        public void setKorisnik(Korisnik korisnik) => ulogovani = korisnik;
        private void IspisiDetalje(object sender, EventArgs e)
        {
            string ispis;
            Porudzbina p = porudzbina[lstPorudzbine.SelectedIndex];

            ispis = "ID:   " + p.getId().ToString() + Environment.NewLine;
            if (p.getKupac() is Administrator)
            {
                ispis += "Kupac:   " + ((Administrator)p.getKupac()).toString() + Environment.NewLine;
            }
            else
            {
                ispis += "Kupac:   " + ((RegistrovaniKupac)p.getKupac()).toString() + Environment.NewLine;
            }
            ispis += "Proizvodi: " + Environment.NewLine + Environment.NewLine;
            List<Proizvod> korisnikovProizvod = p.getProizvod();

            for(int i = 0; i < p.getProizvod().Count; i++)
            {
                Proizvod proizvod = p.getProizvod()[i];
                ispis += "ID proizvoda: " + proizvod.getId().ToString() + ", naziv: \"" + proizvod.getNaziv() + "\", cena: " + proizvod.getCena() + " rsd, kolicina: " + p.getKolicina()[i] + Environment.NewLine;
            }         

            lblDetalji.Text = ispis;

            btnOtkazi.Enabled = true;
        }        
        private void Otkazi(object sender, EventArgs e)
        {
            Porudzbina p = porudzbina[lstPorudzbine.SelectedIndex];

            if(MessageBox.Show("Da li ste sigurni da zelite da otkazete ovu porudzbinu?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                porudzbina.Remove(p);
                MessageBox.Show("Porudzbina otkazana!");

                UpisPorudzbina();
                lblDetalji.Text = String.Empty;
                IspisiPorudzbine();
            }
        }
        private void UpisPorudzbina()
        {
            try
            {
                twP = new StreamWriter(proizvodFile);
            }
            catch (Exception)
            {
                Console.WriteLine("Datoteke proizvoda vec otvorene");
            }

            foreach (Porudzbina p in porudzbina)
            {
                twP.WriteLine(p.toString());
            }

            twP.Close();
        }
    }
}
