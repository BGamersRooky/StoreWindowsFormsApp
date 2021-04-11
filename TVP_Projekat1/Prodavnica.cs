using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TVP_Projekat1
{
    public partial class Prodavnica : Form
    {
        static string file1 = "ListAdmin.txt";
        StreamReader AdminList;
        static string file2 = "ListKupac.txt";
        StreamReader KupacList;
        static string file3 = "ListProizvod.txt";
        StreamReader ProizvodList;
        static string file4 = "ListPorudzbina.txt";
        StreamReader PorudzbinaList;


        List<Administrator> admin = new List<Administrator>();
        List<RegistrovaniKupac> kupac = new List<RegistrovaniKupac>();
        List<Proizvod> proizvod = new List<Proizvod>();
        List<Porudzbina> porudzbina = new List<Porudzbina>();

        string ln;
        string[] input;
        int c, x = 0;
        bool chkLog = false;

        Korisnik korisnik;

        public Prodavnica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dokumentacija();
        }

        private void OpenDodajK(object sender, EventArgs e)
        {
            UpravljajKorisnicima f = new UpravljajKorisnicima();
            f.setAdmin(admin);
            f.setRegistrovani(kupac);
            f.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int logID = int.Parse(txtID.Text);
                String logIme = txtIme.Text;


                foreach (Administrator k in admin)
                {
                    Console.WriteLine(k.getIme() + " " + k.getTip());
                    if (k.getId() == logID && k.getIme() == logIme)
                    {
                        korisnik = k;
                        Console.WriteLine("Uspesno ste se ulogovali kao: " + k.toString());
                        btnKorisnici.Enabled = true;
                        btnOtkazi.Enabled = true;
                        btnPoruci.Enabled = true;
                        btnProizvod.Enabled = true;
                        btnStatistika.Enabled = true;

                        lblStatus.Text = "Zdravo, " + k.getIme() + "\nStatus: Admin";
                        chkLog = true;
                        break;
                    }
                }
                foreach (RegistrovaniKupac k in kupac)
                {
                    Console.WriteLine(k.getIme() + " " + k.getTip());
                    if (k.getId() == logID && k.getIme() == logIme)
                    {
                        korisnik = k;
                        Console.WriteLine("Uspesno ste se ulogovali kao: " + k.ToString());
                        btnOtkazi.Enabled = true;
                        btnPoruci.Enabled = true;

                        lblStatus.Text = "Zdravo, " + k.getIme() + "\nStatus: Kupac";
                        chkLog = true;
                        break;
                    }
                }

                if (!chkLog)
                {
                    lblStatus.Text = "Neuspesno logovanje, molimo vas pokusajte ponovo!";
                }
                else
                {
                    btnLogin.Enabled = false;
                    btnLogout.Enabled = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID mora biti celobrojni broj bez specijalnih karaktera ili slova!");
            }
        }

        private void OtvoriUpravljanjeProizvodima(object sender, EventArgs e)
        {
            UpravljajProizvodima f = new UpravljajProizvodima();
            f.setProizvod(proizvod);
            f.ShowDialog();
        }

        private void LogOut(object sender, EventArgs e)
        {
            if (chkLog)
            {
                btnKorisnici.Enabled = false;
                btnOtkazi.Enabled = false;
                btnPoruci.Enabled = false;
                btnProizvod.Enabled = false;
                btnStatistika.Enabled = false;

                btnLogin.Enabled = true;
                btnLogout.Enabled = false;

                lblStatus.Text = String.Empty;

                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void PoruciProizvod(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            KupiProizvod f = new KupiProizvod();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.setProizvod(proizvod);
            f.setKorisnik(korisnik);
            f.setPorudzbina(porudzbina);
            f.Show();
        }

        private void OtkazitePorudzbinu(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            OtkaziPorudzbinu f = new OtkaziPorudzbinu();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.setPorudzbina(porudzbina);
            f.setKorisnik(korisnik);
            f.Show();
        }

        private void Statistika(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Statistika f = new Statistika();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.setPorudzbina(porudzbina);
            f.Show();
        }

        private void Dokumentacija()
        {
            try
            {
                AdminList = new StreamReader(file1);
                KupacList = new StreamReader(file2);
                ProizvodList = new StreamReader(file3);
                PorudzbinaList = new StreamReader(file4);
            }
            catch (Exception) { }

            //Ucitavanje Administratora
            while ((ln = AdminList.ReadLine()) != null)
            {
                Console.WriteLine("Citam Administratore...");
                c++;
                try
                {
                    if(input != null)
                    {
                        Array.Clear(input, 0, input.Length);
                    }
                }
                catch (Exception) { }
                input = ln.Split(new string[] { ", " }, StringSplitOptions.None);

                try
                {
                    Console.WriteLine(input[0] + " " + input[2]);

                    if (int.Parse(input[0]) > 0 && (int.Parse(input[2]) > 1900 && int.Parse(input[2]) < DateTime.Now.Year))
                    {
                        Console.WriteLine(int.Parse(input[0]) + " " + input[1] + " " + int.Parse(input[2]));
                        admin.Add(new Administrator(int.Parse(input[0]), input[1], int.Parse(input[2])));
                        x++;
                        Console.WriteLine("Uspesno upisano! " + c);
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", nisu svi podaci upisani!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", Godina nije u korektnom formatu!");
                }
            }
            Console.WriteLine("Zavreseno ucitavanje Admina!");
            AdminList.Close();
            c = 0;

            //Ucitavanje Kupaca
            while ((ln = KupacList.ReadLine()) != null)
            {
                Console.WriteLine("Citam Kupce...");
                c++;
                try
                {
                    Array.Clear(input, 0, input.Length);
                }
                catch (Exception) { }
                input = ln.Split(new string[] { ", " }, StringSplitOptions.None);

                try
                {
                    Console.WriteLine(input[0] + " " + input[2]);

                    if (int.Parse(input[0]) > 0 && (int.Parse(input[2]) > 1900 && int.Parse(input[2]) < DateTime.Now.Year))
                    {
                        kupac.Add(new RegistrovaniKupac(int.Parse(input[0]), input[1], int.Parse(input[2])));
                        x++;
                        Console.WriteLine("Uspesno upisano! " + c);
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", nisu svi podaci upisani!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", Godina nije u korektnom formatu!");
                }

            }
            Console.WriteLine("Zavreseno ucitavanje Kupaca!");
            KupacList.Close();
            c = 0;

            //Ucitavanje Proizvoda
            while ((ln = ProizvodList.ReadLine()) != null)
            {
                Console.WriteLine("Citam proizvode... ");
                c++;
                try
                {
                    Array.Clear(input, 0, input.Length);
                }
                catch (Exception) { }
                input = ln.Split(new string[] { ", " }, StringSplitOptions.None);

                try
                {
                    if (int.Parse(input[0]) > 0 && double.Parse(input[2]) > 0 && input[1] != String.Empty)
                    {
                        proizvod.Add(new Proizvod(int.Parse(input[0]), input[1], double.Parse(input[2])));
                        x++;
                        Console.WriteLine("Uspesno upisano! " + c);
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", nisu svi podaci upisani!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Greska u liniji: " + c + ", Godina nije u korektnom formatu!");
                }

            }
            Console.WriteLine("Zavreseno ucitavanje Proizvoda!");
            ProizvodList.Close();
            c = 0;

            //Ucitavanje Porudzbina
            while ((ln = PorudzbinaList.ReadLine()) != null)
            {
                Console.WriteLine("Citam porudzbine... ");
                c++;
                try
                {
                    Array.Clear(input, 0, input.Length);
                }
                catch (Exception) { }

                try
                {
                    input = ln.Split(new string[] { "}, {" }, StringSplitOptions.None);

                    int id = int.Parse(input[0].Substring(1));

                    string[] kupac = input[1].Split(new string[] { ", " }, StringSplitOptions.None);

                    Administrator SpremanKupacA = new Administrator(1, "", 1);
                    RegistrovaniKupac SpremanKupacK = new RegistrovaniKupac(1, "", 1);

                    bool chk = false;
                    if (kupac[3] == "Admin")
                    {
                        SpremanKupacA = new Administrator(int.Parse(kupac[0]), kupac[1], int.Parse(kupac[2]));
                        Console.WriteLine(SpremanKupacA.toString());
                        chk = true;
                    }
                    else
                    {
                        SpremanKupacK = new RegistrovaniKupac(int.Parse(kupac[0]), kupac[1], int.Parse(kupac[2]));
                    }


                    string proizvodi = input[2].Substring(1);
                    proizvodi = proizvodi.Remove(proizvodi.Length - 1);
                    string[] proizvodi2 = proizvodi.Split(new string[] { "}{" }, StringSplitOptions.None);
                    List<Proizvod> SpremniProizvodi = new List<Proizvod>();
                    foreach (string s in proizvodi2)
                    {
                        string[] proizvodi3 = s.Split(new string[] { ", " }, StringSplitOptions.None);
                        SpremniProizvodi.Add(new Proizvod(int.Parse(proizvodi3[0]), proizvodi3[1], double.Parse(proizvodi3[2])));
                    }

                    string kolicina = input[3].Substring(1);
                    kolicina = kolicina.Remove(kolicina.Length - 1);
                    string[] kolicina2 = kolicina.Split(new string[] { "}{" }, StringSplitOptions.None);
                    List<int> SpremnaKolicina = new List<int>();
                    foreach (string s in kolicina2)
                    {
                        SpremnaKolicina.Add(int.Parse(s));
                    }

                    string datum = input[4];
                    datum = datum.Remove(datum.Length - 1);
                    DateTime SpremanDatum = Convert.ToDateTime(datum);


                    try
                    {
                        if (id > 0 && chk)
                        {
                            porudzbina.Add(new Porudzbina(id, SpremanKupacA, SpremniProizvodi, SpremnaKolicina, SpremanDatum));
                            x++;
                            Console.WriteLine("Uspesno upisano! " + c);
                        }
                        else if (id > 0 && !chk)
                        {
                            porudzbina.Add(new Porudzbina(id, SpremanKupacK, SpremniProizvodi, SpremnaKolicina, SpremanDatum));
                            x++;
                            Console.WriteLine("Uspesno upisano! " + c);

                        }
                    }
                    catch (Exception) { }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            Console.WriteLine("Zavreseno ucitavanje Porudzbina!");
            PorudzbinaList.Close();
        }
    }
}
