using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Hrvoje_Trudnoca_app
{
    public partial class frmUdarci : Form
    {
        private int korisnikovId;

        int idIntervala;
        DateTime datum;
        TimeSpan? pocetakIntervala;
        int? redniBrojUdarca = 1;
        TimeSpan? vrijemeUdarca;
        TimeSpan? krajIntervala;
        

        public frmUdarci(int id)
        {
            InitializeComponent();
            korisnikovId = id;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            int id = korisnikovId;
            this.Hide();
            frmTrudnocaAppMain frmTrudnocaApp = new frmTrudnocaAppMain(id);
            frmTrudnocaApp.ShowDialog();
        }

        private void frmUdarci_Load(object sender, EventArgs e)
        {
            UcitajDGV();
            btnStop.Enabled = false;
            roundButtonUdarac.Enabled = false;
            labelBrojUdaraca.Text = "0";
            labelRazlikaVremena.Visible = false;
            labelTrajanjeSesije.Visible = false;
        }

        private void UcitajDGV()
        {
            dgvUdarci.DataSource = NapuniDGV();
            dgvUdarci.Columns["Korisnici"].Visible = false;
            dgvUdarci.Columns["IdKorisnika"].Visible = false;
            dgvUdarci.Columns["Id"].Visible = false;
        }

        private object NapuniDGV()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from u in context.NajdraziUdarci
                            where u.IdKorisnika == korisnikovId
                            select u;

                return query.ToList();
            }
        }

        public void btnUdarci_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            roundButtonUdarac.Enabled = true;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from u in context.NajdraziUdarci
                            where u.IdKorisnika == korisnikovId
                            select u;

                if(query.Count() > 0)
                {
                    idIntervala = query.ToList()[query.Count()-1].IdIntervala + 1;
                }
                else
                {
                    idIntervala = 1;
                }
            }
            
            datum = DateTime.Now.Date;
            pocetakIntervala = DateTime.Now.TimeOfDay;
            vrijemeUdarca = DateTime.Now.TimeOfDay;
            krajIntervala = null;

            labelPocVrijZadInt.Visible = true;
            labelPocVrijZadInt.Text = pocetakIntervala.ToString();
            labelZavVrijZadInt.Visible = false;

            NajdraziUdarci udarci = new NajdraziUdarci()
            {
                IdIntervala = idIntervala,
                Datum = datum,
                PocetakIntervala = pocetakIntervala,
                RedniBrojUdarca = 1,
                VrijemeUdarca = vrijemeUdarca,
                KrajIntervala = krajIntervala,
                IdKorisnika = korisnikovId
            };

            using (var context = new TrudnocaAppEntities())
            {
                context.NajdraziUdarci.Add(udarci);
                context.SaveChanges();
            }

            UcitajDGV();

            btnUdarci.Enabled = false;
            labelBrojUdaraca.Text = redniBrojUdarca.ToString();
            labelRazlikaVremena.Visible = false;
            labelTrajanjeSesije.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from u in context.NajdraziUdarci
                            where u.IdKorisnika == korisnikovId
                            select u;

                idIntervala = query.ToList()[query.Count() - 1].IdIntervala;
                vrijemeUdarca = query.ToList()[query.Count() - 1].VrijemeUdarca;
            }

            datum = DateTime.Now.Date;
            krajIntervala = DateTime.Now.TimeOfDay;

            NajdraziUdarci udarci = new NajdraziUdarci()
            {
                IdIntervala = idIntervala,
                Datum = datum,
                PocetakIntervala = null,
                RedniBrojUdarca = null,
                VrijemeUdarca = vrijemeUdarca,
                KrajIntervala = krajIntervala,
                IdKorisnika = korisnikovId
            };

            using (var context = new TrudnocaAppEntities())
            {
                context.NajdraziUdarci.Add(udarci);
                context.SaveChanges();
            }

            UcitajDGV();

            using (var context = new TrudnocaAppEntities())
            {
                var query2 = from u in context.NajdraziUdarci
                             where u.IdKorisnika == korisnikovId
                             select u;

                TimeSpan zadnjeVrijeme = (TimeSpan)query2.ToList()[query2.Count() - 1].KrajIntervala;
                labelZavVrijZadInt.Text = zadnjeVrijeme.ToString();
            }

            var razlikaVremena = DateTime.Parse(labelZavVrijZadInt.Text.ToString()).Subtract(DateTime.Parse(labelPocVrijZadInt.Text.ToString()));
            labelRazlikaVremena.Text = razlikaVremena.ToString();
            labelRazlikaVremena.Visible = true;
            labelTrajanjeSesije.Visible = true;

            labelPocVrijZadInt.Visible = true;
            labelZavVrijZadInt.Visible = true;
            labelRazlikaVremena.Visible = true;
            labelTrajanjeSesije.Visible = true;

            redniBrojUdarca = 1;
            btnUdarci.Enabled = true;
            roundButtonUdarac.Enabled = false;
            btnStop.Enabled = false;
            labelBrojUdaraca.Text = "0";
        }

        private void roundButtonUdarac_Click(object sender, EventArgs e)
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from u in context.NajdraziUdarci
                            where u.IdKorisnika == korisnikovId
                            select u;
                
                idIntervala = query.ToList()[query.Count() - 1].IdIntervala;
            }

            datum = DateTime.Now.Date;
            pocetakIntervala = null;
            redniBrojUdarca++;
            vrijemeUdarca = DateTime.Now.TimeOfDay;
            krajIntervala = null;

            labelBrojUdaraca.Text = redniBrojUdarca.ToString();

            try
            {
                NajdraziUdarci udarci = new NajdraziUdarci()
                {
                    IdIntervala = idIntervala,
                    Datum = datum,
                    PocetakIntervala = pocetakIntervala,
                    RedniBrojUdarca = redniBrojUdarca,
                    VrijemeUdarca = vrijemeUdarca,
                    KrajIntervala = krajIntervala,
                    IdKorisnika = korisnikovId
                };

                using (var context = new TrudnocaAppEntities())
                {
                    context.NajdraziUdarci.Add(udarci);
                    context.SaveChanges();
                }
                
                UcitajDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.GetBaseException().ToString());
            }
        }
    }
}
