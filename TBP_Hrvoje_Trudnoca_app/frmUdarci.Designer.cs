namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmUdarci
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnUdarci = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.dgvUdarci = new System.Windows.Forms.DataGridView();
            this.labelBrojUdaraca = new System.Windows.Forms.Label();
            this.btnStop = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelRazlikaVremena = new System.Windows.Forms.Label();
            this.labelTrajanjeSesije = new System.Windows.Forms.Label();
            this.roundButtonUdarac = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelPocetakIntervala = new System.Windows.Forms.Label();
            this.labelKrajIntervala = new System.Windows.Forms.Label();
            this.labelUkUdaraca = new System.Windows.Forms.Label();
            this.labelPocVrijZadIntTxt = new System.Windows.Forms.Label();
            this.labelZavVrijZadIntTxt = new System.Windows.Forms.Label();
            this.labelPocVrijZadInt = new System.Windows.Forms.Label();
            this.labelZavVrijZadInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdarci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Gold;
            this.btnPovratak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.ForeColor = System.Drawing.Color.Indigo;
            this.btnPovratak.Location = new System.Drawing.Point(917, 628);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(132, 58);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnUdarci
            // 
            this.btnUdarci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUdarci.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUdarci.Location = new System.Drawing.Point(38, 51);
            this.btnUdarci.Name = "btnUdarci";
            this.btnUdarci.Size = new System.Drawing.Size(125, 125);
            this.btnUdarci.TabIndex = 1;
            this.btnUdarci.UseVisualStyleBackColor = false;
            this.btnUdarci.Click += new System.EventHandler(this.btnUdarci_Click);
            // 
            // dgvUdarci
            // 
            this.dgvUdarci.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUdarci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdarci.Location = new System.Drawing.Point(12, 337);
            this.dgvUdarci.Name = "dgvUdarci";
            this.dgvUdarci.RowHeadersWidth = 51;
            this.dgvUdarci.RowTemplate.Height = 24;
            this.dgvUdarci.Size = new System.Drawing.Size(892, 349);
            this.dgvUdarci.TabIndex = 2;
            // 
            // labelBrojUdaraca
            // 
            this.labelBrojUdaraca.AutoSize = true;
            this.labelBrojUdaraca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelBrojUdaraca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBrojUdaraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojUdaraca.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelBrojUdaraca.Location = new System.Drawing.Point(568, 114);
            this.labelBrojUdaraca.Name = "labelBrojUdaraca";
            this.labelBrojUdaraca.Size = new System.Drawing.Size(208, 53);
            this.labelBrojUdaraca.TabIndex = 3;
            this.labelBrojUdaraca.Text = "dynLabel";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Location = new System.Drawing.Point(410, 52);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 125);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelRazlikaVremena
            // 
            this.labelRazlikaVremena.AutoSize = true;
            this.labelRazlikaVremena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRazlikaVremena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazlikaVremena.Location = new System.Drawing.Point(568, 279);
            this.labelRazlikaVremena.Name = "labelRazlikaVremena";
            this.labelRazlikaVremena.Size = new System.Drawing.Size(95, 27);
            this.labelRazlikaVremena.TabIndex = 5;
            this.labelRazlikaVremena.Text = "dynLab";
            this.labelRazlikaVremena.Visible = false;
            // 
            // labelTrajanjeSesije
            // 
            this.labelTrajanjeSesije.AutoSize = true;
            this.labelTrajanjeSesije.BackColor = System.Drawing.Color.Pink;
            this.labelTrajanjeSesije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrajanjeSesije.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrajanjeSesije.ForeColor = System.Drawing.Color.Green;
            this.labelTrajanjeSesije.Location = new System.Drawing.Point(568, 241);
            this.labelTrajanjeSesije.Name = "labelTrajanjeSesije";
            this.labelTrajanjeSesije.Size = new System.Drawing.Size(125, 18);
            this.labelTrajanjeSesije.TabIndex = 6;
            this.labelTrajanjeSesije.Text = "Trajanje sesije :";
            this.labelTrajanjeSesije.Visible = false;
            // 
            // roundButtonUdarac
            // 
            this.roundButtonUdarac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.roundButtonUdarac.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.roundButtonUdarac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonUdarac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButtonUdarac.Location = new System.Drawing.Point(222, 52);
            this.roundButtonUdarac.Name = "roundButtonUdarac";
            this.roundButtonUdarac.Size = new System.Drawing.Size(131, 125);
            this.roundButtonUdarac.TabIndex = 7;
            this.roundButtonUdarac.Text = "UDARAC";
            this.roundButtonUdarac.UseVisualStyleBackColor = false;
            this.roundButtonUdarac.Click += new System.EventHandler(this.roundButtonUdarac_Click);
            // 
            // labelPocetakIntervala
            // 
            this.labelPocetakIntervala.AutoSize = true;
            this.labelPocetakIntervala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocetakIntervala.Location = new System.Drawing.Point(35, 22);
            this.labelPocetakIntervala.Name = "labelPocetakIntervala";
            this.labelPocetakIntervala.Size = new System.Drawing.Size(148, 18);
            this.labelPocetakIntervala.TabIndex = 8;
            this.labelPocetakIntervala.Text = "Početak Intervala :";
            // 
            // labelKrajIntervala
            // 
            this.labelKrajIntervala.AutoSize = true;
            this.labelKrajIntervala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKrajIntervala.Location = new System.Drawing.Point(419, 22);
            this.labelKrajIntervala.Name = "labelKrajIntervala";
            this.labelKrajIntervala.Size = new System.Drawing.Size(116, 18);
            this.labelKrajIntervala.TabIndex = 9;
            this.labelKrajIntervala.Text = "Kraj Intervala :";
            // 
            // labelUkUdaraca
            // 
            this.labelUkUdaraca.AutoSize = true;
            this.labelUkUdaraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkUdaraca.Location = new System.Drawing.Point(565, 88);
            this.labelUkUdaraca.Name = "labelUkUdaraca";
            this.labelUkUdaraca.Size = new System.Drawing.Size(204, 16);
            this.labelUkUdaraca.TabIndex = 10;
            this.labelUkUdaraca.Text = "Ukupno udaraca u intervalu :";
            // 
            // labelPocVrijZadIntTxt
            // 
            this.labelPocVrijZadIntTxt.AutoSize = true;
            this.labelPocVrijZadIntTxt.BackColor = System.Drawing.Color.Pink;
            this.labelPocVrijZadIntTxt.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocVrijZadIntTxt.ForeColor = System.Drawing.Color.Green;
            this.labelPocVrijZadIntTxt.Location = new System.Drawing.Point(46, 227);
            this.labelPocVrijZadIntTxt.Name = "labelPocVrijZadIntTxt";
            this.labelPocVrijZadIntTxt.Size = new System.Drawing.Size(143, 32);
            this.labelPocVrijZadIntTxt.TabIndex = 11;
            this.labelPocVrijZadIntTxt.Text = "Početno vrijeme \r\nzadnjeg intervala :";
            // 
            // labelZavVrijZadIntTxt
            // 
            this.labelZavVrijZadIntTxt.AutoSize = true;
            this.labelZavVrijZadIntTxt.BackColor = System.Drawing.Color.Pink;
            this.labelZavVrijZadIntTxt.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZavVrijZadIntTxt.ForeColor = System.Drawing.Color.Green;
            this.labelZavVrijZadIntTxt.Location = new System.Drawing.Point(293, 227);
            this.labelZavVrijZadIntTxt.Name = "labelZavVrijZadIntTxt";
            this.labelZavVrijZadIntTxt.Size = new System.Drawing.Size(143, 32);
            this.labelZavVrijZadIntTxt.TabIndex = 12;
            this.labelZavVrijZadIntTxt.Text = "Završno vrijeme \r\nzadnjeg intervala :";
            // 
            // labelPocVrijZadInt
            // 
            this.labelPocVrijZadInt.AutoSize = true;
            this.labelPocVrijZadInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPocVrijZadInt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocVrijZadInt.Location = new System.Drawing.Point(49, 279);
            this.labelPocVrijZadInt.Name = "labelPocVrijZadInt";
            this.labelPocVrijZadInt.Size = new System.Drawing.Size(95, 27);
            this.labelPocVrijZadInt.TabIndex = 13;
            this.labelPocVrijZadInt.Text = "dynLab";
            this.labelPocVrijZadInt.Visible = false;
            // 
            // labelZavVrijZadInt
            // 
            this.labelZavVrijZadInt.AutoSize = true;
            this.labelZavVrijZadInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelZavVrijZadInt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZavVrijZadInt.Location = new System.Drawing.Point(296, 279);
            this.labelZavVrijZadInt.Name = "labelZavVrijZadInt";
            this.labelZavVrijZadInt.Size = new System.Drawing.Size(95, 27);
            this.labelZavVrijZadInt.TabIndex = 14;
            this.labelZavVrijZadInt.Text = "dynLab";
            this.labelZavVrijZadInt.Visible = false;
            // 
            // frmUdarci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBP_Hrvoje_Trudnoca_app.Properties.Resources.registracija;
            this.ClientSize = new System.Drawing.Size(1061, 698);
            this.Controls.Add(this.labelZavVrijZadInt);
            this.Controls.Add(this.labelPocVrijZadInt);
            this.Controls.Add(this.labelZavVrijZadIntTxt);
            this.Controls.Add(this.labelPocVrijZadIntTxt);
            this.Controls.Add(this.labelUkUdaraca);
            this.Controls.Add(this.labelKrajIntervala);
            this.Controls.Add(this.labelPocetakIntervala);
            this.Controls.Add(this.roundButtonUdarac);
            this.Controls.Add(this.labelTrajanjeSesije);
            this.Controls.Add(this.labelRazlikaVremena);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelBrojUdaraca);
            this.Controls.Add(this.dgvUdarci);
            this.Controls.Add(this.btnUdarci);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUdarci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Udarci";
            this.Load += new System.EventHandler(this.frmUdarci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdarci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private RoundButton btnUdarci;
        private System.Windows.Forms.DataGridView dgvUdarci;
        private System.Windows.Forms.Label labelBrojUdaraca;
        private RoundButton btnStop;
        private System.Windows.Forms.Label labelRazlikaVremena;
        private System.Windows.Forms.Label labelTrajanjeSesije;
        private RoundButton roundButtonUdarac;
        private System.Windows.Forms.Label labelPocetakIntervala;
        private System.Windows.Forms.Label labelKrajIntervala;
        private System.Windows.Forms.Label labelUkUdaraca;
        private System.Windows.Forms.Label labelPocVrijZadIntTxt;
        private System.Windows.Forms.Label labelZavVrijZadIntTxt;
        private System.Windows.Forms.Label labelPocVrijZadInt;
        private System.Windows.Forms.Label labelZavVrijZadInt;
    }
}