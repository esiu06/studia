namespace Gra_Kamien_Nozyce_Papier_
{
    partial class Okno_Ustawienia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno_Ustawienia));
            this.Nazwa_Gry = new System.Windows.Forms.Label();
            this.buttonPowrotUstawienia = new System.Windows.Forms.Button();
            this.labelPodajSwojNick = new System.Windows.Forms.Label();
            this.textBoxPodajSwojNick = new System.Windows.Forms.TextBox();
            this.textBoxSciezka = new System.Windows.Forms.TextBox();
            this.labelPodajSciezkeZapisu = new System.Windows.Forms.Label();
            this.buttonWyborSciezki = new System.Windows.Forms.Button();
            this.trackBarIloscGierWygranych = new System.Windows.Forms.TrackBar();
            this.labellabWyboruIloscGier = new System.Windows.Forms.Label();
            this.labelIloscGierWygranych = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIloscGierWygranych)).BeginInit();
            this.SuspendLayout();
            // 
            // Nazwa_Gry
            // 
            this.Nazwa_Gry.AutoSize = true;
            this.Nazwa_Gry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Nazwa_Gry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nazwa_Gry.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nazwa_Gry.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwa_Gry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Nazwa_Gry.Location = new System.Drawing.Point(45, 34);
            this.Nazwa_Gry.MinimumSize = new System.Drawing.Size(520, 70);
            this.Nazwa_Gry.Name = "Nazwa_Gry";
            this.Nazwa_Gry.Padding = new System.Windows.Forms.Padding(6);
            this.Nazwa_Gry.Size = new System.Drawing.Size(537, 70);
            this.Nazwa_Gry.TabIndex = 2;
            this.Nazwa_Gry.Text = "GRA KAMIEŃ - NOŻYCE - PAPIER";
            this.Nazwa_Gry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nazwa_Gry.Click += new System.EventHandler(this.Nazwa_Gry_Click);
            // 
            // buttonPowrotUstawienia
            // 
            this.buttonPowrotUstawienia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPowrotUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPowrotUstawienia.FlatAppearance.BorderSize = 2;
            this.buttonPowrotUstawienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrotUstawienia.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrotUstawienia.ForeColor = System.Drawing.Color.Salmon;
            this.buttonPowrotUstawienia.Location = new System.Drawing.Point(234, 527);
            this.buttonPowrotUstawienia.Name = "buttonPowrotUstawienia";
            this.buttonPowrotUstawienia.Size = new System.Drawing.Size(141, 51);
            this.buttonPowrotUstawienia.TabIndex = 30;
            this.buttonPowrotUstawienia.Text = "POWRÓT";
            this.buttonPowrotUstawienia.UseVisualStyleBackColor = false;
            this.buttonPowrotUstawienia.Click += new System.EventHandler(this.bPowrot);
            // 
            // labelPodajSwojNick
            // 
            this.labelPodajSwojNick.AutoSize = true;
            this.labelPodajSwojNick.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPodajSwojNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajSwojNick.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPodajSwojNick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPodajSwojNick.Location = new System.Drawing.Point(73, 161);
            this.labelPodajSwojNick.MinimumSize = new System.Drawing.Size(150, 35);
            this.labelPodajSwojNick.Name = "labelPodajSwojNick";
            this.labelPodajSwojNick.Padding = new System.Windows.Forms.Padding(3);
            this.labelPodajSwojNick.Size = new System.Drawing.Size(150, 35);
            this.labelPodajSwojNick.TabIndex = 31;
            this.labelPodajSwojNick.Text = "Podaj swój nick";
            this.labelPodajSwojNick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPodajSwojNick.Click += new System.EventHandler(this.labPodajSwojNick);
            // 
            // textBoxPodajSwojNick
            // 
            this.textBoxPodajSwojNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPodajSwojNick.Location = new System.Drawing.Point(249, 161);
            this.textBoxPodajSwojNick.MaximumSize = new System.Drawing.Size(4, 35);
            this.textBoxPodajSwojNick.MinimumSize = new System.Drawing.Size(250, 35);
            this.textBoxPodajSwojNick.Name = "textBoxPodajSwojNick";
            this.textBoxPodajSwojNick.Size = new System.Drawing.Size(250, 35);
            this.textBoxPodajSwojNick.TabIndex = 32;
            this.textBoxPodajSwojNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPodajSwojNick.TextChanged += new System.EventHandler(this.textBobPodajSwojNick);
            // 
            // textBoxSciezka
            // 
            this.textBoxSciezka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSciezka.Location = new System.Drawing.Point(249, 229);
            this.textBoxSciezka.MaximumSize = new System.Drawing.Size(4, 35);
            this.textBoxSciezka.MinimumSize = new System.Drawing.Size(250, 35);
            this.textBoxSciezka.Name = "textBoxSciezka";
            this.textBoxSciezka.Size = new System.Drawing.Size(250, 35);
            this.textBoxSciezka.TabIndex = 34;
            this.textBoxSciezka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSciezka.TextChanged += new System.EventHandler(this.textBoxSciezkaZapisu);
            // 
            // labelPodajSciezkeZapisu
            // 
            this.labelPodajSciezkeZapisu.AutoSize = true;
            this.labelPodajSciezkeZapisu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPodajSciezkeZapisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajSciezkeZapisu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPodajSciezkeZapisu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPodajSciezkeZapisu.Location = new System.Drawing.Point(73, 229);
            this.labelPodajSciezkeZapisu.MinimumSize = new System.Drawing.Size(150, 35);
            this.labelPodajSciezkeZapisu.Name = "labelPodajSciezkeZapisu";
            this.labelPodajSciezkeZapisu.Padding = new System.Windows.Forms.Padding(3);
            this.labelPodajSciezkeZapisu.Size = new System.Drawing.Size(153, 35);
            this.labelPodajSciezkeZapisu.TabIndex = 33;
            this.labelPodajSciezkeZapisu.Text = "Podaj ścieszkę zapisu";
            this.labelPodajSciezkeZapisu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPodajSciezkeZapisu.Click += new System.EventHandler(this.labPodajSciezkeZapisu);
            // 
            // buttonWyborSciezki
            // 
            this.buttonWyborSciezki.Location = new System.Drawing.Point(517, 229);
            this.buttonWyborSciezki.Name = "buttonWyborSciezki";
            this.buttonWyborSciezki.Size = new System.Drawing.Size(35, 35);
            this.buttonWyborSciezki.TabIndex = 35;
            this.buttonWyborSciezki.Text = ",,,";
            this.buttonWyborSciezki.UseVisualStyleBackColor = true;
            this.buttonWyborSciezki.Click += new System.EventHandler(this.bWyborSciezkiZapisu);
            // 
            // trackBarIloscGierWygranych
            // 
            this.trackBarIloscGierWygranych.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.trackBarIloscGierWygranych.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarIloscGierWygranych.LargeChange = 1;
            this.trackBarIloscGierWygranych.Location = new System.Drawing.Point(179, 428);
            this.trackBarIloscGierWygranych.Name = "trackBarIloscGierWygranych";
            this.trackBarIloscGierWygranych.Size = new System.Drawing.Size(250, 45);
            this.trackBarIloscGierWygranych.TabIndex = 36;
            this.trackBarIloscGierWygranych.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarIloscGierWygranych.Scroll += new System.EventHandler(this.trackBarUstawIloscGierWygranych);
            // 
            // labellabWyboruIloscGier
            // 
            this.labellabWyboruIloscGier.AutoSize = true;
            this.labellabWyboruIloscGier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labellabWyboruIloscGier.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labellabWyboruIloscGier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labellabWyboruIloscGier.Location = new System.Drawing.Point(358, 318);
            this.labellabWyboruIloscGier.MaximumSize = new System.Drawing.Size(100, 80);
            this.labellabWyboruIloscGier.MinimumSize = new System.Drawing.Size(100, 80);
            this.labellabWyboruIloscGier.Name = "labellabWyboruIloscGier";
            this.labellabWyboruIloscGier.Size = new System.Drawing.Size(100, 80);
            this.labellabWyboruIloscGier.TabIndex = 37;
            this.labellabWyboruIloscGier.Text = "0";
            this.labellabWyboruIloscGier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labellabWyboruIloscGier.Click += new System.EventHandler(this.labWyboruIloscGier);
            // 
            // labelIloscGierWygranych
            // 
            this.labelIloscGierWygranych.AutoSize = true;
            this.labelIloscGierWygranych.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIloscGierWygranych.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIloscGierWygranych.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIloscGierWygranych.Location = new System.Drawing.Point(150, 363);
            this.labelIloscGierWygranych.MinimumSize = new System.Drawing.Size(150, 35);
            this.labelIloscGierWygranych.Name = "labelIloscGierWygranych";
            this.labelIloscGierWygranych.Padding = new System.Windows.Forms.Padding(3);
            this.labelIloscGierWygranych.Size = new System.Drawing.Size(150, 35);
            this.labelIloscGierWygranych.TabIndex = 33;
            this.labelIloscGierWygranych.Text = "Ilość gier wygranych";
            this.labelIloscGierWygranych.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelIloscGierWygranych.Click += new System.EventHandler(this.labUstawIloscGierWygranych);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Okno_Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 631);
            this.Controls.Add(this.labelIloscGierWygranych);
            this.Controls.Add(this.labellabWyboruIloscGier);
            this.Controls.Add(this.trackBarIloscGierWygranych);
            this.Controls.Add(this.buttonWyborSciezki);
            this.Controls.Add(this.textBoxSciezka);
            this.Controls.Add(this.labelPodajSciezkeZapisu);
            this.Controls.Add(this.textBoxPodajSwojNick);
            this.Controls.Add(this.labelPodajSwojNick);
            this.Controls.Add(this.buttonPowrotUstawienia);
            this.Controls.Add(this.Nazwa_Gry);
            this.MinimumSize = new System.Drawing.Size(630, 670);
            this.Name = "Okno_Ustawienia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Ustawienia";
            this.Load += new System.EventHandler(this.Okno_Ustawienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIloscGierWygranych)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa_Gry;
        private System.Windows.Forms.Button buttonPowrotUstawienia;
        private System.Windows.Forms.Label labelPodajSwojNick;
        private System.Windows.Forms.TextBox textBoxPodajSwojNick;
        private System.Windows.Forms.TextBox textBoxSciezka;
        private System.Windows.Forms.Label labelPodajSciezkeZapisu;
        private System.Windows.Forms.Button buttonWyborSciezki;
        private System.Windows.Forms.TrackBar trackBarIloscGierWygranych;
        private System.Windows.Forms.Label labellabWyboruIloscGier;
        private System.Windows.Forms.Label labelIloscGierWygranych;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}