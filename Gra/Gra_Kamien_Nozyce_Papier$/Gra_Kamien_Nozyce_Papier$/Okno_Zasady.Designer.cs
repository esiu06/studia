namespace Gra_Kamien_Nozyce_Papier_
{
    partial class Okno_Zasady
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno_Zasady));
            this.Nazwa_Gry = new System.Windows.Forms.Label();
            this.buttonPowrotZasady = new System.Windows.Forms.Button();
            this.labelZasady = new System.Windows.Forms.Label();
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
            // buttonPowrotZasady
            // 
            this.buttonPowrotZasady.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPowrotZasady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPowrotZasady.FlatAppearance.BorderSize = 2;
            this.buttonPowrotZasady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrotZasady.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrotZasady.ForeColor = System.Drawing.Color.Salmon;
            this.buttonPowrotZasady.Location = new System.Drawing.Point(234, 527);
            this.buttonPowrotZasady.Name = "buttonPowrotZasady";
            this.buttonPowrotZasady.Size = new System.Drawing.Size(141, 51);
            this.buttonPowrotZasady.TabIndex = 29;
            this.buttonPowrotZasady.Text = "POWRÓT";
            this.buttonPowrotZasady.UseVisualStyleBackColor = false;
            this.buttonPowrotZasady.Click += new System.EventHandler(this.bPowtotZasady);
            // 
            // labelZasady
            // 
            this.labelZasady.AutoSize = true;
            this.labelZasady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZasady.Location = new System.Drawing.Point(105, 150);
            this.labelZasady.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelZasady.Name = "labelZasady";
            this.labelZasady.Padding = new System.Windows.Forms.Padding(20);
            this.labelZasady.Size = new System.Drawing.Size(400, 329);
            this.labelZasady.TabIndex = 30;
            this.labelZasady.Text = resources.GetString("labelZasady.Text");
            this.labelZasady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelZasady.Click += new System.EventHandler(this.labZasadyOpis);
            // 
            // Okno_Zasady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 631);
            this.Controls.Add(this.labelZasady);
            this.Controls.Add(this.buttonPowrotZasady);
            this.Controls.Add(this.Nazwa_Gry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(630, 670);
            this.Name = "Okno_Zasady";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Zasady";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa_Gry;
        private System.Windows.Forms.Button buttonPowrotZasady;
        private System.Windows.Forms.Label labelZasady;
    }
}