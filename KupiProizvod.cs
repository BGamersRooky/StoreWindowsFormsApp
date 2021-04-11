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
    public partial class KupiProizvod : Form
    {
        List<Proizvod> proizvod;
        List<Porudzbina> porudzbina;

        Korisnik korisnik;

        static string proizvodFile = "ListPorudzbina.txt";
        TextWriter twP;


        public KupiProizvod()
        {
            InitializeComponent();
        }

        private void KupiProizvod_Load(object sender, EventArgs e)
        {
            ispisiProizvode();
        }

        public void ispisiProizvode()
        {
            foreach (Proizvod p in proizvod)
            {
                lstProizvodi.Items.Add(p.getId() + " " +p.getNaziv() + " - " + p.getCena() + " rsd");
            }
        }

        public void setProizvod(List<Proizvod> proizvod) => this.proizvod = proizvod;

        public void setKorisnik(Korisnik korisnik) => this.korisnik = korisnik;

        public void setPorudzbina(List<Porudzbina> porudzbina) => this.porudzbina = porudzbina;

        private void DodajKorpa(object sender, EventArgs e)
        {
            bool chk = true;
            string odabrani = lstProizvodi.SelectedItem.ToString();
            if (lstKorpa.Items.Count == 0)
            {
                lstKorpa.Items.Add(odabrani + " * " + nudKolicina.Value);
            }
            else
            {
                for (int i = 0; i < lstKorpa.Items.Count; i++)
                {
                    try
                    {
                        if (lstKorpa.Items[i].ToString().Contains(lstProizvodi.SelectedItem.ToString()))
                        {
                            string item = lstKorpa.Items[i].ToString();
                            try
                            {
                                int trenutnaKolicina = int.Parse(item.Substring(item.Length - 1));
                                int novaKolicina = trenutnaKolicina + Convert.ToInt32(nudKolicina.Value);

                                item = item.Remove(item.Length - 1, 1) + novaKolicina;

                                lstKorpa.Items[i] = item;

                                chk = false;
                                break;
                            }
                            catch (Exception) { }
                        }
                    }
                    catch (Exception) { }
                }
                if (chk)
                {
                    lstKorpa.Items.Add(odabrani + " * " + nudKolicina.Value);
                }
            }

            Racun();
        }

        private void UkloniKorpa(object sender, EventArgs e)
        {
            lstKorpa.Items.Remove(lstKorpa.SelectedItem);
            Racun();
        }

        private void PromeniKolicinu(object sender, EventArgs e)
        {
            if (lstKorpa.SelectedItem != null)
            {
                string[] item;
                item = lstKorpa.SelectedItem.ToString().Split(new string[]{" * "}, StringSplitOptions.None);
                int indeks = lstKorpa.SelectedIndex;
                try
                {
                    lstKorpa.Items[indeks] = item[0] + " * " + nudKolicina.Value;
                }
                catch (Exception) { }
            }
            Racun();
        }

        private void Promena(object sender, EventArgs e)
        {
            if(sender == lstKorpa)
            {
                lstProizvodi.SelectedItem = null;
                return;
            }

            if(sender == lstProizvodi)
            {
                lstKorpa.SelectedItem = null;
                return;
            }
        }

        private void Kupi(object sender, EventArgs e)
        {
            List<Proizvod> korpa = new List<Proizvod>();
            List<int> kolicine = new List<int>();

            for (int i = 0; i < lstKorpa.Items.Count; i++)
            {
                string p = lstKorpa.Items[i].ToString();
                int stani = p.IndexOf(" ");
                if(stani > 0)
                {
                    Console.WriteLine(p.Substring(0, stani));
                    for (int j = 0; j < proizvod.Count; j++)
                    {
                        if(proizvod[j].getId() == int.Parse(p.Substring(0, stani)))
                        {
                            korpa.Add(proizvod[j]);
                            break;
                        }
                    }
                }

                stani = p.IndexOf("*");
                if (stani > 0)
                {
                    try
                    {
                        kolicine.Add(int.Parse(p.Substring(stani + 1)));
                    }
                    catch (Exception) { }
                }
            }


            int brPorudzbine = 1;
            bool pass;

            while (brPorudzbine <= porudzbina.Count)
            {
                pass = false;
                foreach (Porudzbina p in porudzbina)
                {
                    if (p.getId() == brPorudzbine)
                    {
                        brPorudzbine++;
                        pass = true;
                        break;
                    }
                }
                if (!pass)
                {
                    break;
                }
            }

            if (korisnik is Administrator)
            {
                Console.WriteLine("Korisnik je administrator!");
                porudzbina.Add(new Porudzbina(brPorudzbine, new Administrator(korisnik), korpa, kolicine));
                MessageBox.Show("Porudzbina uspela! ID porudzbine je: " + brPorudzbine
                                 + "\nKorisnik: " + korisnik.toString());
            }
            if (korisnik is RegistrovaniKupac)
            {
                Console.WriteLine("Korisnik je kupac!");
                porudzbina.Add(new Porudzbina(brPorudzbine, new RegistrovaniKupac(korisnik), korpa, kolicine));
                MessageBox.Show("Porudzbina uspela! ID porudzbine je: " + brPorudzbine
                                 + "\nKorisnik: " + korisnik.toString());
            }

            lstKorpa.Items.Clear();
            lblRacun.Text = String.Empty;

            UpisPorudzbina();
        }

        private void Racun()
        {
            double total = 0;
            int pocetak, kraj;

            foreach(string s in lstKorpa.Items)
            {
                pocetak = s.IndexOf(" - ") + 3;
                kraj = s.IndexOf(" rsd");
                total += double.Parse(s.Substring(pocetak, kraj - pocetak)) * int.Parse(s.Substring(kraj + 7));
            }

            lblRacun.Text = "Racun:\n" + total.ToString() + " rsd";
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
