using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TVP_Projekat1
{
    public partial class Statistika : Form
    {
        List<Porudzbina> porudzbina;
        int jan, feb, mar, apr, maj, jun, jul, avg, sep, okt, nov, dec, brojac = 0;
        private void Velicina(object sender, EventArgs e)
        {
            Crtaj();
        }
        public Statistika()
        {
            InitializeComponent();
        }
        
        //Metoda kojom uzimamo Listu Porudzbina iz glavnog programa
        public void setPorudzbina(List<Porudzbina> porudzbina) => this.porudzbina = porudzbina;
        private void Statistika_Load(object sender, EventArgs e)
        {
            //Prolazimo kroz sve porudzbine i na osnovu toga kog su meseca bile napravljene upisujemo ih u int radi daljeg racunanja
            foreach (Porudzbina p in porudzbina)
            {
                brojac++;
                switch (p.getDate().Month)
                {
                    case 1:
                        jan++;
                        break;
                    case 2:
                        feb++;
                        break;
                    case 3:
                        mar++;
                        break;
                    case 4:
                        apr++;
                        break;
                    case 5:
                        maj++;
                        break;
                    case 6:
                        jun++;
                        break;
                    case 7:
                        jul++;
                        break;
                    case 8:
                        avg++;
                        break;
                    case 9:
                        sep++;
                        break;
                    case 10:
                        okt++;
                        break;
                    case 11:
                        nov++;
                        break;
                    case 12:
                        dec++;
                        break;
                    default:
                        break;
                }
            }
            Crtaj();
        }
        private void Crtaj()
        {
            //Ukoliko ima tacaka na crtezu brisemo ih
            charStatistika.Series[0].Points.Clear();

            //Upisivanje vrednosti na grafikon za vrednosti
            if(radVelicina.Checked == true)
            {
                for (int i = 1; i <= 12; i++)
                {
                    switch (i)
                    {
                        case 1:
                            charStatistika.Series[0].Points.AddXY(i, jan);
                            break;
                        case 2:
                            charStatistika.Series[0].Points.AddXY(i, feb);
                            break;
                        case 3:
                            charStatistika.Series[0].Points.AddXY(i, mar);
                            break;
                        case 4:
                            charStatistika.Series[0].Points.AddXY(i, apr);
                            break;
                        case 5:
                            charStatistika.Series[0].Points.AddXY(i, maj);
                            break;
                        case 6:
                            charStatistika.Series[0].Points.AddXY(i, jun);
                            break;
                        case 7:
                            charStatistika.Series[0].Points.AddXY(i, jul);
                            break;
                        case 8:
                            charStatistika.Series[0].Points.AddXY(i, avg);
                            break;
                        case 9:
                            charStatistika.Series[0].Points.AddXY(i, sep);
                            break;
                        case 10:
                            charStatistika.Series[0].Points.AddXY(i, okt);
                            break;
                        case 11:
                            charStatistika.Series[0].Points.AddXY(i, nov);
                            break;
                        case 12:
                            charStatistika.Series[0].Points.AddXY(i, dec);
                            break;
                    }
                }
            }

            //Upisivanje vrednosti na grafikon za procente            
            if (radProcent.Checked == true)
            {
                for (int i = 1; i <= 12; i++)
                {
                    switch (i)
                    {
                        case 1:
                            charStatistika.Series[0].Points.AddXY(i, jan * 100 / brojac);
                            break;
                        case 2:
                            charStatistika.Series[0].Points.AddXY(i, feb * 100 / brojac);
                            break;
                        case 3:
                            charStatistika.Series[0].Points.AddXY(i, mar * 100 / brojac);
                            break;
                        case 4:
                            charStatistika.Series[0].Points.AddXY(i, apr * 100 / brojac);
                            break;
                        case 5:
                            charStatistika.Series[0].Points.AddXY(i, maj * 100 / brojac);
                            break;
                        case 6:
                            charStatistika.Series[0].Points.AddXY(i, jun * 100 / brojac);
                            break;
                        case 7:
                            charStatistika.Series[0].Points.AddXY(i, jul * 100 / brojac);
                            break;
                        case 8:
                            charStatistika.Series[0].Points.AddXY(i, avg * 100 / brojac);
                            break;
                        case 9:
                            charStatistika.Series[0].Points.AddXY(i, sep * 100 / brojac);
                            break;
                        case 10:
                            charStatistika.Series[0].Points.AddXY(i, okt * 100 / brojac);
                            break;
                        case 11:
                            charStatistika.Series[0].Points.AddXY(i, nov * 100 / brojac);
                            break;
                        case 12:
                            charStatistika.Series[0].Points.AddXY(i, dec * 100 / brojac);
                            break;
                    }
                }
            }
        }
    }
}