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
            this.cbTipSetnje = new System.Windows.Forms.ComboBox();
            this.btnKreniUSetnju = new System.Windows.Forms.Button();
            this.labelVrstaSetnje = new System.Windows.Forms.Label();
            this.tbTrajanjeSetnje = new System.Windows.Forms.TextBox();
            this.labelTrajanjeSetnje = new System.Windows.Forms.Label();
            this.btnZavrsiSetnju = new System.Windows.Forms.Button();
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
            this.dgvTemporalRekreacija.Location = new System.Drawing.Point(12, 50);
            this.dgvTemporalRekreacija.Name = "dgvTemporalRekreacija";
            this.dgvTemporalRekreacija.RowHeadersWidth = 51;
            this.dgvTemporalRekreacija.RowTemplate.Height = 24;
            this.dgvTemporalRekreacija.Size = new System.Drawing.Size(908, 193);
            this.dgvTemporalRekreacija.TabIndex = 1;
            // 
            // dgvPovijestRekreacija
            // 
            this.dgvPovijestRekreacija.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvPovijestRekreacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestRekreacija.Location = new System.Drawing.Point(13, 308);
            this.dgvPovijestRekreacija.Name = "dgvPovijestRekreacija";
            this.dgvPovijestRekreacija.RowHeadersWidth = 51;
            this.dgvPovijestRekreacija.RowTemplate.Height = 24;
            this.dgvPovijestRekreacija.Size = new System.Drawing.Size(907, 204);
            this.dgvPovijestRekreacija.TabIndex = 2;
            // 
            // cbTipSetnje
            // 
            this.cbTipSetnje.FormattingEnabled = true;
            this.cbTipSetnje.Items.AddRange(new object[] {
            "Kratka setnja",
            "Srednja setnja",
            "Duga setnja"});
            this.cbTipSetnje.Location = new System.Drawing.Point(986, 102);
            this.cbTipSetnje.Name = "cbTipSetnje";
            this.cbTipSetnje.Size = new System.Drawing.Size(121, 24);
            this.cbTipSetnje.TabIndex = 3;
            // 
            // btnKreniUSetnju
            // 
            this.btnKreniUSetnju.BackColor = System.Drawing.Color.Gold;
            this.btnKreniUSetnju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreniUSetnju.ForeColor = System.Drawing.Color.Indigo;
            this.btnKreniUSetnju.Location = new System.Drawing.Point(969, 201);
            this.btnKreniUSetnju.Name = "btnKreniUSetnju";
            this.btnKreniUSetnju.Size = new System.Drawing.Size(235, 67);
            this.btnKreniUSetnju.TabIndex = 4;
            this.btnKreniUSetnju.Text = "KRENI U ŠETNJU";
            this.btnKreniUSetnju.UseVisualStyleBackColor = false;
            this.btnKreniUSetnju.Click += new System.EventHandler(this.btnKreniUSetnju_Click);
            // 
            // labelVrstaSetnje
            // 
            this.labelVrstaSetnje.AutoSize = true;
            this.labelVrstaSetnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrstaSetnje.Location = new System.Drawing.Point(983, 81);
            this.labelVrstaSetnje.Name = "labelVrstaSetnje";
            this.labelVrstaSetnje.Size = new System.Drawing.Size(107, 18);
            this.labelVrstaSetnje.TabIndex = 5;
            this.labelVrstaSetnje.Text = "Vrsta šetnje :";
            // 
            // tbTrajanjeSetnje
            // 
            this.tbTrajanjeSetnje.Location = new System.Drawing.Point(986, 328);
            this.tbTrajanjeSetnje.Name = "tbTrajanjeSetnje";
            this.tbTrajanjeSetnje.Size = new System.Drawing.Size(100, 22);
            this.tbTrajanjeSetnje.TabIndex = 6;
            // 
            // labelTrajanjeSetnje
            // 
            this.labelTrajanjeSetnje.AutoSize = true;
            this.labelTrajanjeSetnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrajanjeSetnje.Location = new System.Drawing.Point(983, 307);
            this.labelTrajanjeSetnje.Name = "labelTrajanjeSetnje";
            this.labelTrajanjeSetnje.Size = new System.Drawing.Size(172, 18);
            this.labelTrajanjeSetnje.TabIndex = 7;
            this.labelTrajanjeSetnje.Text = "Trajanje šetnje (min) :";
            // 
            // btnZavrsiSetnju
            // 
            this.btnZavrsiSetnju.BackColor = System.Drawing.Color.Gold;
            this.btnZavrsiSetnju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsiSetnju.ForeColor = System.Drawing.Color.Indigo;
            this.btnZavrsiSetnju.Location = new System.Drawing.Point(969, 381);
            this.btnZavrsiSetnju.Name = "btnZavrsiSetnju";
            this.btnZavrsiSetnju.Size = new System.Drawing.Size(235, 67);
            this.btnZavrsiSetnju.TabIndex = 8;
            this.btnZavrsiSetnju.Text = "ZAVRŠI ŠETNJU";
            this.btnZavrsiSetnju.UseVisualStyleBackColor = false;
            this.btnZavrsiSetnju.Click += new System.EventHandler(this.btnZavrsiSetnju_Click);
            // 
            // frmRekreacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 535);
            this.Controls.Add(this.btnZavrsiSetnju);
            this.Controls.Add(this.labelTrajanjeSetnje);
            this.Controls.Add(this.tbTrajanjeSetnje);
            this.Controls.Add(this.labelVrstaSetnje);
            this.Controls.Add(this.btnKreniUSetnju);
            this.Controls.Add(this.cbTipSetnje);
            this.Controls.Add(this.dgvPovijestRekreacija);
            this.Controls.Add(this.dgvTemporalRekreacija);
            this.Controls.Add(this.buttonPovratak);
            this.Name = "frmRekreacija";
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
        private System.Windows.Forms.ComboBox cbTipSetnje;
        private System.Windows.Forms.Button btnKreniUSetnju;
        private System.Windows.Forms.Label labelVrstaSetnje;
        private System.Windows.Forms.TextBox tbTrajanjeSetnje;
        private System.Windows.Forms.Label labelTrajanjeSetnje;
        private System.Windows.Forms.Button btnZavrsiSetnju;
    }
}