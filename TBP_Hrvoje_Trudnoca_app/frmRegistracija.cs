using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Hrvoje_Trudnoca_app
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracijaNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtvoriPocetnuFormu();
        }

        private void OtvoriPocetnuFormu()
        {
            frmPocetna pocetnaForma = new frmPocetna();
            pocetnaForma.ShowDialog();
        }

        private void btnRegistrirajMe_Click(object sender, EventArgs e)
        {
            RefreshGUI();

            if(ProvjeriUnose() == true)
            {
                RegistrirajMe();
                this.Hide();
                OtvoriPocetnuFormu();
            }
        }

        private void RefreshGUI()
        {
            labelKorisnickoImeProvjeri.Visible = false;
            labelKorisnickoImeDuzina.Visible = false;
            labelLozinkaPrazna.Visible = false;
            labelLozinkaDuzina.Visible = false;
            labelImePrazno.Visible = false;
            labelImeDuzina.Visible = false;
            labelGodinaPrazna.Visible = false;
            labelEmailDuzina.Visible = false;
            labelEmailNeispravan.Visible = false;
            labelPonovljenaLozinkaPogresna.Visible = false;
            labelKorImeZauzeto.Visible = false;
        }

        private bool ProvjeriUnose()
        {
           
            if (tbKorisnickoImeRegistracija.Text == string.Empty)
                labelKorisnickoImeProvjeri.Visible = true;

            if (tbKorisnickoImeRegistracija.TextLength > 50)
                labelKorisnickoImeDuzina.Visible = true;

            if (tbLozinka.Text == string.Empty)
                labelLozinkaPrazna.Visible = true;

            if (tbLozinka.TextLength > 50)
                labelLozinkaDuzina.Visible = true;

            if (tbIme.Text == string.Empty)
                labelImePrazno.Visible = true;

            if (tbIme.TextLength > 50)
                labelImeDuzina.Visible = true;

            if (cbGodine.SelectedItem == null)
                labelGodinaPrazna.Visible = true;

            if (tbEmail.TextLength > 50)
                labelEmailDuzina.Visible = true;

            if (ProvjeriEmail() == false)
                labelEmailNeispravan.Visible = true;

            if (ProvjeriDupliEmail() == true)
                labelEmailNeispravan.Visible = true;

            if (tbPonovljenaLozinka.Text != tbLozinka.Text)
                labelPonovljenaLozinkaPogresna.Visible = true;

            if (ProvjeriDuploKorisnickoIme() == true)
                labelKorImeZauzeto.Visible = true;

            if (labelLozinkaPrazna.Visible == true || labelKorisnickoImeDuzina.Visible == true || labelKorisnickoImeProvjeri.Visible == true || labelLozinkaDuzina.Visible == true || labelImePrazno.Visible == true || labelImeDuzina.Visible == true || labelGodinaPrazna.Visible == true || labelEmailNeispravan.Visible == true  || labelPonovljenaLozinkaPogresna.Visible == true || labelEmailDuzina.Visible == true || labelKorImeZauzeto.Visible == true)
                return false;

            return true;
        }

        private bool ProvjeriEmail()
        {
            string email = tbEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
                return true;
            else
            {
                labelEmailNeispravan.Visible = true;
                return false;
            }
        }

        private bool ProvjeriDupliEmail()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            select k.Email;

                foreach (var item in query)
                {
                    if (item == tbEmail.Text)
                        return true;
                }
            }

            return false;
        }

        private bool ProvjeriDuploKorisnickoIme()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            select k.KorisnickoIme;

                foreach (var item in query)
                {
                    if (item == tbKorisnickoImeRegistracija.Text)
                        return true;
                }
            }

            return false;
        }

        private void RegistrirajMe()
        {
            using (var context = new TrudnocaAppEntities())
            {
                string korisnickoIme = tbKorisnickoImeRegistracija.Text;
                string lozinka = tbLozinka.Text;
                string ime = tbIme.Text;
                int godine = int.Parse(cbGodine.SelectedItem.ToString());
                DateTime dueDate = dtpDueDate.Value.Date;
                string email = tbEmail.Text;

                if (rbPrvaTrudnocaDa.Checked == true)
                {
                    Korisnici noviKorisnik = new Korisnici
                    {
                        KorisnickoIme = korisnickoIme,
                        Lozinka = lozinka,
                        Ime = ime,
                        Godine = godine,
                        PrvaTrudnoca = true,
                        DueDate = dueDate,
                        Email = email
                    };

                    context.Korisnici.Add(noviKorisnik);
                    context.SaveChanges();
                }
                else if (rbPrvaTrudnocaNe.Checked == true)
                {
                    Korisnici noviKorisnik = new Korisnici
                    {
                        KorisnickoIme = korisnickoIme,
                        Lozinka = lozinka,
                        Ime = ime,
                        Godine = godine,
                        PrvaTrudnoca = false,
                        DueDate = dueDate,
                        Email = email
                    };

                    context.Korisnici.Add(noviKorisnik);
                    context.SaveChanges();
                }
            }

            Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            dtpDueDate.Value = DateTime.Today;

            int godina = DateTime.Now.Year;
            int mjesec = DateTime.Now.Month;
            int dan = DateTime.Now.Day;

            if(mjesec > 2)
                dtpDueDate.MaxDate = new DateTime(godina + 1, mjesec - 2, dan);
            else
                dtpDueDate.MaxDate = new DateTime(godina, mjesec + 10, dan);
        }
    }
}
