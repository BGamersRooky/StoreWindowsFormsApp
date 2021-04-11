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
    public partial class UpravljajKorisnicima : Form
    {
        ToolTip tip = new ToolTip();
        string text = "Ovo polje se koristi samo kod dodavanja novog clana ili kod izmene postojeceg, nije bitno kod brisanja clanova";

        List<Administrator> admin;
        List<RegistrovaniKupac> kupac;

        string ime;
        int godiste;

        static string adminFile = "ListAdmin.txt";
        TextWriter twA;
        static string kupacFile = "ListKupac.txt";
        TextWriter twK;

        int izmenjeni;
        bool chk = false;

        public UpravljajKorisnicima()
        {
            InitializeComponent();
        }
        private void DodajNovogKorisnika(object sender, EventArgs e)
        {
            try
            {
                ime = txtNewIme.Text;
                godiste = int.Parse(txtNewGodiste.Text);

                if (godiste > 1900 && godiste < DateTime.Now.Year && ime != String.Empty)
                {
                    int brKorisnika = 1;
                    bool pass;
                    while (brKorisnika <= (admin.Count + kupac.Count))
                    {
                        pass = false;
                        foreach (Administrator a in admin)
                        {
                            if (a.getId() == brKorisnika)
                            {
                                brKorisnika++;
                                pass = true;
                                break;
                            }
                        }
                        if (!pass)
                        {
                            foreach (RegistrovaniKupac k in kupac)
                            {
                                if (k.getId() == brKorisnika)
                                {
                                    brKorisnika++;
                                    pass = true;
                                    break;
                                }
                            }
                        }
                        if (!pass)
                        {
                            break;
                        }
                    }

                    if (chkAdmin.Checked)
                    {
                        admin.Add(new Administrator(brKorisnika, ime, godiste));
                        MessageBox.Show("Uspesno ste dodali novog administratora, " + ime + ", " + godiste + "\nVas ID za logovanje je : " + (brKorisnika));
                    }
                    else
                    {
                        kupac.Add(new RegistrovaniKupac(brKorisnika, ime, godiste));
                        MessageBox.Show("Uspesno ste dodali novog kupca, " + ime + ", " + godiste + "\nVas ID za logovanje je : " + (brKorisnika));
                    }


                    txtNewGodiste.Text = String.Empty;
                    txtNewIme.Text = String.Empty;
                    chkAdmin.Checked = false;
                }
                else
                {
                    MessageBox.Show("Molimo vas proverite godinu rodjenja!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }

            UpisDatoteke();
        }

        public void setAdmin(List<Administrator> admin)
        {
            this.admin = admin;
        }

        private void Otkazi(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setRegistrovani(List<RegistrovaniKupac> kupac)
        {
            this.kupac = kupac;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool chk = false;

            try
            {
                ime = txtNewIme.Text;
                godiste = int.Parse(txtNewGodiste.Text);

                foreach (Administrator a in admin)
                {
                    if (a.getGodiste() == godiste && a.getIme() == ime)
                    {
                        if (MessageBox.Show("Jeste li sigurni da zelite da uklonite administratora " + a.getIme() + " iz liste korisnika?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            admin.Remove(a);
                            MessageBox.Show("Obrisan!");

                            txtNewGodiste.Text = String.Empty;
                            txtNewIme.Text = String.Empty;
                            chkAdmin.Checked = false;

                            chk = true;
                            break;
                        }
                    }
                }
                if (!chk)
                {
                    foreach (RegistrovaniKupac k in kupac)
                    {
                        Console.WriteLine("Trazim korisnika u kupcima...");
                        if (k.getGodiste() == godiste && k.getIme() == ime)
                        {
                            if (MessageBox.Show("Jeste li sigurni da zelite da uklonite administratora " + k.getIme() + " iz liste korisnika?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                kupac.Remove(k);
                                MessageBox.Show("Obrisan!");

                                txtNewGodiste.Text = String.Empty;
                                txtNewIme.Text = String.Empty;
                                chkAdmin.Checked = false;

                                chk = true;
                                break;
                            }
                        }
                    }

                }

                if (!chk)
                {
                    MessageBox.Show("Korisnik kojeg ste odabrali ne postoji u bazi podataka!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }

            UpisDatoteke();
        }

        private void UpisDatoteke()
        {

            try
            {
                twA = new StreamWriter(adminFile);
                twK = new StreamWriter(kupacFile);
            }
            catch (Exception)
            {
                Console.WriteLine("Datoteke vec otvorene");
            }

            foreach (Administrator a in admin)
            {
                twA.WriteLine(a.toString());
            }
            foreach (RegistrovaniKupac k in kupac)
            {
                twK.WriteLine(k.toString());
            }


            twK.Close();
            twA.Close();

        }

        private void KorisnikIzmeni(object sender, EventArgs e)
        {
            bool inner = true;

            try //Ukoliko podaci nisu dobro upisani salje poruku
            {
                if (!chk) // Proverava da li je prvi ili drugi klik na dugme (pokrece opciju za prvi klik)
                {
                    ime = txtNewIme.Text;
                    godiste = int.Parse(txtNewGodiste.Text);

                    foreach (Administrator a in admin)
                    {
                        if (chk) //Ukoliko nadje korinsika izlazi iz loopa
                        {
                            break;
                        }
                        if (inner) //Ako trazeni Korisnik nije u listi kupac preskace for loop
                        {
                            foreach (RegistrovaniKupac k in kupac)
                            {
                                if (k.getGodiste() == godiste && k.getIme() == ime) //Ako nadje kupca trazi da se izmene podaci
                                {
                                    lblIzmena.Text = "Menjate korisnika: " + k.getIme() + " ID: " + k.getId();
                                    MessageBox.Show("Da bi ste promenili informacije unesite informacije koje zelite da se promene u polja dole i kliknite opet na \"Izmeni\""
                                        + "\nUkoliko zelite da podatak ostane ne promenjen ostavite polje prazno");

                                    btnDodaj.Enabled = false;
                                    btnObrisi.Enabled = false;

                                    izmenjeni = k.getId();
                                    chk = true;

                                    txtNewGodiste.Text = String.Empty;
                                    txtNewIme.Text = String.Empty;
                                    chkAdmin.Checked = false;
                                    UpisDatoteke();

                                    return;
                                }
                                else
                                {
                                    inner = false;
                                }
                            }
                        }
                        if (a.getGodiste() == godiste && a.getIme() == ime) //Ako nadje admina trazi da se izmene podaci
                        {
                            lblIzmena.Text = "Menjate korisnika: " + a.getIme() + " ID: " + a.getId();
                            MessageBox.Show("Da bi ste promenili informacije unesite informacije koje zelite da se promene u polja dole i kliknite opet na \"Izmeni\""
                                + "\nUkoliko zelite da podatak ostane ne promenjen ostavite polje prazno");

                            btnDodaj.Enabled = false;
                            btnObrisi.Enabled = false;

                            izmenjeni = a.getId();
                            chk = true;

                            txtNewGodiste.Text = String.Empty;
                            txtNewIme.Text = String.Empty;
                            chkAdmin.Checked = false;
                            UpisDatoteke();

                            return;
                        }
                    }
                    if (!chk) //Ukoliko prodje oba for loopa i ne nadje nista izbacuje poruku o gresci
                    {
                        MessageBox.Show("Korisnik kojeg zelite da izmenite ne posotji!");
                        UpisDatoteke();

                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneti podaci nisu pravilno upisani!");
            }

            if (chk) //Proverava da li je prvi ili drugi klik na dugme (pokrece opciju za drugi klik)
            {
                foreach (Administrator a in admin)
                {
                    if (!chk) //Ukoliko nadje korinsika izlazi iz loopa
                    {
                        break;
                    }
                    if (inner) //Ako trazeni Korisnik nije u listi kupac preskace for loop
                    {
                        foreach (RegistrovaniKupac k in kupac)
                        {
                            if (k.getId() == izmenjeni)//Trazi u listi korisnika kojeg zelimo da izmenimo
                            {
                                string poruka = "Promenjeni parametri su: ";
                                if (txtNewIme.Text != String.Empty)//Menja ime korisnika ako polje nije ostavljeno prazno
                                {
                                    Console.WriteLine("Menjam ime...");
                                    k.setIme(txtNewIme.Text);
                                    poruka += "\nIme promenjeno u " + txtNewIme.Text;
                                }
                                if (txtNewGodiste.Text != String.Empty)//Menja godiste korisnika ako polje nije prazno
                                {
                                    try
                                    {
                                        Console.WriteLine("Menjam godine...");
                                        k.setGodiste(int.Parse(txtNewGodiste.Text));
                                        poruka += "\nGodiste promenjeno u " + txtNewGodiste.Text;
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Broj godina koji ste unali je neispravan - ovaj parametar nije izmenjen!");
                                    }
                                }
                                if (chkAdmin.Checked == true)//Ako je admin dugme cekirano pretvara kupca u administratora
                                {
                                    Console.WriteLine("Menjam tip...");
                                    RegistrovaniKupac temp = k;
                                    string[] tempString = k.ToString().Split(new string[] { ", " }, StringSplitOptions.None);

                                    kupac.Remove(k);
                                    admin.Add(new Administrator(int.Parse(tempString[0]), tempString[1], int.Parse(tempString[2])));

                                    poruka += "Tipa naloga pretvoren u Administratora";
                                }
                                chk = false;

                                MessageBox.Show(poruka);
                                UpisDatoteke();

                                btnDodaj.Enabled = true;
                                btnObrisi.Enabled = true;


                                txtNewGodiste.Text = String.Empty;
                                txtNewIme.Text = String.Empty;
                                chkAdmin.Checked = false;

                                lblIzmena.Text = String.Empty;

                                return;
                            }

                            if (chk)
                            {
                                inner = false;
                            }
                        }
                    }

                    if (a.getId() == izmenjeni)//Trazi u listi administratora kojeg zelimo da izmenimo
                    {
                        string poruka = "Promenjeni parametri su: ";

                        if (txtNewIme.Text != String.Empty)//Menja ime korisnika ako polje nije ostavljeno prazno
                        {
                            Console.WriteLine("Menjam ime...");
                            a.setIme(txtNewIme.Text);
                            poruka += "\nIme promenjeno u " + txtNewIme.Text;
                        }
                        if (txtNewGodiste.Text != String.Empty)//Menja godiste korisnika ako polje nije prazno
                        {
                            try
                            {
                                Console.WriteLine("Menjam godiste...");
                                a.setGodiste(int.Parse(txtNewGodiste.Text));
                                poruka += "\nGodiste promenjeno u " + txtNewGodiste.Text;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Broj godina koji ste uneli je neispravan - ovaj parametar nije izmenjen!");
                            }
                        }
                        if (chkAdmin.Checked == false)//Ako je admin dugme ne cekirano pretvara administratora u kupca
                        {
                            Console.WriteLine("Menjam tip...");

                            Administrator temp = a;
                            string[] tempString = a.toString().Split(new string[] { ", " }, StringSplitOptions.None);

                            admin.Remove(a);
                            kupac.Add(new RegistrovaniKupac(int.Parse(tempString[0]), tempString[1], int.Parse(tempString[2])));

                            poruka += "Tipa naloga pretvoren u Kupca";
                        }

                        chk = false;

                        MessageBox.Show(poruka);
                        UpisDatoteke();

                        btnDodaj.Enabled = true;
                        btnObrisi.Enabled = true;


                        txtNewGodiste.Text = String.Empty;
                        txtNewIme.Text = String.Empty;
                        chkAdmin.Checked = false;

                        lblIzmena.Text = String.Empty;

                        return;
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminTooltip(object sender, EventArgs e)
        {
            tip.Show(text, label3);
            UpisDatoteke();
        }

        private void Load(object sender, EventArgs e)
        {
        }
    }
}
