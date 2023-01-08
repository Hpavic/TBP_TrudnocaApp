namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmRekreacija
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
            this.dgvTemporalRekreacija = new System.Windows.Forms.DataGridView();
            this.dgvPovijestRekreacija = new System.Windows.Forms.DataGridView();
            this.btnKreniUSetnju = new System.Windows.Forms.Button();
            this.tbTrajanjeSetnje = new System.Windows.Forms.TextBox();
            this.labelTrajanjeSetnje = new System.Windows.Forms.Label();
            this.btnZavrsiSetnju = new System.Windows.Forms.Button();
            this.labelNovaRekreacija = new System.Windows.Forms.Label();
            this.textBoxNovaRekreacija = new System.Windows.Forms.TextBox();
            this.buttonDodajNovuRekreaciju = new System.Windows.Forms.Button();
            this.textBoxTrenutniNazivRekreacije = new System.Windows.Forms.TextBox();
            this.labelTrenutniNazivRekreacije = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemporalRekreacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestRekreacija)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.BackColor = System.Drawing.Color.Gold;
            this.buttonPovratak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPovratak.ForeColor = System.Drawing.Color.Indigo;
            this.buttonPovratak.Location = new System.Drawing.Point(1098, 12);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(131, 62);
            this.buttonPovratak.TabIndex = 0;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = false;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // dgvTemporalRekreacija
            // 
            this.dgvTemporalRekreacija.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvTemporalRekreacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemporalRekreacija.Location = new System.Drawing.Point(13, 102);
            this.dgvTemporalRekreacija.Name = "dgvTemporalRekreacija";
            this.dgvTemporalRekreacija.RowHeadersWidth = 51;
            this.dgvTemporalRekreacija.RowTemplate.Height = 24;
            this.dgvTemporalRekreacija.Size = new System.Drawing.Size(908, 193);
            this.dgvTemporalRekreacija.TabIndex = 1;
            this.dgvTemporalRekreacija.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTemporalRekreacija_CellMouseClick);
            // 
            // dgvPovijestRekreacija
            // 
            this.dgvPovijestRekreacija.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvPovijestRekreacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestRekreacija.Location = new System.Drawing.Point(13, 392);
            this.dgvPovijestRekreacija.Name = "dgvPovijestRekreacija";
            this.dgvPovijestRekreacija.RowHeadersWidth = 51;
            this.dgvPovijestRekreacija.RowTemplate.Height = 24;
            this.dgvPovijestRekreacija.Size = new System.Drawing.Size(907, 204);
            this.dgvPovijestRekreacija.TabIndex = 2;
            // 
            // btnKreniUSetnju
            // 
            this.btnKreniUSetnju.BackColor = System.Drawing.Color.Gold;
            this.btnKreniUSetnju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreniUSetnju.ForeColor = System.Drawing.Color.Indigo;
            this.btnKreniUSetnju.Location = new System.Drawing.Point(939, 228);
            this.btnKreniUSetnju.Name = "btnKreniUSetnju";
            this.btnKreniUSetnju.Size = new System.Drawing.Size(235, 67);
            this.btnKreniUSetnju.TabIndex = 4;
            this.btnKreniUSetnju.Text = "KRENI U ŠETNJU";
            this.btnKreniUSetnju.UseVisualStyleBackColor = false;
            this.btnKreniUSetnju.Click += new System.EventHandler(this.btnKreniUSetnju_Click);
            // 
            // tbTrajanjeSetnje
            // 
            this.tbTrajanjeSetnje.Location = new System.Drawing.Point(939, 427);
            this.tbTrajanjeSetnje.Name = "tbTrajanjeSetnje";
            this.tbTrajanjeSetnje.Size = new System.Drawing.Size(100, 22);
            this.tbTrajanjeSetnje.TabIndex = 6;
            // 
            // labelTrajanjeSetnje
            // 
            this.labelTrajanjeSetnje.AutoSize = true;
            this.labelTrajanjeSetnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrajanjeSetnje.Location = new System.Drawing.Point(936, 392);
            this.labelTrajanjeSetnje.Name = "labelTrajanjeSetnje";
            this.labelTrajanjeSetnje.Size = new System.Drawing.Size(201, 18);
            this.labelTrajanjeSetnje.TabIndex = 7;
            this.labelTrajanjeSetnje.Text = "Trajanje rekreacije (min) :";
            // 
            // btnZavrsiSetnju
            // 
            this.btnZavrsiSetnju.BackColor = System.Drawing.Color.Gold;
            this.btnZavrsiSetnju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsiSetnju.ForeColor = System.Drawing.Color.Indigo;
            this.btnZavrsiSetnju.Location = new System.Drawing.Point(939, 499);
            this.btnZavrsiSetnju.Name = "btnZavrsiSetnju";
            this.btnZavrsiSetnju.Size = new System.Drawing.Size(235, 67);
            this.btnZavrsiSetnju.TabIndex = 8;
            this.btnZavrsiSetnju.Text = "ZAVRŠI ŠETNJU";
            this.btnZavrsiSetnju.UseVisualStyleBackColor = false;
            this.btnZavrsiSetnju.Click += new System.EventHandler(this.btnZavrsiSetnju_Click);
            // 
            // labelNovaRekreacija
            // 
            this.labelNovaRekreacija.AutoSize = true;
            this.labelNovaRekreacija.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaRekreacija.ForeColor = System.Drawing.Color.Green;
            this.labelNovaRekreacija.Location = new System.Drawing.Point(13, 13);
            this.labelNovaRekreacija.Name = "labelNovaRekreacija";
            this.labelNovaRekreacija.Size = new System.Drawing.Size(232, 20);
            this.labelNovaRekreacija.TabIndex = 9;
            this.labelNovaRekreacija.Text = "Dodaj novu rekreaciju :";
            // 
            // textBoxNovaRekreacija
            // 
            this.textBoxNovaRekreacija.Location = new System.Drawing.Point(17, 52);
            this.textBoxNovaRekreacija.Name = "textBoxNovaRekreacija";
            this.textBoxNovaRekreacija.Size = new System.Drawing.Size(217, 22);
            this.textBoxNovaRekreacija.TabIndex = 10;
            // 
            // buttonDodajNovuRekreaciju
            // 
            this.buttonDodajNovuRekreaciju.BackColor = System.Drawing.Color.Gold;
            this.buttonDodajNovuRekreaciju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajNovuRekreaciju.ForeColor = System.Drawing.Color.Indigo;
            this.buttonDodajNovuRekreaciju.Location = new System.Drawing.Point(295, 22);
            this.buttonDodajNovuRekreaciju.Name = "buttonDodajNovuRekreaciju";
            this.buttonDodajNovuRekreaciju.Size = new System.Drawing.Size(157, 42);
            this.buttonDodajNovuRekreaciju.TabIndex = 11;
            this.buttonDodajNovuRekreaciju.Text = "DODAJ";
            this.buttonDodajNovuRekreaciju.UseVisualStyleBackColor = false;
            this.buttonDodajNovuRekreaciju.Click += new System.EventHandler(this.buttonDodajNovuRekreaciju_Click);
            // 
            // textBoxTrenutniNazivRekreacije
            // 
            this.textBoxTrenutniNazivRekreacije.Location = new System.Drawing.Point(939, 123);
            this.textBoxTrenutniNazivRekreacije.Name = "textBoxTrenutniNazivRekreacije";
            this.textBoxTrenutniNazivRekreacije.ReadOnly = true;
            this.textBoxTrenutniNazivRekreacije.Size = new System.Drawing.Size(224, 22);
            this.textBoxTrenutniNazivRekreacije.TabIndex = 12;
            // 
            // labelTrenutniNazivRekreacije
            // 
            this.labelTrenutniNazivRekreacije.AutoSize = true;
            this.labelTrenutniNazivRekreacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrenutniNazivRekreacije.Location = new System.Drawing.Point(936, 102);
            this.labelTrenutniNazivRekreacije.Name = "labelTrenutniNazivRekreacije";
            this.labelTrenutniNazivRekreacije.Size = new System.Drawing.Size(202, 18);
            this.labelTrenutniNazivRekreacije.TabIndex = 13;
            this.labelTrenutniNazivRekreacije.Text = "Trenutni naziv rekreacije :";
            // 
            // frmRekreacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 618);
            this.Controls.Add(this.labelTrenutniNazivRekreacije);
            this.Controls.Add(this.textBoxTrenutniNazivRekreacije);
            this.Controls.Add(this.buttonDodajNovuRekreaciju);
            this.Controls.Add(this.textBoxNovaRekreacija);
            this.Controls.Add(this.labelNovaRekreacija);
            this.Controls.Add(this.btnZavrsiSetnju);
            this.Controls.Add(this.labelTrajanjeSetnje);
            this.Controls.Add(this.tbTrajanjeSetnje);
            this.Controls.Add(this.btnKreniUSetnju);
            this.Controls.Add(this.dgvPovijestRekreacija);
            this.Controls.Add(this.dgvTemporalRekreacija);
            this.Controls.Add(this.buttonPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRekreacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rekreacija";
            this.Load += new System.EventHandler(this.frmRekreacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemporalRekreacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestRekreacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.DataGridView dgvTemporalRekreacija;
        private System.Windows.Forms.DataGridView dgvPovijestRekreacija;
        private System.Windows.Forms.Button btnKreniUSetnju;
        private System.Windows.Forms.TextBox tbTrajanjeSetnje;
        private System.Windows.Forms.Label labelTrajanjeSetnje;
        private System.Windows.Forms.Button btnZavrsiSetnju;
        private System.Windows.Forms.Label labelNovaRekreacija;
        private System.Windows.Forms.TextBox textBoxNovaRekreacija;
        private System.Windows.Forms.Button buttonDodajNovuRekreaciju;
        private System.Windows.Forms.TextBox textBoxTrenutniNazivRekreacije;
        private System.Windows.Forms.Label labelTrenutniNazivRekreacije;
    }
}