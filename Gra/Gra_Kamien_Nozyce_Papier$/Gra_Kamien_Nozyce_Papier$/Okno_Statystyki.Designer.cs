namespace Gra_Kamien_Nozyce_Papier_
{
    partial class Okno_Statystyki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno_Statystyki));
            this.buttonPowrotStatystyka = new System.Windows.Forms.Button();
            this.Nazwa_Gry = new System.Windows.Forms.Label();
            this.labelZasadyGry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPowrotStatystyka
            // 
            this.buttonPowrotStatystyka.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPowrotStatystyka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPowrotStatystyka.FlatAppearance.BorderSize = 2;
            this.buttonPowrotStatystyka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrotStatystyka.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrotStatystyka.ForeColor = System.Drawing.Color.Salmon;
            this.buttonPowrotStatystyka.Location = new System.Drawing.Point(234, 527);
            this.buttonPowrotStatystyka.Name = "buttonPowrotStatystyka";
            this.buttonPowrotStatystyka.Size = new System.Drawing.Size(141, 51);
            this.buttonPowrotStatystyka.TabIndex = 32;
            this.buttonPowrotStatystyka.Text = "POWRÓT";
            this.buttonPowrotStatystyka.UseVisualStyleBackColor = false;
            this.buttonPowrotStatystyka.Click += new System.EventHandler(this.bPowrotStatystyka);
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
            this.Nazwa_Gry.TabIndex = 31;
            this.Nazwa_Gry.Text = "GRA KAMIEŃ - NOŻYCE - PAPIER";
            this.Nazwa_Gry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nazwa_Gry.Click += new System.EventHandler(this.Nazwa_Gry_Click);
            // 
            // labelZasadyGry
            // 
            this.labelZasadyGry.AutoSize = true;
            this.labelZasadyGry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelZasadyGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZasadyGry.ForeColor = System.Drawing.Color.Tomato;
            this.labelZasadyGry.Location = new System.Drawing.Point(135, 145);
            this.labelZasadyGry.MinimumSize = new System.Drawing.Size(350, 320);
            this.labelZasadyGry.Name = "labelZasadyGry";
            this.labelZasadyGry.Size = new System.Drawing.Size(350, 320);
            this.labelZasadyGry.TabIndex = 33;
            this.labelZasadyGry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelZasadyGry.Click += new System.EventHandler(this.labStatystyla);
            // 
            // Okno_Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 631);
            this.Controls.Add(this.labelZasadyGry);
            this.Controls.Add(this.buttonPowrotStatystyka);
            this.Controls.Add(this.Nazwa_Gry);
            this.MinimumSize = new System.Drawing.Size(630, 670);
            this.Name = "Okno_Statystyki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrotStatystyka;
        private System.Windows.Forms.Label Nazwa_Gry;
        private System.Windows.Forms.Label labelZasadyGry;
    }
}