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
    public partial class frmTrudnocaAppMain : Form
    {
        private readonly int idKorisnika;
        public frmTrudnocaAppMain(int id)
        {
            InitializeComponent();
            idKorisnika = id;
        }

        private void frmTrudnocaAppMain_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            if(ProvjeriAdmina() == true)
            {
                btnAzuriraj.Visible = false;
                btnMojaBebaRound.Visible = false;
                btnUdarci.Visible = false;
                labelAzurirajPodatke.Visible = false;
                labelMojaBeba.Visible = false;
                labelUdarci.Visible = false;
                dgvRegistar.Visible = true;
                UcitajDGV();
            }
        }

        private void RefreshGUI()
        {
            dgvRegistar.Visible = false;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.Id == idKorisnika
                            select k.KorisnickoIme;

                foreach (var item in query)
                {
                    tbPrijavljeniKorisnik.Text = item;
                }
            }
        }
        private bool ProvjeriAdmina()
        {
            if (tbPrijavljeniKorisnik.Text == "admin")
                return true;
            return false;
        }

        private void UcitajDGV()
        {
            dgvRegistar.DataSource = NapuniDGV();
            dgvRegistar.Columns["Korisnici"].Visible = false;
            //dgvUdarci.Columns["IdKorisnika"].Visible = false;
        }

        private object NapuniDGV()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from r in context.Registar
                            select r;

                return query.ToList();
            }
        }

        private void btnMojaBebaRound_Click(object sender, EventArgs e)
        {
            this.Hide();
            int korisnikovId = idKorisnika;
            frmMojaBeba formMojaBeba = new frmMojaBeba(korisnikovId);
            formMojaBeba.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPocetna frmaPocetna = new frmPocetna();
            frmaPocetna.ShowDialog();
        }

        private void btnUdarci_Click(object sender, EventArgs e)
        {
            this.Hide();
            int korisnikovId = idKorisnika;
            frmUdarci formaUdarci = new frmUdarci(korisnikovId);
            formaUdarci.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            string korisnikovaBeba = tbPrijavljeniKorisnik.Text;
            frmAzurirajKorisnika formAzurirajKorisnika = new frmAzurirajKorisnika(korisnikovaBeba);
            formAzurirajKorisnika.ShowDialog();
        }
    }
}
