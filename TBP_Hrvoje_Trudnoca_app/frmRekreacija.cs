using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Hrvoje_Trudnoca_app
{
    public partial class frmRekreacija : Form
    {
        private int korisnikovId;
        public frmRekreacija(int id)
        {
            InitializeComponent();
            korisnikovId = id;
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            int id = korisnikovId;
            this.Hide();
            frmTrudnocaAppMain frmTrudnocaApp = new frmTrudnocaAppMain(id);
            frmTrudnocaApp.ShowDialog();
        }

        private void frmRekreacija_Load(object sender, EventArgs e)
        {
            UcitajDGVRekreacijaTemporal();
            UcitajDGVRekreacijaPovijest();
        }

        private void UcitajDGVRekreacijaTemporal()
        {
            dgvTemporalRekreacija.DataSource = NapuniDGVRekreacijaTemporal();
            dgvTemporalRekreacija.Columns["Korisnici"].Visible = false;
            dgvTemporalRekreacija.Columns["IdKorisnika"].Visible = false;
            textBoxNovaRekreacija.Text = string.Empty;
        }

        private object NapuniDGVRekreacijaTemporal()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from r in context.Rekreacija
                            where r.IdKorisnika == korisnikovId
                            select r;

                return query.ToList();
            }
        }

        private void UcitajDGVRekreacijaPovijest()
        {
            dgvPovijestRekreacija.DataSource = NapuniDGVRekreacijaPovijest();
            dgvPovijestRekreacija.Columns["IdKorisnika"].Visible = false;
        }

        private object NapuniDGVRekreacijaPovijest()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from r in context.RekreacijaPovijest
                            where r.IdKorisnika == korisnikovId
                            select r;

                return query.ToList();
            }
        }

        private void dgvTemporalRekreacija_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTemporalRekreacija.Rows[e.RowIndex];
                textBoxTrenutniNazivRekreacije.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonDodajNovuRekreaciju_Click(object sender, EventArgs e)
        {
            if (textBoxNovaRekreacija.Text != string.Empty)
            {
                using (var context = new TrudnocaAppEntities())
                {
                    string opis = textBoxNovaRekreacija.Text;
                    int setnja = 0;

                    context.Database.ExecuteSqlCommand(String.Format("INSERT INTO Rekreacija (IdKorisnika, Opis, Setnja) VALUES ({0}, '{1}', {2})", korisnikovId, opis, setnja));
                }

                UcitajDGVRekreacijaTemporal();
                UcitajDGVRekreacijaPovijest();
            }
            else
            {
                MessageBox.Show("Niste unijeli naziv nove rekreacije!");
            }
        }

        private void btnKreniUSetnju_Click(object sender, EventArgs e)
        {
            if (textBoxTrenutniNazivRekreacije.Text != string.Empty)
            {
                using (var context = new TrudnocaAppEntities())
                {

                    var query = (from r in context.Rekreacija
                                 where r.Opis == textBoxTrenutniNazivRekreacije.Text
                                 select r).SingleOrDefault();

                    query.KodKuce = false;

                    context.SaveChanges();
                }

                UcitajDGVRekreacijaTemporal();
                UcitajDGVRekreacijaPovijest();

                MessageBox.Show("Rekreacija je u tijeku!");
            }
            else
            {
                MessageBox.Show("Odaberite red u tablici aktivnih rekreacija ovisno na koji način će te se rekreirati!");
            }
        }

        private void btnZavrsiSetnju_Click(object sender, EventArgs e)
        {
            if (tbTrajanjeSetnje.Text != string.Empty)
            {
                using (var context = new TrudnocaAppEntities())
                {
                    var query = (from r in context.Rekreacija
                                 where r.Opis == textBoxTrenutniNazivRekreacije.Text
                                 select r).SingleOrDefault();

                    query.KodKuce = true;
                    query.Setnja = int.Parse(tbTrajanjeSetnje.Text.ToString());

                    context.SaveChanges();
                }

                UcitajDGVRekreacijaTemporal();
                UcitajDGVRekreacijaPovijest();
            }
            else
            {
                MessageBox.Show("Potrebno je unijeti koliko je šetnja trajala!");
            }
        }
    }
}
