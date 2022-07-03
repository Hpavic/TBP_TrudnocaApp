namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelDobrodosli = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.labelNovi = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.labelKorisnickoImeNePostoji = new System.Windows.Forms.Label();
            this.labelLozinkaNijeIspravna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLozinka
            // 
            this.tbLozinka.BackColor = System.Drawing.Color.Pink;
            this.tbLozinka.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.Location = new System.Drawing.Point(380, 426);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(173, 26);
            this.tbLozinka.TabIndex = 0;
            this.tbLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.BackColor = System.Drawing.Color.Pink;
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoIme.Location = new System.Drawing.Point(380, 374);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(173, 26);
            this.tbKorisnickoIme.TabIndex = 2;
            this.tbKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.BackColor = System.Drawing.Color.Pink;
            this.labelKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoIme.ForeColor = System.Drawing.Color.Green;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(171, 375);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(165, 22);
            this.labelKorisnickoIme.TabIndex = 3;
            this.labelKorisnickoIme.Text = "Korisničko ime :";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.BackColor = System.Drawing.Color.Pink;
            this.labelLozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLozinka.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinka.ForeColor = System.Drawing.Color.Green;
            this.labelLozinka.Location = new System.Drawing.Point(239, 430);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(97, 22);
            this.labelLozinka.TabIndex = 4;
            this.labelLozinka.Text = "Lozinka :";
            // 
            // labelDobrodosli
            // 
            this.labelDobrodosli.AutoSize = true;
            this.labelDobrodosli.BackColor = System.Drawing.Color.Transparent;
            this.labelDobrodosli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDobrodosli.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDobrodosli.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.labelDobrodosli.Location = new System.Drawing.Point(123, 215);
            this.labelDobrodosli.Name = "labelDobrodosli";
            this.labelDobrodosli.Size = new System.Drawing.Size(533, 42);
            this.labelDobrodosli.TabIndex = 5;
            this.labelDobrodosli.Text = "Dobrodošli na TrudnocaApp";
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Gold;
            this.btnPrijava.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.Indigo;
            this.btnPrijava.Location = new System.Drawing.Point(377, 474);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(181, 40);
            this.btnPrijava.TabIndex = 6;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // labelNovi
            // 
            this.labelNovi.AutoSize = true;
            this.labelNovi.BackColor = System.Drawing.Color.Transparent;
            this.labelNovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNovi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovi.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelNovi.Location = new System.Drawing.Point(560, 289);
            this.labelNovi.Name = "labelNovi";
            this.labelNovi.Size = new System.Drawing.Size(260, 22);
            this.labelNovi.TabIndex = 7;
            this.labelNovi.Text = "Novi ste na TrudnocaApp?";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.Gold;
            this.btnRegistracija.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.ForeColor = System.Drawing.Color.Indigo;
            this.btnRegistracija.Location = new System.Drawing.Point(641, 324);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(179, 48);
            this.btnRegistracija.TabIndex = 8;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // labelKorisnickoImeNePostoji
            // 
            this.labelKorisnickoImeNePostoji.AutoSize = true;
            this.labelKorisnickoImeNePostoji.BackColor = System.Drawing.Color.PowderBlue;
            this.labelKorisnickoImeNePostoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKorisnickoImeNePostoji.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoImeNePostoji.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelKorisnickoImeNePostoji.Location = new System.Drawing.Point(377, 403);
            this.labelKorisnickoImeNePostoji.Name = "labelKorisnickoImeNePostoji";
            this.labelKorisnickoImeNePostoji.Size = new System.Drawing.Size(184, 16);
            this.labelKorisnickoImeNePostoji.TabIndex = 9;
            this.labelKorisnickoImeNePostoji.Text = "Korisničko ime ne postoji!";
            this.labelKorisnickoImeNePostoji.Visible = false;
            // 
            // labelLozinkaNijeIspravna
            // 
            this.labelLozinkaNijeIspravna.AutoSize = true;
            this.labelLozinkaNijeIspravna.BackColor = System.Drawing.Color.PowderBlue;
            this.labelLozinkaNijeIspravna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLozinkaNijeIspravna.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinkaNijeIspravna.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLozinkaNijeIspravna.Location = new System.Drawing.Point(377, 455);
            this.labelLozinkaNijeIspravna.Name = "labelLozinkaNijeIspravna";
            this.labelLozinkaNijeIspravna.Size = new System.Drawing.Size(159, 16);
            this.labelLozinkaNijeIspravna.TabIndex = 10;
            this.labelLozinkaNijeIspravna.Text = "Lozinka nije ispravna!";
            this.labelLozinkaNijeIspravna.Visible = false;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelLozinkaNijeIspravna);
            this.Controls.Add(this.labelKorisnickoImeNePostoji);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.labelNovi);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.labelDobrodosli);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.tbLozinka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrudnocaApp";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelDobrodosli;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label labelNovi;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label labelKorisnickoImeNePostoji;
        private System.Windows.Forms.Label labelLozinkaNijeIspravna;
    }
}

