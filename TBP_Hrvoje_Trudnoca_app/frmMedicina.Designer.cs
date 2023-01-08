namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmMedicina
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
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.textBoxNazivLijeka = new System.Windows.Forms.TextBox();
            this.textBoxOpisLijeka = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.labelPodaciOLijeku = new System.Windows.Forms.Label();
            this.labelNazivLijeka = new System.Windows.Forms.Label();
            this.labelOpisLijeka = new System.Windows.Forms.Label();
            this.labelCijenaLijeka = new System.Windows.Forms.Label();
            this.buttonDodajLijek = new System.Windows.Forms.Button();
            this.dgvMedicina = new System.Windows.Forms.DataGridView();
            this.labelTrenutniPodaciLijek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicinaPovijest = new System.Windows.Forms.DataGridView();
            this.textBoxNovaCijena = new System.Windows.Forms.TextBox();
            this.labelNovaCijena = new System.Windows.Forms.Label();
            this.buttonNovaCijena = new System.Windows.Forms.Button();
            this.labelTrenutnaCijena = new System.Windows.Forms.Label();
            this.textBoxTrenutnaCijena = new System.Windows.Forms.TextBox();
            this.textBoxTrenutniNaziv = new System.Windows.Forms.TextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicinaPovijest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.BackColor = System.Drawing.Color.Gold;
            this.buttonPovratak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPovratak.ForeColor = System.Drawing.Color.Indigo;
            this.buttonPovratak.Location = new System.Drawing.Point(933, 610);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(131, 62);
            this.buttonPovratak.TabIndex = 1;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = false;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // textBoxNazivLijeka
            // 
            this.textBoxNazivLijeka.Location = new System.Drawing.Point(312, 14);
            this.textBoxNazivLijeka.Name = "textBoxNazivLijeka";
            this.textBoxNazivLijeka.Size = new System.Drawing.Size(151, 22);
            this.textBoxNazivLijeka.TabIndex = 2;
            // 
            // textBoxOpisLijeka
            // 
            this.textBoxOpisLijeka.Location = new System.Drawing.Point(312, 57);
            this.textBoxOpisLijeka.Name = "textBoxOpisLijeka";
            this.textBoxOpisLijeka.Size = new System.Drawing.Size(195, 22);
            this.textBoxOpisLijeka.TabIndex = 3;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(312, 96);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(147, 22);
            this.textBoxCijena.TabIndex = 4;
            // 
            // labelPodaciOLijeku
            // 
            this.labelPodaciOLijeku.AutoSize = true;
            this.labelPodaciOLijeku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPodaciOLijeku.Location = new System.Drawing.Point(12, 12);
            this.labelPodaciOLijeku.Name = "labelPodaciOLijeku";
            this.labelPodaciOLijeku.Size = new System.Drawing.Size(200, 18);
            this.labelPodaciOLijeku.TabIndex = 5;
            this.labelPodaciOLijeku.Text = "Dodajte podatke o lijeku :";
            // 
            // labelNazivLijeka
            // 
            this.labelNazivLijeka.AutoSize = true;
            this.labelNazivLijeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivLijeka.Location = new System.Drawing.Point(239, 14);
            this.labelNazivLijeka.Name = "labelNazivLijeka";
            this.labelNazivLijeka.Size = new System.Drawing.Size(45, 18);
            this.labelNazivLijeka.TabIndex = 6;
            this.labelNazivLijeka.Text = "Naziv";
            // 
            // labelOpisLijeka
            // 
            this.labelOpisLijeka.AutoSize = true;
            this.labelOpisLijeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisLijeka.Location = new System.Drawing.Point(239, 57);
            this.labelOpisLijeka.Name = "labelOpisLijeka";
            this.labelOpisLijeka.Size = new System.Drawing.Size(39, 18);
            this.labelOpisLijeka.TabIndex = 7;
            this.labelOpisLijeka.Text = "Opis";
            // 
            // labelCijenaLijeka
            // 
            this.labelCijenaLijeka.AutoSize = true;
            this.labelCijenaLijeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCijenaLijeka.Location = new System.Drawing.Point(239, 97);
            this.labelCijenaLijeka.Name = "labelCijenaLijeka";
            this.labelCijenaLijeka.Size = new System.Drawing.Size(49, 18);
            this.labelCijenaLijeka.TabIndex = 8;
            this.labelCijenaLijeka.Text = "Cijena";
            // 
            // buttonDodajLijek
            // 
            this.buttonDodajLijek.BackColor = System.Drawing.Color.Gold;
            this.buttonDodajLijek.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajLijek.ForeColor = System.Drawing.Color.Indigo;
            this.buttonDodajLijek.Location = new System.Drawing.Point(602, 33);
            this.buttonDodajLijek.Name = "buttonDodajLijek";
            this.buttonDodajLijek.Size = new System.Drawing.Size(205, 62);
            this.buttonDodajLijek.TabIndex = 9;
            this.buttonDodajLijek.Text = "DODAJ LIJEK";
            this.buttonDodajLijek.UseVisualStyleBackColor = false;
            this.buttonDodajLijek.Click += new System.EventHandler(this.buttonDodajLijek_Click);
            // 
            // dgvMedicina
            // 
            this.dgvMedicina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMedicina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicina.Location = new System.Drawing.Point(15, 175);
            this.dgvMedicina.Name = "dgvMedicina";
            this.dgvMedicina.RowHeadersWidth = 51;
            this.dgvMedicina.RowTemplate.Height = 24;
            this.dgvMedicina.Size = new System.Drawing.Size(911, 207);
            this.dgvMedicina.TabIndex = 10;
            this.dgvMedicina.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMedicina_CellMouseClick);
            // 
            // labelTrenutniPodaciLijek
            // 
            this.labelTrenutniPodaciLijek.AutoSize = true;
            this.labelTrenutniPodaciLijek.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrenutniPodaciLijek.ForeColor = System.Drawing.Color.Green;
            this.labelTrenutniPodaciLijek.Location = new System.Drawing.Point(12, 152);
            this.labelTrenutniPodaciLijek.Name = "labelTrenutniPodaciLijek";
            this.labelTrenutniPodaciLijek.Size = new System.Drawing.Size(236, 20);
            this.labelTrenutniPodaciLijek.TabIndex = 11;
            this.labelTrenutniPodaciLijek.Text = "Trenutni podaci o lijeku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Povijesni podaci o lijeku";
            // 
            // dgvMedicinaPovijest
            // 
            this.dgvMedicinaPovijest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMedicinaPovijest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicinaPovijest.Location = new System.Drawing.Point(16, 451);
            this.dgvMedicinaPovijest.Name = "dgvMedicinaPovijest";
            this.dgvMedicinaPovijest.RowHeadersWidth = 51;
            this.dgvMedicinaPovijest.RowTemplate.Height = 24;
            this.dgvMedicinaPovijest.Size = new System.Drawing.Size(910, 221);
            this.dgvMedicinaPovijest.TabIndex = 13;
            // 
            // textBoxNovaCijena
            // 
            this.textBoxNovaCijena.Location = new System.Drawing.Point(425, 415);
            this.textBoxNovaCijena.Name = "textBoxNovaCijena";
            this.textBoxNovaCijena.Size = new System.Drawing.Size(151, 22);
            this.textBoxNovaCijena.TabIndex = 14;
            // 
            // labelNovaCijena
            // 
            this.labelNovaCijena.AutoSize = true;
            this.labelNovaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaCijena.Location = new System.Drawing.Point(309, 418);
            this.labelNovaCijena.Name = "labelNovaCijena";
            this.labelNovaCijena.Size = new System.Drawing.Size(88, 18);
            this.labelNovaCijena.TabIndex = 15;
            this.labelNovaCijena.Text = "Nova Cijena";
            // 
            // buttonNovaCijena
            // 
            this.buttonNovaCijena.BackColor = System.Drawing.Color.Gold;
            this.buttonNovaCijena.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaCijena.ForeColor = System.Drawing.Color.Indigo;
            this.buttonNovaCijena.Location = new System.Drawing.Point(622, 398);
            this.buttonNovaCijena.Name = "buttonNovaCijena";
            this.buttonNovaCijena.Size = new System.Drawing.Size(304, 38);
            this.buttonNovaCijena.TabIndex = 16;
            this.buttonNovaCijena.Text = "DODAJ NOVU CIJENU";
            this.buttonNovaCijena.UseVisualStyleBackColor = false;
            this.buttonNovaCijena.Click += new System.EventHandler(this.buttonNovaCijena_Click);
            // 
            // labelTrenutnaCijena
            // 
            this.labelTrenutnaCijena.AutoSize = true;
            this.labelTrenutnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrenutnaCijena.Location = new System.Drawing.Point(941, 223);
            this.labelTrenutnaCijena.Name = "labelTrenutnaCijena";
            this.labelTrenutnaCijena.Size = new System.Drawing.Size(111, 18);
            this.labelTrenutnaCijena.TabIndex = 17;
            this.labelTrenutnaCijena.Text = "Trenutna Cijena";
            // 
            // textBoxTrenutnaCijena
            // 
            this.textBoxTrenutnaCijena.Location = new System.Drawing.Point(944, 254);
            this.textBoxTrenutnaCijena.Name = "textBoxTrenutnaCijena";
            this.textBoxTrenutnaCijena.ReadOnly = true;
            this.textBoxTrenutnaCijena.Size = new System.Drawing.Size(94, 22);
            this.textBoxTrenutnaCijena.TabIndex = 18;
            // 
            // textBoxTrenutniNaziv
            // 
            this.textBoxTrenutniNaziv.Location = new System.Drawing.Point(944, 187);
            this.textBoxTrenutniNaziv.Name = "textBoxTrenutniNaziv";
            this.textBoxTrenutniNaziv.ReadOnly = true;
            this.textBoxTrenutniNaziv.Size = new System.Drawing.Size(94, 22);
            this.textBoxTrenutniNaziv.TabIndex = 19;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.Gold;
            this.buttonObrisi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.Indigo;
            this.buttonObrisi.Location = new System.Drawing.Point(933, 335);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(131, 47);
            this.buttonObrisi.TabIndex = 20;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // frmMedicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 684);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.textBoxTrenutniNaziv);
            this.Controls.Add(this.textBoxTrenutnaCijena);
            this.Controls.Add(this.labelTrenutnaCijena);
            this.Controls.Add(this.buttonNovaCijena);
            this.Controls.Add(this.labelNovaCijena);
            this.Controls.Add(this.textBoxNovaCijena);
            this.Controls.Add(this.dgvMedicinaPovijest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTrenutniPodaciLijek);
            this.Controls.Add(this.dgvMedicina);
            this.Controls.Add(this.buttonDodajLijek);
            this.Controls.Add(this.labelCijenaLijeka);
            this.Controls.Add(this.labelOpisLijeka);
            this.Controls.Add(this.labelNazivLijeka);
            this.Controls.Add(this.labelPodaciOLijeku);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxOpisLijeka);
            this.Controls.Add(this.textBoxNazivLijeka);
            this.Controls.Add(this.buttonPovratak);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMedicina";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moji lijekovi";
            this.Load += new System.EventHandler(this.frmMedicina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicinaPovijest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.TextBox textBoxNazivLijeka;
        private System.Windows.Forms.TextBox textBoxOpisLijeka;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label labelPodaciOLijeku;
        private System.Windows.Forms.Label labelNazivLijeka;
        private System.Windows.Forms.Label labelOpisLijeka;
        private System.Windows.Forms.Label labelCijenaLijeka;
        private System.Windows.Forms.Button buttonDodajLijek;
        private System.Windows.Forms.DataGridView dgvMedicina;
        private System.Windows.Forms.Label labelTrenutniPodaciLijek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicinaPovijest;
        private System.Windows.Forms.TextBox textBoxNovaCijena;
        private System.Windows.Forms.Label labelNovaCijena;
        private System.Windows.Forms.Button buttonNovaCijena;
        private System.Windows.Forms.Label labelTrenutnaCijena;
        private System.Windows.Forms.TextBox textBoxTrenutnaCijena;
        private System.Windows.Forms.TextBox textBoxTrenutniNaziv;
        private System.Windows.Forms.Button buttonObrisi;
    }
}