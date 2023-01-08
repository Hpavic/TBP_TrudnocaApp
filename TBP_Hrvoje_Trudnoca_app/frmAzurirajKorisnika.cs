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
    public partial class frmAzurirajKorisnika : Form
    {
        private readonly string korisnikovaBeba;

        public frmAzurirajKorisnika(string korisnik)
        {
            InitializeComponent();
            korisnikovaBeba = korisnik;
        }

        private void btnPovratakUAplikaciju_Click(object sender, EventArgs e)
        {
            int id = DohvatiIdKorisnika();
            this.Hide();
            frmTrudnocaAppMain frmTrudnocaApp = new frmTrudnocaAppMain(id);
            frmTrudnocaApp.ShowDialog();
        }

        private int DohvatiIdKorisnika()
        {
            int idKorisnika = 0;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.KorisnickoIme == tbKorisnickoImeAzuriranje.Text
                            select k.Id;

                foreach (var item in query)
                {
                    idKorisnika = int.Parse(item.ToString());
                }
            }

            if (idKorisnika > 0)
                return idKorisnika;
            return 0;
        }

        private void frmAzurirajKorisnika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            PostaviMaxDTP();
        }

        private void UcitajPodatke()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.KorisnickoIme == korisnikovaBeba
                            select k;

                foreach (var item in query)
                {
                    tbKorisnickoImeAzuriranje.Text = item.KorisnickoIme.ToString();
                    tbImeAzuriraj.Text = item.Ime.ToString();
                    labelPraveGodine.Text = item.Godine.ToString();
                    dtpDueDateAzuriraj.Value = item.DueDate;
                    tbEmailAzuriraj.Text = item.Email;
                    labelPomocnaLozinka.Text = item.Lozinka;
                    if(item.PrvaTrudnoca == true)
                        rbPrvaTrudnocaDaAzuriraj.Checked = true;
                    if (item.PrvaTrudnoca == false)
                        rbPrvaTrudnocaNeAzuriraj.Checked = true;
                }
            }
        }

        private void PostaviMaxDTP()
        {
            int godina = DateTime.Now.Year;
            int mjesec = DateTime.Now.Month;
            int dan = DateTime.Now.Day;

            if (mjesec > 2)
                dtpDueDateAzuriraj.MaxDate = new DateTime(godina + 1, mjesec - 2, dan);
            else
                dtpDueDateAzuriraj.MaxDate = new DateTime(godina, mjesec + 10, dan);
        }

        private void btnAzurirajPodatke_Click(object sender, EventArgs e)
        {
            RefreshGUI();

            if (tbPotvrdiLozinkuAzuriraj.Text != labelPomocnaLozinka.Text)
            {
                labelLozinkaNeispravna.Visible = true;
            }
            else
            {
                if (ProvjeriUnose() == true)
                    IzvrsiAzuriranje();
            } 
                
        }

        private void RefreshGUI()
        {
            labelLozinkaNeispravna.Visible = false;
            //labelKorisnickoImeProvjeri.Visible = false;
            //labelKorisnickoImeDuzina.Visible = false;
            labelImePrazno.Visible = false;
            labelImeDuzina.Visible = false;
            labelEmailDuzina.Visible = false;
            labelEmailNeispravan.Visible = false;
            labelNemaPromjena.Visible = false;
            //labelKorImeZauzeto.Visible = false;
        }

        private bool ProvjeriUnose()
        {
            //if (tbKorisnickoImeAzuriranje.Text == string.Empty)
            //    labelKorisnickoImeProvjeri.Visible = true;

            //if (tbKorisnickoImeAzuriranje.TextLength > 50)
            //    labelKorisnickoImeDuzina.Visible = true;

            if (tbImeAzuriraj.Text == string.Empty)
                labelImePrazno.Visible = true;

            if (tbImeAzuriraj.TextLength > 50)
                labelImeDuzina.Visible = true;

            if (tbEmailAzuriraj.TextLength > 50)
                labelEmailDuzina.Visible = true;

            if (ProvjeriEmail() == false)
                labelEmailNeispravan.Visible = true;

            //if (ProvjeriDuploKorisnickoIme() == true)
            //    labelKorImeZauzeto.Visible = true;

            if (labelImePrazno.Visible == true || labelImeDuzina.Visible == true || labelEmailNeispravan.Visible == true || labelEmailDuzina.Visible == true)
                return false;

            return true;
        }

        private bool ProvjeriEmail()
        {
            string email = tbEmailAzuriraj.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
                return true;
            else
                return false;
        }

        //private bool ProvjeriDuploKorisnickoIme()
        //{
        //    using (var context = new TrudnocaAppEntities())
        //    {
        //        var query = from k in context.Korisnici
        //                    where k.KorisnickoIme != korisnikovaBeba
        //                    select k.KorisnickoIme;

        //        foreach (var item in query)
        //        {
        //            if (item == tbKorisnickoImeAzuriranje.Text)
        //                return true;
        //        }
        //    }

        //    return false;
        //}

        private void IzvrsiAzuriranje()
        {
            int brojacPromjena = 0;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.KorisnickoIme == korisnikovaBeba
                            select k;

                foreach (Korisnici item in query)
                {
                    //if (item.KorisnickoIme != tbKorisnickoImeAzuriranje.Text)
                    //{
                    //    item.KorisnickoIme = tbKorisnickoImeAzuriranje.Text;
                    //    brojacPromjena++;
                    //}
                    if (tbImeAzuriraj.Text != item.Ime)
                    {
                        item.Ime = tbImeAzuriraj.Text;
                        brojacPromjena++;
                    }
                    if (cbGodineAzuriraj.SelectedItem != null)
                    {
                        item.Godine = int.Parse(cbGodineAzuriraj.SelectedItem.ToString());
                        brojacPromjena++;
                    }
                    if (dtpDueDateAzuriraj.Value != item.DueDate)
                    {
                        item.DueDate = dtpDueDateAzuriraj.Value;
                        brojacPromjena++;
                    }
                    if (tbEmailAzuriraj.Text != item.Email)
                    {
                        item.Email = tbEmailAzuriraj.Text;
                        brojacPromjena++;
                    }
                    if(rbPrvaTrudnocaDaAzuriraj.Checked == true)
                    {
                        if (item.PrvaTrudnoca == false)
                        {
                            item.PrvaTrudnoca = true;
                            brojacPromjena++;
                        }
                    }
                    if(rbPrvaTrudnocaDaAzuriraj.Checked == false)
                    {
                        if (item.PrvaTrudnoca == true)
                        {
                            item.PrvaTrudnoca = false;
                            brojacPromjena++;
                        }
                    }
                }

                if (brojacPromjena == 0)
                    labelNemaPromjena.Visible = true;
                else
                {
                    context.SaveChanges();

                    int id = DohvatiIdKorisnika();
                    this.Hide();
                    frmTrudnocaAppMain frmTrudnocaApp = new frmTrudnocaAppMain(id);
                    frmTrudnocaApp.ShowDialog();
                }
            }
        }
    }
}
