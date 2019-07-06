using Gra_Kamien_Nozyce_Papier_.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gra_Kamien_Nozyce_Papier_
{
    public partial class Okno_Gra : Form
    {
        private bool isCollapsed;

        public Okno_Gra()
        {
            InitializeComponent();
        }
        

        public static string[] wyborGracza = { "Nożyce", "Kamień", "Papier" };
        public static Image[] wyborGraczaimg = { Resources.nozyce, Resources.kamien, Resources.papier };

        public static string[] wyborKomputera = { "Nożyce", "Kamień", "Papier" };
        public static Image[] wyborKomputeraimg = { Resources.nozyce, Resources.kamien, Resources.papier };

        public static string ruchGry = wyborKomputera[0];
        public static Image ruchGryimg = wyborKomputeraimg[0];

        public static string ruchGracza = wyborGracza[0];
        public static Image ruchGraczaimg = wyborGraczaimg[0];

        public static int pozycjaMenu = 0;

        public static int remisy = 0;
       
        public static int wygrane = 0;
        
        public static int przegrane = 0;
       
        public static int iloscGier = 0;
        
        public static int stanMeczu = 0;
               
        public static string statystyki = "";

        public static string wynik;

        public static void Odliczanie()
        {
            Image jeden = Resources._1;
            Image dwa = Resources._2;
            Image trzy = Resources._3;

            
            

        }
        public static void StanGry()

        {

            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Remis!";
                remisy++;
                iloscGier++;

            }
            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Wygrałeś!!!";
                wygrane++;
                
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Remis!";
                remisy++;
                
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Wygrałeś!!!";
                wygrane++;
                
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Remis!";
                remisy++;
               
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Wygrałeś!!!";
                wygrane++;
               
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                
                iloscGier++;
            }
        }
        private void Zapis()
        {
            string[] statystyka = { "Gracz: " + Okno_Ustawienia.nick, "", "Ilość gier: " + iloscGier, "",
                "Wygranych: " + wygrane, "", "Przegranych: " + przegrane, "",
                "Remisy: " + remisy };



            string sciezkaPliku = Okno_Ustawienia.sciezkaPliku;
            

            string nazwaPliku = "Gra Kamień-Nożyce-Papier-Statystyki.txt";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(sciezkaPliku, nazwaPliku)))
            {
                foreach (string linia in statystyka)
                    outputFile.WriteLine(linia);
                MessageBox.Show("Statystyka została zapisana w: " + sciezkaPliku);
            }

        }
        private void Okno_Gra_Load(object sender, EventArgs e)
        {

        }

        private void bStart(object sender, EventArgs e)
        {
            if (labelTwojWybor.Text != wyborGracza[0] && labelTwojWybor.Text != wyborGracza[1] && labelTwojWybor.Text != wyborGracza[2])
            {
                MessageBox.Show("Musisz wybrać symbol: NOŻYCE, KAMIŃ, PAPIER");
            }
            else
            {
                Random rand = new Random();

                switch (rand.Next(3))
                {
                    case 0:

                        labelWyborKomputera.Text = wyborKomputera[0];
                        label2.Image = wyborGraczaimg[0];

                        break;
                    case 1:
                        labelWyborKomputera.Text = wyborKomputera[1];
                        label2.Image = wyborGraczaimg[1];

                        break;
                    case 2:
                        labelWyborKomputera.Text = wyborKomputera[2];
                        label2.Image = wyborGraczaimg[2];

                        break;

                }

                
                ruchGracza = labelTwojWybor.Text;
                ruchGry = labelWyborKomputera.Text;
                StanGry();
                labWynik.Text = wynik;
                                
                labelWygraneGracza.Text = wygrane.ToString();
                labelWygraneKomputera.Text = przegrane.ToString();

                if (wygrane == stanMeczu)
                {
                    labelYouWin.Visible = true;
                    buttonStart.Visible = false;
                }
                if (przegrane == stanMeczu)
                {
                    labelGameOver.Visible = true;
                    buttonStart.Visible = false;
                }
            }

        }

        private void bKamien_Click(object sender, EventArgs e)
        {
            labelTwojWybor.Text = wyborGracza[1];
            label1.Image = wyborGraczaimg[1];
        }

        private void bNozyce_Click(object sender, EventArgs e)
        {
            labelTwojWybor.Text = wyborGracza[0];
            label1.Image = wyborGraczaimg[0];
        }

        private void bPapier_Click(object sender, EventArgs e)
        {
            labelTwojWybor.Text = wyborGracza[2];
            label1.Image = wyborGraczaimg[2];
        }

        private void labelWynik(object sender, EventArgs e)
        {

        }

        private void labTwojWybor(object sender, EventArgs e)
        {
            
        }

        private void bCzysc(object sender, EventArgs e)
        {
            labelTwojWybor.ResetText();
        }

        private void labPodpisWyborKomputera(object sender, EventArgs e)
        {

        }

        private void labPodpisTwojWybor(object sender, EventArgs e)
        {

        }

        private void bKoniec(object sender, EventArgs e)
        {
            this.Close();
            Okno_Ustawienia.nick = "";
            Okno_Ustawienia.sciezkaPliku = "";
            stanMeczu = 0;
            iloscGier = 0;
            przegrane = 0;
            wygrane = 0;
            remisy = 0;
            
        }

        private void bZapiszOknoGra(object sender, EventArgs e)
        {
            Zapis();
        }

        private void bStatystykaOknoGra(object sender, EventArgs e)
        {
            Okno_Statystyki okno_Statystyki = new Okno_Statystyki();
            okno_Statystyki.wyswietl_statystyke();
            okno_Statystyki.ShowDialog();
            //MessageBox.Show("Gracz: "+ Okno_Ustawienia.nick + "\n\nIlość gier: " + iloscGier + "\n\nWygranych: " + wygrane + "\n\nPrzegrane: " + przegrane + "\n\nRemisy: " + remisy);
        }

       

        

        private void panelSymbol(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                buttonSymbol.Image = Resources.up_arrow1;
                panelWyborSymbolu.Height += 10;
                if (panelWyborSymbolu.Size == panelWyborSymbolu.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                buttonSymbol.Image = Resources.angle_arrow_down;
                
                panelWyborSymbolu.Height -= 10;
                if (panelWyborSymbolu.Size == panelWyborSymbolu.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void bSymbol(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        

        private void labYouWin(object sender, EventArgs e)
        {
            
        }

        private void labGameOver(object sender, EventArgs e)
        {

        }

        private void labWygraneGracza(object sender, EventArgs e)
        {
            
        }

        private void labWygraneKomputera(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Nazwa_Gry_Click(object sender, EventArgs e)
        {

        }

        private void labWyborKomputera(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
               
               

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
