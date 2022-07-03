namespace TBP_Hrvoje_Trudnoca_app
{
    partial class frmAzurirajKorisnika
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
            this.labelEmailDuzina = new System.Windows.Forms.Label();
            this.labelEmailNeispravan = new System.Windows.Forms.Label();
            this.labelImeDuzina = new System.Windows.Forms.Label();
            this.labelImePrazno = new System.Windows.Forms.Label();
            this.labelKorisnickoImeDuzina = new System.Windows.Forms.Label();
            this.labelKorisnickoImeProvjeri = new System.Windows.Forms.Label();
            this.tbEmailAzuriraj = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.dtpDueDateAzuriraj = new System.Windows.Forms.DateTimePicker();
            this.cbGodineAzuriraj = new System.Windows.Forms.ComboBox();
            this.btnPovratakUAplikaciju = new System.Windows.Forms.Button();
            this.tbImeAzuriraj = new System.Windows.Forms.TextBox();
            this.tbPotvrdiLozinkuAzuriraj = new System.Windows.Forms.TextBox();
            this.tbKorisnickoImeAzuriranje = new System.Windows.Forms.TextBox();
            this.btnAzurirajPodatke = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPrvaTrudnocaNeAzuriraj = new System.Windows.Forms.RadioButton();
            this.rbPrvaTrudnocaDaAzuriraj = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPraveGodine = new System.Windows.Forms.Label();
            this.labelLozinkaNeispravna = new System.Windows.Forms.Label();
            this.labelNemaPromjena = new System.Windows.Forms.Label();
            this.labelKorImeZauzeto = new System.Windows.Forms.Label();
            this.labelPomocnaLozinka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmailDuzina
            // 
            this.labelEmailDuzina.AutoSize = true;
            this.labelEmailDuzina.BackColor = System.Drawing.Color.PowderBlue;
            this.labelEmailDuzina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmailDuzina.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailDuzina.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelEmailDuzina.Location = new System.Drawing.Point(492, 154);
            this.labelEmailDuzina.Name = "labelEmailDuzina";
            this.labelEmailDuzina.Size = new System.Drawing.Size(345, 18);
            this.labelEmailDuzina.TabIndex = 61;
            this.labelEmailDuzina.Text = "Email ne može sadržavati više od 50 znakova!";
            this.labelEmailDuzina.Visible = false;
            // 
            // labelEmailNeispravan
            // 
            this.labelEmailNeispravan.AutoSize = true;
            this.labelEmailNeispravan.BackColor = System.Drawing.Color.PowderBlue;
            this.labelEmailNeispravan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmailNeispravan.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailNeispravan.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelEmailNeispravan.Location = new System.Drawing.Point(528, 154);
            this.labelEmailNeispravan.Name = "labelEmailNeispravan";
            this.labelEmailNeispravan.Size = new System.Drawing.Size(242, 18);
            this.labelEmailNeispravan.TabIndex = 59;
            this.labelEmailNeispravan.Text = "Email nije u ispravnom formatu!";
            this.labelEmailNeispravan.Visible = false;
            // 
            // labelImeDuzina
            // 
            this.labelImeDuzina.AutoSize = true;
            this.labelImeDuzina.BackColor = System.Drawing.Color.PowderBlue;
            this.labelImeDuzina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImeDuzina.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeDuzina.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelImeDuzina.Location = new System.Drawing.Point(65, 154);
            this.labelImeDuzina.Name = "labelImeDuzina";
            this.labelImeDuzina.Size = new System.Drawing.Size(334, 18);
            this.labelImeDuzina.TabIndex = 57;
            this.labelImeDuzina.Text = "Ime ne može sadržavati više od 50 znakova!";
            this.labelImeDuzina.Visible = false;
            // 
            // labelImePrazno
            // 
            this.labelImePrazno.AutoSize = true;
            this.labelImePrazno.BackColor = System.Drawing.Color.PowderBlue;
            this.labelImePrazno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImePrazno.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImePrazno.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelImePrazno.Location = new System.Drawing.Point(91, 154);
            this.labelImePrazno.Name = "labelImePrazno";
            this.labelImePrazno.Size = new System.Drawing.Size(191, 18);
            this.labelImePrazno.TabIndex = 56;
            this.labelImePrazno.Text = "Ime ne smije biti prazno!";
            this.labelImePrazno.Visible = false;
            // 
            // labelKorisnickoImeDuzina
            // 
            this.labelKorisnickoImeDuzina.AutoSize = true;
            this.labelKorisnickoImeDuzina.BackColor = System.Drawing.Color.PowderBlue;
            this.labelKorisnickoImeDuzina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKorisnickoImeDuzina.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoImeDuzina.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelKorisnickoImeDuzina.Location = new System.Drawing.Point(54, 71);
            this.labelKorisnickoImeDuzina.Name = "labelKorisnickoImeDuzina";
            this.labelKorisnickoImeDuzina.Size = new System.Drawing.Size(409, 18);
            this.labelKorisnickoImeDuzina.TabIndex = 53;
            this.labelKorisnickoImeDuzina.Text = "Korisničko ime ne može sadržavati više od 50 znakova!";
            this.labelKorisnickoImeDuzina.Visible = false;
            // 
            // labelKorisnickoImeProvjeri
            // 
            this.labelKorisnickoImeProvjeri.AutoSize = true;
            this.labelKorisnickoImeProvjeri.BackColor = System.Drawing.Color.PowderBlue;
            this.labelKorisnickoImeProvjeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKorisnickoImeProvjeri.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoImeProvjeri.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelKorisnickoImeProvjeri.Location = new System.Drawing.Point(133, 71);
            this.labelKorisnickoImeProvjeri.Name = "labelKorisnickoImeProvjeri";
            this.labelKorisnickoImeProvjeri.Size = new System.Drawing.Size(266, 18);
            this.labelKorisnickoImeProvjeri.TabIndex = 52;
            this.labelKorisnickoImeProvjeri.Text = "Korisničko ime ne smije biti prazno!";
            this.labelKorisnickoImeProvjeri.Visible = false;
            // 
            // tbEmailAzuriraj
            // 
            this.tbEmailAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.tbEmailAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAzuriraj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEmailAzuriraj.Location = new System.Drawing.Point(542, 125);
            this.tbEmailAzuriraj.Name = "tbEmailAzuriraj";
            this.tbEmailAzuriraj.Size = new System.Drawing.Size(190, 26);
            this.tbEmailAzuriraj.TabIndex = 51;
            this.tbEmailAzuriraj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Pink;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Green;
            this.labelEmail.Location = new System.Drawing.Point(460, 128);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 20);
            this.labelEmail.TabIndex = 50;
            this.labelEmail.Text = "Email :";
            // 
            // dtpDueDateAzuriraj
            // 
            this.dtpDueDateAzuriraj.CalendarFont = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDateAzuriraj.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDueDateAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDateAzuriraj.Location = new System.Drawing.Point(542, 255);
            this.dtpDueDateAzuriraj.MinDate = new System.DateTime(2022, 6, 30, 0, 0, 0, 0);
            this.dtpDueDateAzuriraj.Name = "dtpDueDateAzuriraj";
            this.dtpDueDateAzuriraj.Size = new System.Drawing.Size(319, 26);
            this.dtpDueDateAzuriraj.TabIndex = 49;
            // 
            // cbGodineAzuriraj
            // 
            this.cbGodineAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.cbGodineAzuriraj.DropDownHeight = 120;
            this.cbGodineAzuriraj.DropDownWidth = 40;
            this.cbGodineAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGodineAzuriraj.FormattingEnabled = true;
            this.cbGodineAzuriraj.IntegralHeight = false;
            this.cbGodineAzuriraj.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.cbGodineAzuriraj.Location = new System.Drawing.Point(184, 199);
            this.cbGodineAzuriraj.Name = "cbGodineAzuriraj";
            this.cbGodineAzuriraj.Size = new System.Drawing.Size(80, 26);
            this.cbGodineAzuriraj.TabIndex = 48;
            // 
            // btnPovratakUAplikaciju
            // 
            this.btnPovratakUAplikaciju.BackColor = System.Drawing.Color.Gold;
            this.btnPovratakUAplikaciju.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratakUAplikaciju.ForeColor = System.Drawing.Color.Indigo;
            this.btnPovratakUAplikaciju.Location = new System.Drawing.Point(702, 476);
            this.btnPovratakUAplikaciju.Name = "btnPovratakUAplikaciju";
            this.btnPovratakUAplikaciju.Size = new System.Drawing.Size(159, 53);
            this.btnPovratakUAplikaciju.TabIndex = 47;
            this.btnPovratakUAplikaciju.Text = "Povratak";
            this.btnPovratakUAplikaciju.UseVisualStyleBackColor = false;
            this.btnPovratakUAplikaciju.Click += new System.EventHandler(this.btnPovratakUAplikaciju_Click);
            // 
            // tbImeAzuriraj
            // 
            this.tbImeAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.tbImeAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImeAzuriraj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbImeAzuriraj.Location = new System.Drawing.Point(99, 125);
            this.tbImeAzuriraj.Name = "tbImeAzuriraj";
            this.tbImeAzuriraj.Size = new System.Drawing.Size(180, 26);
            this.tbImeAzuriraj.TabIndex = 46;
            this.tbImeAzuriraj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPotvrdiLozinkuAzuriraj
            // 
            this.tbPotvrdiLozinkuAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.tbPotvrdiLozinkuAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPotvrdiLozinkuAzuriraj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPotvrdiLozinkuAzuriraj.Location = new System.Drawing.Point(184, 386);
            this.tbPotvrdiLozinkuAzuriraj.Name = "tbPotvrdiLozinkuAzuriraj";
            this.tbPotvrdiLozinkuAzuriraj.PasswordChar = '*';
            this.tbPotvrdiLozinkuAzuriraj.Size = new System.Drawing.Size(151, 26);
            this.tbPotvrdiLozinkuAzuriraj.TabIndex = 45;
            this.tbPotvrdiLozinkuAzuriraj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKorisnickoImeAzuriranje
            // 
            this.tbKorisnickoImeAzuriranje.BackColor = System.Drawing.Color.Pink;
            this.tbKorisnickoImeAzuriranje.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoImeAzuriranje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbKorisnickoImeAzuriranje.Location = new System.Drawing.Point(184, 42);
            this.tbKorisnickoImeAzuriranje.Name = "tbKorisnickoImeAzuriranje";
            this.tbKorisnickoImeAzuriranje.ReadOnly = true;
            this.tbKorisnickoImeAzuriranje.Size = new System.Drawing.Size(186, 26);
            this.tbKorisnickoImeAzuriranje.TabIndex = 43;
            this.tbKorisnickoImeAzuriranje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAzurirajPodatke
            // 
            this.btnAzurirajPodatke.BackColor = System.Drawing.Color.Gold;
            this.btnAzurirajPodatke.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajPodatke.ForeColor = System.Drawing.Color.Indigo;
            this.btnAzurirajPodatke.Location = new System.Drawing.Point(99, 446);
            this.btnAzurirajPodatke.Name = "btnAzurirajPodatke";
            this.btnAzurirajPodatke.Size = new System.Drawing.Size(165, 62);
            this.btnAzurirajPodatke.TabIndex = 42;
            this.btnAzurirajPodatke.Text = "Ažuriraj!";
            this.btnAzurirajPodatke.UseVisualStyleBackColor = false;
            this.btnAzurirajPodatke.Click += new System.EventHandler(this.btnAzurirajPodatke_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Pink;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(14, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Prva trudnoća?";
            // 
            // rbPrvaTrudnocaNeAzuriraj
            // 
            this.rbPrvaTrudnocaNeAzuriraj.AutoSize = true;
            this.rbPrvaTrudnocaNeAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.rbPrvaTrudnocaNeAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrvaTrudnocaNeAzuriraj.Location = new System.Drawing.Point(230, 256);
            this.rbPrvaTrudnocaNeAzuriraj.Name = "rbPrvaTrudnocaNeAzuriraj";
            this.rbPrvaTrudnocaNeAzuriraj.Size = new System.Drawing.Size(49, 22);
            this.rbPrvaTrudnocaNeAzuriraj.TabIndex = 40;
            this.rbPrvaTrudnocaNeAzuriraj.TabStop = true;
            this.rbPrvaTrudnocaNeAzuriraj.Text = "NE";
            this.rbPrvaTrudnocaNeAzuriraj.UseVisualStyleBackColor = false;
            // 
            // rbPrvaTrudnocaDaAzuriraj
            // 
            this.rbPrvaTrudnocaDaAzuriraj.AutoSize = true;
            this.rbPrvaTrudnocaDaAzuriraj.BackColor = System.Drawing.Color.Pink;
            this.rbPrvaTrudnocaDaAzuriraj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrvaTrudnocaDaAzuriraj.Location = new System.Drawing.Point(174, 256);
            this.rbPrvaTrudnocaDaAzuriraj.Name = "rbPrvaTrudnocaDaAzuriraj";
            this.rbPrvaTrudnocaDaAzuriraj.Size = new System.Drawing.Size(50, 22);
            this.rbPrvaTrudnocaDaAzuriraj.TabIndex = 39;
            this.rbPrvaTrudnocaDaAzuriraj.TabStop = true;
            this.rbPrvaTrudnocaDaAzuriraj.Text = "DA";
            this.rbPrvaTrudnocaDaAzuriraj.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Godine :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(430, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Due date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(14, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ime :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Potvrdi lozinku :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Korisničko ime :";
            // 
            // labelPraveGodine
            // 
            this.labelPraveGodine.AutoSize = true;
            this.labelPraveGodine.Location = new System.Drawing.Point(119, 204);
            this.labelPraveGodine.Name = "labelPraveGodine";
            this.labelPraveGodine.Size = new System.Drawing.Size(51, 16);
            this.labelPraveGodine.TabIndex = 62;
            this.labelPraveGodine.Text = "DLabel";
            // 
            // labelLozinkaNeispravna
            // 
            this.labelLozinkaNeispravna.AutoSize = true;
            this.labelLozinkaNeispravna.BackColor = System.Drawing.Color.PowderBlue;
            this.labelLozinkaNeispravna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLozinkaNeispravna.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinkaNeispravna.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLozinkaNeispravna.Location = new System.Drawing.Point(143, 415);
            this.labelLozinkaNeispravna.Name = "labelLozinkaNeispravna";
            this.labelLozinkaNeispravna.Size = new System.Drawing.Size(168, 18);
            this.labelLozinkaNeispravna.TabIndex = 64;
            this.labelLozinkaNeispravna.Text = "Lozinka nije ispravna!";
            this.labelLozinkaNeispravna.Visible = false;
            // 
            // labelNemaPromjena
            // 
            this.labelNemaPromjena.AutoSize = true;
            this.labelNemaPromjena.BackColor = System.Drawing.Color.PowderBlue;
            this.labelNemaPromjena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNemaPromjena.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNemaPromjena.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelNemaPromjena.Location = new System.Drawing.Point(54, 511);
            this.labelNemaPromjena.Name = "labelNemaPromjena";
            this.labelNemaPromjena.Size = new System.Drawing.Size(253, 18);
            this.labelNemaPromjena.TabIndex = 65;
            this.labelNemaPromjena.Text = "Niste napravili nikakve promjene!";
            this.labelNemaPromjena.Visible = false;
            // 
            // labelKorImeZauzeto
            // 
            this.labelKorImeZauzeto.AutoSize = true;
            this.labelKorImeZauzeto.BackColor = System.Drawing.Color.PowderBlue;
            this.labelKorImeZauzeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKorImeZauzeto.Font = new System.Drawing.Font("Verdana", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorImeZauzeto.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelKorImeZauzeto.Location = new System.Drawing.Point(184, 71);
            this.labelKorImeZauzeto.Name = "labelKorImeZauzeto";
            this.labelKorImeZauzeto.Size = new System.Drawing.Size(199, 18);
            this.labelKorImeZauzeto.TabIndex = 66;
            this.labelKorImeZauzeto.Text = "Korisničko ime je zauzeto!";
            this.labelKorImeZauzeto.Visible = false;
            // 
            // labelPomocnaLozinka
            // 
            this.labelPomocnaLozinka.AutoSize = true;
            this.labelPomocnaLozinka.Location = new System.Drawing.Point(11, 357);
            this.labelPomocnaLozinka.Name = "labelPomocnaLozinka";
            this.labelPomocnaLozinka.Size = new System.Drawing.Size(56, 16);
            this.labelPomocnaLozinka.TabIndex = 67;
            this.labelPomocnaLozinka.Text = "PomLoz";
            this.labelPomocnaLozinka.Visible = false;
            // 
            // frmAzurirajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::TBP_Hrvoje_Trudnoca_app.Properties.Resources.registracija;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelPomocnaLozinka);
            this.Controls.Add(this.labelKorImeZauzeto);
            this.Controls.Add(this.labelNemaPromjena);
            this.Controls.Add(this.labelLozinkaNeispravna);
            this.Controls.Add(this.labelPraveGodine);
            this.Controls.Add(this.labelEmailDuzina);
            this.Controls.Add(this.labelEmailNeispravan);
            this.Controls.Add(this.labelImeDuzina);
            this.Controls.Add(this.labelImePrazno);
            this.Controls.Add(this.labelKorisnickoImeDuzina);
            this.Controls.Add(this.labelKorisnickoImeProvjeri);
            this.Controls.Add(this.tbEmailAzuriraj);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dtpDueDateAzuriraj);
            this.Controls.Add(this.cbGodineAzuriraj);
            this.Controls.Add(this.btnPovratakUAplikaciju);
            this.Controls.Add(this.tbImeAzuriraj);
            this.Controls.Add(this.tbPotvrdiLozinkuAzuriraj);
            this.Controls.Add(this.tbKorisnickoImeAzuriranje);
            this.Controls.Add(this.btnAzurirajPodatke);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbPrvaTrudnocaNeAzuriraj);
            this.Controls.Add(this.rbPrvaTrudnocaDaAzuriraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAzurirajKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj podatke";
            this.Load += new System.EventHandler(this.frmAzurirajKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmailDuzina;
        private System.Windows.Forms.Label labelEmailNeispravan;
        private System.Windows.Forms.Label labelImeDuzina;
        private System.Windows.Forms.Label labelImePrazno;
        private System.Windows.Forms.Label labelKorisnickoImeDuzina;
        private System.Windows.Forms.Label labelKorisnickoImeProvjeri;
        private System.Windows.Forms.TextBox tbEmailAzuriraj;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker dtpDueDateAzuriraj;
        private System.Windows.Forms.ComboBox cbGodineAzuriraj;
        private System.Windows.Forms.Button btnPovratakUAplikaciju;
        private System.Windows.Forms.TextBox tbImeAzuriraj;
        private System.Windows.Forms.TextBox tbPotvrdiLozinkuAzuriraj;
        private System.Windows.Forms.TextBox tbKorisnickoImeAzuriranje;
        private System.Windows.Forms.Button btnAzurirajPodatke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPrvaTrudnocaNeAzuriraj;
        private System.Windows.Forms.RadioButton rbPrvaTrudnocaDaAzuriraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPraveGodine;
        private System.Windows.Forms.Label labelLozinkaNeispravna;
        private System.Windows.Forms.Label labelNemaPromjena;
        private System.Windows.Forms.Label labelKorImeZauzeto;
        private System.Windows.Forms.Label labelPomocnaLozinka;
    }
}