namespace Gra_Kamien_Nozyce_Papier_
{
    partial class Okno_Gra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno_Gra));
            this.Nazwa_Gry = new System.Windows.Forms.Label();
            this.buttonCzysc = new System.Windows.Forms.Button();
            this.labWynik = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelWyborKomputera = new System.Windows.Forms.Label();
            this.labelTwojWybor = new System.Windows.Forms.Label();
            this.bPapier = new System.Windows.Forms.Button();
            this.bNozyce = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonStatystyka = new System.Windows.Forms.Button();
            this.buttonKoniec = new System.Windows.Forms.Button();
            this.panelWyborSymbolu = new System.Windows.Forms.Panel();
            this.buttonSymbol = new System.Windows.Forms.Button();
            this.bKamien = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelYouWin = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelWygraneGracza = new System.Windows.Forms.Label();
            this.labelWygraneKomputera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWyborSymbolu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nazwa_Gry
            // 
            this.Nazwa_Gry.AutoSize = true;
            this.Nazwa_Gry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Nazwa_Gry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nazwa_Gry.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nazwa_Gry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazwa_Gry.Font = new System.Drawing.Font("MS PGothic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwa_Gry.ForeColor = System.Drawing.Color.Thistle;
            this.Nazwa_Gry.Location = new System.Drawing.Point(29, 19);
            this.Nazwa_Gry.MinimumSize = new System.Drawing.Size(1000, 80);
            this.Nazwa_Gry.Name = "Nazwa_Gry";
            this.Nazwa_Gry.Padding = new System.Windows.Forms.Padding(6);
            this.Nazwa_Gry.Size = new System.Drawing.Size(1000, 80);
            this.Nazwa_Gry.TabIndex = 1;
            this.Nazwa_Gry.Text = "GRA KAMIEŃ - NOŻYCE - PAPIER";
            this.Nazwa_Gry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nazwa_Gry.Click += new System.EventHandler(this.Nazwa_Gry_Click);
            // 
            // buttonCzysc
            // 
            this.buttonCzysc.BackColor = System.Drawing.Color.White;
            this.buttonCzysc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCzysc.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonCzysc.FlatAppearance.BorderSize = 2;
            this.buttonCzysc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonCzysc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonCzysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCzysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCzysc.ForeColor = System.Drawing.Color.Tomato;
            this.buttonCzysc.Location = new System.Drawing.Point(114, 383);
            this.buttonCzysc.Name = "buttonCzysc";
            this.buttonCzysc.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCzysc.Size = new System.Drawing.Size(121, 34);
            this.buttonCzysc.TabIndex = 25;
            this.buttonCzysc.Text = "CZYŚĆ";
            this.buttonCzysc.UseVisualStyleBackColor = false;
            this.buttonCzysc.Click += new System.EventHandler(this.bCzysc);
            // 
            // labWynik
            // 
            this.labWynik.AutoSize = true;
            this.labWynik.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labWynik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labWynik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labWynik.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWynik.ForeColor = System.Drawing.Color.MistyRose;
            this.labWynik.Location = new System.Drawing.Point(382, 198);
            this.labWynik.MinimumSize = new System.Drawing.Size(300, 120);
            this.labWynik.Name = "labWynik";
            this.labWynik.Padding = new System.Windows.Forms.Padding(8);
            this.labWynik.Size = new System.Drawing.Size(300, 120);
            this.labWynik.TabIndex = 22;
            this.labWynik.Text = "Wynik";
            this.labWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labWynik.Click += new System.EventHandler(this.labelWynik);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonStart.FlatAppearance.BorderSize = 2;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.Tomato;
            this.buttonStart.Location = new System.Drawing.Point(402, 466);
            this.buttonStart.MaximumSize = new System.Drawing.Size(250, 100);
            this.buttonStart.MinimumSize = new System.Drawing.Size(250, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Padding = new System.Windows.Forms.Padding(8);
            this.buttonStart.Size = new System.Drawing.Size(250, 100);
            this.buttonStart.TabIndex = 21;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.bStart);
            // 
            // labelWyborKomputera
            // 
            this.labelWyborKomputera.AutoSize = true;
            this.labelWyborKomputera.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelWyborKomputera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWyborKomputera.ForeColor = System.Drawing.Color.Tan;
            this.labelWyborKomputera.Location = new System.Drawing.Point(803, 323);
            this.labelWyborKomputera.MaximumSize = new System.Drawing.Size(160, 30);
            this.labelWyborKomputera.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelWyborKomputera.Name = "labelWyborKomputera";
            this.labelWyborKomputera.Padding = new System.Windows.Forms.Padding(2);
            this.labelWyborKomputera.Size = new System.Drawing.Size(160, 30);
            this.labelWyborKomputera.TabIndex = 20;
            this.labelWyborKomputera.Text = "Wybór komputera";
            this.labelWyborKomputera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWyborKomputera.Click += new System.EventHandler(this.labWyborKomputera);
            // 
            // labelTwojWybor
            // 
            this.labelTwojWybor.AutoSize = true;
            this.labelTwojWybor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTwojWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTwojWybor.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labelTwojWybor.Location = new System.Drawing.Point(92, 328);
            this.labelTwojWybor.MaximumSize = new System.Drawing.Size(160, 30);
            this.labelTwojWybor.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelTwojWybor.Name = "labelTwojWybor";
            this.labelTwojWybor.Padding = new System.Windows.Forms.Padding(2);
            this.labelTwojWybor.Size = new System.Drawing.Size(160, 30);
            this.labelTwojWybor.TabIndex = 19;
            this.labelTwojWybor.Text = "Twój wybór";
            this.labelTwojWybor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTwojWybor.Click += new System.EventHandler(this.labTwojWybor);
            // 
            // bPapier
            // 
            this.bPapier.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bPapier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPapier.FlatAppearance.BorderSize = 2;
            this.bPapier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPapier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPapier.ForeColor = System.Drawing.Color.Thistle;
            this.bPapier.Location = new System.Drawing.Point(0, 159);
            this.bPapier.Name = "bPapier";
            this.bPapier.Size = new System.Drawing.Size(184, 55);
            this.bPapier.TabIndex = 18;
            this.bPapier.Text = "PAPIER";
            this.bPapier.UseVisualStyleBackColor = false;
            this.bPapier.Click += new System.EventHandler(this.bPapier_Click);
            // 
            // bNozyce
            // 
            this.bNozyce.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bNozyce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNozyce.FlatAppearance.BorderSize = 2;
            this.bNozyce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNozyce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNozyce.ForeColor = System.Drawing.Color.Thistle;
            this.bNozyce.Location = new System.Drawing.Point(0, 106);
            this.bNozyce.Name = "bNozyce";
            this.bNozyce.Size = new System.Drawing.Size(184, 55);
            this.bNozyce.TabIndex = 17;
            this.bNozyce.Text = "NOŻYCE";
            this.bNozyce.UseVisualStyleBackColor = false;
            this.bNozyce.Click += new System.EventHandler(this.bNozyce_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisz.FlatAppearance.BorderSize = 2;
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Font = new System.Drawing.Font("MS PGothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisz.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonZapisz.Location = new System.Drawing.Point(843, 505);
            this.buttonZapisz.MaximumSize = new System.Drawing.Size(120, 35);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(120, 35);
            this.buttonZapisz.TabIndex = 27;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.bZapiszOknoGra);
            // 
            // buttonStatystyka
            // 
            this.buttonStatystyka.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStatystyka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatystyka.FlatAppearance.BorderSize = 2;
            this.buttonStatystyka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatystyka.Font = new System.Drawing.Font("MS PGothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatystyka.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonStatystyka.Location = new System.Drawing.Point(843, 432);
            this.buttonStatystyka.MaximumSize = new System.Drawing.Size(120, 35);
            this.buttonStatystyka.Name = "buttonStatystyka";
            this.buttonStatystyka.Size = new System.Drawing.Size(120, 35);
            this.buttonStatystyka.TabIndex = 26;
            this.buttonStatystyka.Text = "Statystyka";
            this.buttonStatystyka.UseVisualStyleBackColor = false;
            this.buttonStatystyka.Click += new System.EventHandler(this.bStatystykaOknoGra);
            // 
            // buttonKoniec
            // 
            this.buttonKoniec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonKoniec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKoniec.FlatAppearance.BorderSize = 2;
            this.buttonKoniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKoniec.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKoniec.ForeColor = System.Drawing.Color.Salmon;
            this.buttonKoniec.Location = new System.Drawing.Point(813, 591);
            this.buttonKoniec.Name = "buttonKoniec";
            this.buttonKoniec.Size = new System.Drawing.Size(150, 51);
            this.buttonKoniec.TabIndex = 28;
            this.buttonKoniec.Text = "KONIEC";
            this.buttonKoniec.UseVisualStyleBackColor = false;
            this.buttonKoniec.Click += new System.EventHandler(this.bKoniec);
            // 
            // panelWyborSymbolu
            // 
            this.panelWyborSymbolu.Controls.Add(this.buttonSymbol);
            this.panelWyborSymbolu.Controls.Add(this.bKamien);
            this.panelWyborSymbolu.Controls.Add(this.bPapier);
            this.panelWyborSymbolu.Controls.Add(this.bNozyce);
            this.panelWyborSymbolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelWyborSymbolu.Location = new System.Drawing.Point(79, 432);
            this.panelWyborSymbolu.MaximumSize = new System.Drawing.Size(184, 215);
            this.panelWyborSymbolu.MinimumSize = new System.Drawing.Size(184, 55);
            this.panelWyborSymbolu.Name = "panelWyborSymbolu";
            this.panelWyborSymbolu.Size = new System.Drawing.Size(184, 55);
            this.panelWyborSymbolu.TabIndex = 29;
            this.panelWyborSymbolu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSymbol);
            // 
            // buttonSymbol
            // 
            this.buttonSymbol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSymbol.FlatAppearance.BorderSize = 2;
            this.buttonSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSymbol.ForeColor = System.Drawing.Color.Thistle;
            this.buttonSymbol.Image = global::Gra_Kamien_Nozyce_Papier_.Properties.Resources.angle_arrow_down;
            this.buttonSymbol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSymbol.Location = new System.Drawing.Point(0, 0);
            this.buttonSymbol.Name = "buttonSymbol";
            this.buttonSymbol.Padding = new System.Windows.Forms.Padding(9);
            this.buttonSymbol.Size = new System.Drawing.Size(184, 55);
            this.buttonSymbol.TabIndex = 19;
            this.buttonSymbol.Text = "SYMBOL";
            this.buttonSymbol.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSymbol.UseCompatibleTextRendering = true;
            this.buttonSymbol.UseVisualStyleBackColor = false;
            this.buttonSymbol.Click += new System.EventHandler(this.bSymbol);
            this.buttonSymbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // bKamien
            // 
            this.bKamien.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bKamien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bKamien.FlatAppearance.BorderSize = 2;
            this.bKamien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKamien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKamien.ForeColor = System.Drawing.Color.Thistle;
            this.bKamien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bKamien.Location = new System.Drawing.Point(0, 53);
            this.bKamien.Name = "bKamien";
            this.bKamien.Padding = new System.Windows.Forms.Padding(9);
            this.bKamien.Size = new System.Drawing.Size(184, 55);
            this.bKamien.TabIndex = 32;
            this.bKamien.Text = "KAMIEŃ";
            this.bKamien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bKamien.UseCompatibleTextRendering = true;
            this.bKamien.UseVisualStyleBackColor = false;
            this.bKamien.Click += new System.EventHandler(this.bKamien_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelYouWin
            // 
            this.labelYouWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYouWin.AutoSize = true;
            this.labelYouWin.BackColor = System.Drawing.Color.Red;
            this.labelYouWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYouWin.Enabled = false;
            this.labelYouWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYouWin.ForeColor = System.Drawing.Color.Firebrick;
            this.labelYouWin.Image = ((System.Drawing.Image)(resources.GetObject("labelYouWin.Image")));
            this.labelYouWin.Location = new System.Drawing.Point(355, 388);
            this.labelYouWin.MaximumSize = new System.Drawing.Size(300, 150);
            this.labelYouWin.MinimumSize = new System.Drawing.Size(350, 200);
            this.labelYouWin.Name = "labelYouWin";
            this.labelYouWin.Size = new System.Drawing.Size(350, 200);
            this.labelYouWin.TabIndex = 30;
            this.labelYouWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYouWin.Visible = false;
            this.labelYouWin.Click += new System.EventHandler(this.labYouWin);
            // 
            // labelGameOver
            // 
            this.labelGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.SystemColors.Window;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.labelGameOver.Image = ((System.Drawing.Image)(resources.GetObject("labelGameOver.Image")));
            this.labelGameOver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelGameOver.Location = new System.Drawing.Point(311, 413);
            this.labelGameOver.MaximumSize = new System.Drawing.Size(350, 150);
            this.labelGameOver.MinimumSize = new System.Drawing.Size(450, 150);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(450, 150);
            this.labelGameOver.TabIndex = 31;
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;
            this.labelGameOver.Click += new System.EventHandler(this.labGameOver);
            // 
            // labelWygraneGracza
            // 
            this.labelWygraneGracza.AutoSize = true;
            this.labelWygraneGracza.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWygraneGracza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelWygraneGracza.Location = new System.Drawing.Point(302, 238);
            this.labelWygraneGracza.MinimumSize = new System.Drawing.Size(50, 50);
            this.labelWygraneGracza.Name = "labelWygraneGracza";
            this.labelWygraneGracza.Size = new System.Drawing.Size(50, 50);
            this.labelWygraneGracza.TabIndex = 32;
            this.labelWygraneGracza.Text = "0";
            this.labelWygraneGracza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWygraneGracza.Click += new System.EventHandler(this.labWygraneGracza);
            // 
            // labelWygraneKomputera
            // 
            this.labelWygraneKomputera.AutoSize = true;
            this.labelWygraneKomputera.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWygraneKomputera.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelWygraneKomputera.Location = new System.Drawing.Point(711, 238);
            this.labelWygraneKomputera.MinimumSize = new System.Drawing.Size(50, 50);
            this.labelWygraneKomputera.Name = "labelWygraneKomputera";
            this.labelWygraneKomputera.Size = new System.Drawing.Size(50, 50);
            this.labelWygraneKomputera.TabIndex = 33;
            this.labelWygraneKomputera.Text = "0";
            this.labelWygraneKomputera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWygraneKomputera.Click += new System.EventHandler(this.labWygraneKomputera);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(92, 148);
            this.label1.MaximumSize = new System.Drawing.Size(160, 180);
            this.label1.MinimumSize = new System.Drawing.Size(160, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 180);
            this.label1.TabIndex = 34;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(803, 143);
            this.label2.MaximumSize = new System.Drawing.Size(160, 180);
            this.label2.MinimumSize = new System.Drawing.Size(160, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 180);
            this.label2.TabIndex = 35;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Okno_Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1063, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWygraneKomputera);
            this.Controls.Add(this.labelWygraneGracza);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelYouWin);
            this.Controls.Add(this.buttonKoniec);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonStatystyka);
            this.Controls.Add(this.buttonCzysc);
            this.Controls.Add(this.labWynik);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelWyborKomputera);
            this.Controls.Add(this.labelTwojWybor);
            this.Controls.Add(this.Nazwa_Gry);
            this.Controls.Add(this.panelWyborSymbolu);
            this.MinimumSize = new System.Drawing.Size(630, 670);
            this.Name = "Okno_Gra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra Kamień - Nożyce - Kamień";
            this.Load += new System.EventHandler(this.Okno_Gra_Load);
            this.panelWyborSymbolu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa_Gry;
        private System.Windows.Forms.Button buttonCzysc;
        private System.Windows.Forms.Label labWynik;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelWyborKomputera;
        private System.Windows.Forms.Label labelTwojWybor;
        private System.Windows.Forms.Button bPapier;
        private System.Windows.Forms.Button bNozyce;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonStatystyka;
        private System.Windows.Forms.Button buttonKoniec;
        private System.Windows.Forms.Panel panelWyborSymbolu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSymbol;
        private System.Windows.Forms.Label labelYouWin;
        private System.Windows.Forms.Button bKamien;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelWygraneGracza;
        private System.Windows.Forms.Label labelWygraneKomputera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}