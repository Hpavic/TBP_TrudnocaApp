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
    public partial class frmUdarci : Form
    {
        private int korisnikovId;
        DateTime vrijemePocetak;
        DateTime vrijemeKraj;
        int brojUdaraca = 0;

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
            labelBrojUdaraca.Text = "0";
            labelRazlikaVremena.Visible = false;
            labelTrajanjeSesije.Visible = false;
        }

        private void UcitajDGV()
        {
            dgvUdarci.DataSource = NapuniDGV();
            dgvUdarci.Columns["Korisnici"].Visible = false;
            dgvUdarci.Columns["IdKorisnika"].Visible = false;
        }

        private object NapuniDGV()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from u in context.Udarci
                            where u.IdKorisnika == korisnikovId
                            select u;

                return query.ToList();
            }
        }

        public void btnUdarci_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            if(brojUdaraca == 0)
                vrijemePocetak = DateTime.Now;
            brojUdaraca++;
            labelBrojUdaraca.Text = brojUdaraca.ToString();
            labelRazlikaVremena.Visible = false;
            labelTrajanjeSesije.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vrijemeKraj = DateTime.Now;

            var razlikaVremena = vrijemeKraj.Subtract(vrijemePocetak);
            labelRazlikaVremena.Text = razlikaVremena.Seconds.ToString();
            labelRazlikaVremena.Visible = true;
            labelTrajanjeSesije.Visible = true;
            
            Udarci udarci = new Udarci()
            {
                DatumPocetak = vrijemePocetak,
                DatumKraj = vrijemeKraj,
                Udarci1 = brojUdaraca,
                IdKorisnika = korisnikovId
            };
            using(var context = new TrudnocaAppEntities())
            {
                context.Udarci.Add(udarci);
                context.SaveChanges();
            }

            UcitajDGV();
            btnStop.Enabled = false;
            labelBrojUdaraca.Text = "0";
            brojUdaraca = 0;
        }
    }
}
