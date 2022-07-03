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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUdarci));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnUdarci = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.dgvUdarci = new System.Windows.Forms.DataGridView();
            this.labelBrojUdaraca = new System.Windows.Forms.Label();
            this.btnStop = new TBP_Hrvoje_Trudnoca_app.RoundButton();
            this.labelRazlikaVremena = new System.Windows.Forms.Label();
            this.labelTrajanjeSesije = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdarci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Gold;
            this.btnPovratak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.ForeColor = System.Drawing.Color.Indigo;
            this.btnPovratak.Location = new System.Drawing.Point(738, 483);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(132, 58);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnUdarci
            // 
            this.btnUdarci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUdarci.BackgroundImage")));
            this.btnUdarci.Location = new System.Drawing.Point(34, 27);
            this.btnUdarci.Name = "btnUdarci";
            this.btnUdarci.Size = new System.Drawing.Size(125, 125);
            this.btnUdarci.TabIndex = 1;
            this.btnUdarci.UseVisualStyleBackColor = true;
            this.btnUdarci.Click += new System.EventHandler(this.btnUdarci_Click);
            // 
            // dgvUdarci
            // 
            this.dgvUdarci.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUdarci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdarci.Location = new System.Drawing.Point(12, 192);
            this.dgvUdarci.Name = "dgvUdarci";
            this.dgvUdarci.RowHeadersWidth = 51;
            this.dgvUdarci.RowTemplate.Height = 24;
            this.dgvUdarci.Size = new System.Drawing.Size(705, 349);
            this.dgvUdarci.TabIndex = 2;
            // 
            // labelBrojUdaraca
            // 
            this.labelBrojUdaraca.AutoSize = true;
            this.labelBrojUdaraca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelBrojUdaraca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBrojUdaraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojUdaraca.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelBrojUdaraca.Location = new System.Drawing.Point(196, 67);
            this.labelBrojUdaraca.Name = "labelBrojUdaraca";
            this.labelBrojUdaraca.Size = new System.Drawing.Size(208, 54);
            this.labelBrojUdaraca.TabIndex = 3;
            this.labelBrojUdaraca.Text = "dynLabel";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.Location = new System.Drawing.Point(410, 27);
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
            this.labelRazlikaVremena.Location = new System.Drawing.Point(775, 51);
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
            this.labelTrajanjeSesije.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrajanjeSesije.ForeColor = System.Drawing.Color.Green;
            this.labelTrajanjeSesije.Location = new System.Drawing.Point(555, 18);
            this.labelTrajanjeSesije.Name = "labelTrajanjeSesije";
            this.labelTrajanjeSesije.Size = new System.Drawing.Size(296, 22);
            this.labelTrajanjeSesije.TabIndex = 6;
            this.labelTrajanjeSesije.Text = "Trajanje sesije u sekundama :";
            this.labelTrajanjeSesije.Visible = false;
            // 
            // frmUdarci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBP_Hrvoje_Trudnoca_app.Properties.Resources.registracija;
            this.ClientSize = new System.Drawing.Size(882, 553);
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
    }
}