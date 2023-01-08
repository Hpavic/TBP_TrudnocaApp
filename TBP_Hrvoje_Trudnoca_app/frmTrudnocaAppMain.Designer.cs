namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmTrudnocaAppMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrudnocaAppMain));
            this.labelPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.tbPrijavljeniKorisnik = new System.Windows.Forms.TextBox();
            this.labelMojaBeba = new System.Windows.Forms.Label();
            this.btnMojaBebaRound = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.btnLogOut = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.btnUdarci = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelUdarci = new System.Windows.Forms.Label();
            this.btnAzuriraj = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelAzurirajPodatke = new System.Windows.Forms.Label();
            this.dgvRegistar = new System.Windows.Forms.DataGridView();
            this.labelRekreacija = new System.Windows.Forms.Label();
            this.roundButtonRekreacija = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelMedicina = new System.Windows.Forms.Label();
            this.roundButtonMedicina = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrijavljeniKorisnik
            // 
            this.labelPrijavljeniKorisnik.AutoSize = true;
            this.labelPrijavljeniKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.labelPrijavljeniKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrijavljeniKorisnik.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijavljeniKorisnik.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPrijavljeniKorisnik.Location = new System.Drawing.Point(37, 32);
            this.labelPrijavljeniKorisnik.Name = "labelPrijavljeniKorisnik";
            this.labelPrijavljeniKorisnik.Size = new System.Drawing.Size(356, 30);
            this.labelPrijavljeniKorisnik.TabIndex = 0;
            this.labelPrijavljeniKorisnik.Text = "Dobrodošli u TrudnocaApp";
            // 
            // tbPrijavljeniKorisnik
            // 
            this.tbPrijavljeniKorisnik.BackColor = System.Drawing.Color.LightCyan;
            this.tbPrijavljeniKorisnik.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrijavljeniKorisnik.ForeColor = System.Drawing.Color.Indigo;
            this.tbPrijavljeniKorisnik.Location = new System.Drawing.Point(454, 32);
            this.tbPrijavljeniKorisnik.Name = "tbPrijavljeniKorisnik";
            this.tbPrijavljeniKorisnik.ReadOnly = true;
            this.tbPrijavljeniKorisnik.Size = new System.Drawing.Size(177, 35);
            this.tbPrijavljeniKorisnik.TabIndex = 1;
            this.tbPrijavljeniKorisnik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMojaBeba
            // 
            this.labelMojaBeba.AutoSize = true;
            this.labelMojaBeba.BackColor = System.Drawing.Color.LightPink;
            this.labelMojaBeba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMojaBeba.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMojaBeba.ForeColor = System.Drawing.Color.Green;
            this.labelMojaBeba.Location = new System.Drawing.Point(73, 136);
            this.labelMojaBeba.Name = "labelMojaBeba";
            this.labelMojaBeba.Size = new System.Drawing.Size(143, 22);
            this.labelMojaBeba.TabIndex = 2;
            this.labelMojaBeba.Text = "Moja Beba <3";
            // 
            // btnMojaBebaRound
            // 
            this.btnMojaBebaRound.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMojaBebaRound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMojaBebaRound.BackgroundImage")));
            this.btnMojaBebaRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMojaBebaRound.Location = new System.Drawing.Point(12, 201);
            this.btnMojaBebaRound.Name = "btnMojaBebaRound";
            this.btnMojaBebaRound.Size = new System.Drawing.Size(260, 240);
            this.btnMojaBebaRound.TabIndex = 4;
            this.btnMojaBebaRound.UseVisualStyleBackColor = false;
            this.btnMojaBebaRound.Click += new System.EventHandler(this.btnMojaBebaRound_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.Location = new System.Drawing.Point(778, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(90, 90);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUdarci
            // 
            this.btnUdarci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUdarci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUdarci.BackgroundImage")));
            this.btnUdarci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUdarci.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUdarci.Location = new System.Drawing.Point(608, 201);
            this.btnUdarci.Name = "btnUdarci";
            this.btnUdarci.Size = new System.Drawing.Size(260, 240);
            this.btnUdarci.TabIndex = 8;
            this.btnUdarci.UseVisualStyleBackColor = false;
            this.btnUdarci.Click += new System.EventHandler(this.btnUdarci_Click);
            // 
            // labelUdarci
            // 
            this.labelUdarci.AutoSize = true;
            this.labelUdarci.BackColor = System.Drawing.Color.LightPink;
            this.labelUdarci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUdarci.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUdarci.ForeColor = System.Drawing.Color.Green;
            this.labelUdarci.Location = new System.Drawing.Point(664, 136);
            this.labelUdarci.Name = "labelUdarci";
            this.labelUdarci.Size = new System.Drawing.Size(155, 22);
            this.labelUdarci.TabIndex = 9;
            this.labelUdarci.Text = "Najdraži udarci";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzuriraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.BackgroundImage")));
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAzuriraj.Location = new System.Drawing.Point(316, 201);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(250, 250);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // labelAzurirajPodatke
            // 
            this.labelAzurirajPodatke.AutoSize = true;
            this.labelAzurirajPodatke.BackColor = System.Drawing.Color.LightPink;
            this.labelAzurirajPodatke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAzurirajPodatke.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAzurirajPodatke.ForeColor = System.Drawing.Color.Green;
            this.labelAzurirajPodatke.Location = new System.Drawing.Point(353, 136);
            this.labelAzurirajPodatke.Name = "labelAzurirajPodatke";
            this.labelAzurirajPodatke.Size = new System.Drawing.Size(169, 22);
            this.labelAzurirajPodatke.TabIndex = 11;
            this.labelAzurirajPodatke.Text = "Ažuriraj podatke";
            // 
            // dgvRegistar
            // 
            this.dgvRegistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistar.Location = new System.Drawing.Point(57, 145);
            this.dgvRegistar.Name = "dgvRegistar";
            this.dgvRegistar.RowHeadersWidth = 51;
            this.dgvRegistar.RowTemplate.Height = 24;
            this.dgvRegistar.Size = new System.Drawing.Size(645, 317);
            this.dgvRegistar.TabIndex = 12;
            this.dgvRegistar.Visible = false;
            // 
            // labelRekreacija
            // 
            this.labelRekreacija.AutoSize = true;
            this.labelRekreacija.BackColor = System.Drawing.Color.LightPink;
            this.labelRekreacija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRekreacija.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRekreacija.ForeColor = System.Drawing.Color.Green;
            this.labelRekreacija.Location = new System.Drawing.Point(218, 504);
            this.labelRekreacija.Name = "labelRekreacija";
            this.labelRekreacija.Size = new System.Drawing.Size(110, 22);
            this.labelRekreacija.TabIndex = 13;
            this.labelRekreacija.Text = "Rekreacija";
            // 
            // roundButtonRekreacija
            // 
            this.roundButtonRekreacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundButtonRekreacija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButtonRekreacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonRekreacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundButtonRekreacija.Location = new System.Drawing.Point(144, 550);
            this.roundButtonRekreacija.Name = "roundButtonRekreacija";
            this.roundButtonRekreacija.Size = new System.Drawing.Size(260, 240);
            this.roundButtonRekreacija.TabIndex = 14;
            this.roundButtonRekreacija.Text = "REKREIRAJ SE !";
            this.roundButtonRekreacija.UseVisualStyleBackColor = false;
            this.roundButtonRekreacija.Click += new System.EventHandler(this.roundButtonRekreacija_Click);
            // 
            // labelMedicina
            // 
            this.labelMedicina.AutoSize = true;
            this.labelMedicina.BackColor = System.Drawing.Color.LightPink;
            this.labelMedicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMedicina.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicina.ForeColor = System.Drawing.Color.Green;
            this.labelMedicina.Location = new System.Drawing.Point(554, 504);
            this.labelMedicina.Name = "labelMedicina";
            this.labelMedicina.Size = new System.Drawing.Size(95, 22);
            this.labelMedicina.TabIndex = 15;
            this.labelMedicina.Text = "Medicina";
            // 
            // roundButtonMedicina
            // 
            this.roundButtonMedicina.BackColor = System.Drawing.Color.Silver;
            this.roundButtonMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButtonMedicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonMedicina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundButtonMedicina.Location = new System.Drawing.Point(468, 550);
            this.roundButtonMedicina.Name = "roundButtonMedicina";
            this.roundButtonMedicina.Size = new System.Drawing.Size(260, 240);
            this.roundButtonMedicina.TabIndex = 16;
            this.roundButtonMedicina.Text = "MOJI LIJEKOVI";
            this.roundButtonMedicina.UseVisualStyleBackColor = false;
            this.roundButtonMedicina.Click += new System.EventHandler(this.roundButtonMedicina_Click);
            // 
            // frmTrudnocaAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBP_Hrvoje_Trudnoca_app.Properties.Resources.registracija;
            this.ClientSize = new System.Drawing.Size(878, 823);
            this.Controls.Add(this.roundButtonMedicina);
            this.Controls.Add(this.labelMedicina);
            this.Controls.Add(this.roundButtonRekreacija);
            this.Controls.Add(this.labelRekreacija);
            this.Controls.Add(this.dgvRegistar);
            this.Controls.Add(this.labelAzurirajPodatke);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.labelUdarci);
            this.Controls.Add(this.btnUdarci);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMojaBebaRound);
            this.Controls.Add(this.labelMojaBeba);
            this.Controls.Add(this.tbPrijavljeniKorisnik);
            this.Controls.Add(this.labelPrijavljeniKorisnik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTrudnocaAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrudnocaApp";
            this.Load += new System.EventHandler(this.frmTrudnocaAppMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrijavljeniKorisnik;
        private System.Windows.Forms.TextBox tbPrijavljeniKorisnik;
        private System.Windows.Forms.Label labelMojaBeba;
        private RoundButton btnMojaBebaRound;
        private RoundButton btnLogOut;
        private RoundButton btnUdarci;
        private System.Windows.Forms.Label labelUdarci;
        private RoundButton btnAzuriraj;
        private System.Windows.Forms.Label labelAzurirajPodatke;
        private System.Windows.Forms.DataGridView dgvRegistar;
        private System.Windows.Forms.Label labelRekreacija;
        private RoundButton roundButtonRekreacija;
        private System.Windows.Forms.Label labelMedicina;
        private RoundButton roundButtonMedicina;
    }
}