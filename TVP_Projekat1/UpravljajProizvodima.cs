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
    public partial class UpravljajProizvodima : Form
    {
        List<Proizvod> proizvod;

        static string proizvodFile = "ListProizvod.txt";
        TextWriter twP;


        string imeP;
        double cenaP;

        bool chkIzmena = false;
        int izmenjeni;

        public UpravljajProizvodima()
        {
            InitializeComponent();
        }

        private void DodajProizvod(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Dodajem proizvod...");
                imeP = txtImeP.Text;
                cenaP = double.Parse(txtCenaP.Text);

                if (cenaP > 0 && imeP != String.Empty)
                {
                    int brProizvoda = 1;
                    bool pass;

                    while (brProizvoda <= proizvod.Count)
                    {
                        pass = false;
                        foreach (Proizvod p in proizvod)
                        {
                            if (p.getId() == brProizvoda)
                            {
                                brProizvoda++;
                                pass = true;
                                break;
                            }
                        }
                        if (!pass)
                        {
                            break;
                        }
                    }

                    proizvod.Add(new Proizvod(brProizvoda, imeP, cenaP));
                    MessageBox.Show("Uspesno ste dodali novi proizvod, " + imeP + ", " + cenaP + " rsd" + "\nID proizvoda je: " + brProizvoda);


                }
                else
                {
                    MessageBox.Show("Morate upisati ime proizvoda!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }

            txtCenaP.Text = String.Empty;
            txtImeP.Text = String.Empty;

            UpisProizvoda();
            IspisProizvoda();
        }

        private void ObrisiProizvod(object sender, EventArgs e)
        {
            bool chk = true;
            try
            {
                foreach (Proizvod p in proizvod)
                {
                    if (txtImeP.Text == p.getNaziv() && double.Parse(txtCenaP.Text) == p.getCena())
                    {
                        if (MessageBox.Show("Jeste li sigurni da zelite da uklonite proizvod ID " + p.getId() + " - " + p.getNaziv() + " iz liste proizvoda?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            proizvod.Remove(p);
                            MessageBox.Show("Obrisan!");
                            chk = false;
                            break;
                        }
                    }
                }
                if (chk)
                {
                    MessageBox.Show("Proizvod kojeg ste odabrali ne postoji u bazi podataka!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }
            txtCenaP.Text = String.Empty;
            txtImeP.Text = String.Empty;

            UpisProizvoda();
            IspisProizvoda();
        }

        private void IzmeniProizvod(object sender, EventArgs e)
        {
            try
            {
                if (!chkIzmena)
                {
                    imeP = txtImeP.Text;
                    cenaP = double.Parse(txtCenaP.Text);

                    foreach (Proizvod p in proizvod)
                    {
                        if (chkIzmena)
                        {
                            break;
                        }
                        if (p.getNaziv() == imeP && p.getCena() == cenaP)
                        {
                            lblIzmena.Text = "Izmena predmeta: " + p.getNaziv() + " ID: " + p.getId();
                            MessageBox.Show("Da bi ste promenili informacije unesite informacije koje zelite da se promene u polja dole i kliknite opet na \"Izmeni\""
                                + "\nUkoliko zelite da podatak ostane ne promenjen ostavite polje prazno");

                            btnDodaj.Enabled = false;
                            btnObrisi.Enabled = false;

                            izmenjeni = p.getId();
                            chkIzmena = true;

                            txtCenaP.Text = String.Empty;
                            txtImeP.Text = String.Empty;
                            UpisProizvoda();

                            return;
                        }
                    }
                    if (!chkIzmena) //Ukoliko prodje oba for loopa i ne nadje nista izbacuje poruku o gresci
                    {
                        MessageBox.Show("Proizvod koji zelite da izmenite ne posotji!");
                        UpisProizvoda();

                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }

            if (chkIzmena)
            {
                foreach (Proizvod p in proizvod)
                {
                    if (!chkIzmena)
                    {
                        break;
                    }
                    if (p.getId() == izmenjeni)
                    {
                        string poruka = "Izmenjeni parametri su:";

                        if (txtImeP.Text != String.Empty)
                        {
                            Console.WriteLine("Menjam naziv predmeta...");
                            p.setNaziv(txtImeP.Text);
                            poruka += "\nNaziv predmeta promenjen u " + txtImeP.Text;
                        }
                        if (txtCenaP.Text != String.Empty)//Menja godiste korisnika ako polje nije prazno
                        {
                            try
                            {
                                Console.WriteLine("Menjam cenu...");
                                p.setCena(double.Parse(txtCenaP.Text));
                                poruka += "\nCena promenjena u " + txtCenaP.Text;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Cena koju ste uneli je neispravna - ovaj parametar nije izmenjen!");
                            }
                        }
                        chkIzmena = false;

                        MessageBox.Show(poruka);
                        UpisProizvoda();

                        IspisProizvoda();

                        btnDodaj.Enabled = true;
                        btnObrisi.Enabled = true;                        

                        txtCenaP.Text = String.Empty;
                        txtImeP.Text = String.Empty;

                        lblIzmena.Text = String.Empty;

                        return;

                    }
                }
            }
        }

        private void UgasiProizvod(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpisProizvoda()
        {
            try
            {
                twP = new StreamWriter(proizvodFile);
            }
            catch (Exception)
            {
                Console.WriteLine("Datoteke proizvoda vec otvorene");
            }

            foreach (Proizvod p in proizvod)
            {
                twP.WriteLine(p.toString());
            }

            twP.Close();
        }

        public void setProizvod(List<Proizvod> proizvod)
        {
            this.proizvod = proizvod;
        }

        private void UcitavanjeStrane(object sender, EventArgs e)
        {
            IspisProizvoda();
        }

        private void IspisProizvoda()
        {
            txtProizvodi.Text = String.Empty;
            foreach (Proizvod p in proizvod)
            {
                txtProizvodi.Text += p.toString() + "\r\n";
            }

        }
    }
}
