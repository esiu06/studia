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
    
    public partial class Okno_Ustawienia : Form
    {
        
        public static string nick = "";
        public static string sciezkaPliku = "";
        public Okno_Ustawienia()
        {
            InitializeComponent();
        }

        private void bPowrot(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nazwa_Gry_Click(object sender, EventArgs e)
        {

        }

        private void textBobPodajSwojNick(object sender, EventArgs e)
        {
            nick = textBoxPodajSwojNick.Text;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        
        public void ChooseFolder()
            
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSciezka.Text = folderBrowserDialog1.SelectedPath;
               
            }
        }

        private void bWyborSciezkiZapisu(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void textBoxSciezkaZapisu(object sender, EventArgs e)
        {
                sciezkaPliku = textBoxSciezka.Text;
        }

        private void trackBarUstawIloscGierWygranych(object sender, EventArgs e)
        {
            labellabWyboruIloscGier.Text = trackBarIloscGierWygranych.Value.ToString();
            Okno_Gra.stanMeczu = int.Parse(labellabWyboruIloscGier.Text);
            
        }

        private void labWyboruIloscGier(object sender, EventArgs e)
        {
            
        }

        private void labPodajSwojNick(object sender, EventArgs e)
        {

        }

        private void labPodajSciezkeZapisu(object sender, EventArgs e)
        {

        }

        private void labUstawIloscGierWygranych(object sender, EventArgs e)
        {

        }

        private void Okno_Ustawienia_Load(object sender, EventArgs e)
        {

        }
    }
}
