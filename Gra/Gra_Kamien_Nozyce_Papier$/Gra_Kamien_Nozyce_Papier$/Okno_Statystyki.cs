using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Kamien_Nozyce_Papier_
{
    
    public partial class Okno_Statystyki : Form 
    {

       
        public Okno_Statystyki()
        {
            InitializeComponent();
        }
        
        public void wyswietl_statystyke()
        {
            labelZasadyGry.Text = "Gracz: " + Okno_Ustawienia.nick + "\n\nIlość gier: " + Okno_Gra.iloscGier + "\n\nWygranych: " + Okno_Gra.wygrane + "\n\nPrzegrane: " + Okno_Gra.przegrane + "\n\nRemisy: " + Okno_Gra.remisy;
        }
        private void Nazwa_Gry_Click(object sender, EventArgs e)
        {

        }

        private void bPowrotStatystyka(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labStatystyla(object sender, EventArgs e)
        {
            
            
        }
    }
}
