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

        }

        private object NapuniDGVRekreacijaTemporal()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from r in context.Rekreacija
                            //where r.IdKorisnika == korisnikovId
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
                            //where r.IdKorisnika == korisnikovId
                            select r;

                return query.ToList();
            }
        }

        private void btnKreniUSetnju_Click(object sender, EventArgs e)
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = (from r in context.Rekreacija
                            where r.Opis == cbTipSetnje.SelectedItem.ToString()
                            select r).SingleOrDefault();

                query.KodKuce = false;

                context.SaveChanges();
            }

            UcitajDGVRekreacijaTemporal();
            UcitajDGVRekreacijaPovijest();
        }

        private void btnZavrsiSetnju_Click(object sender, EventArgs e)
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = (from r in context.Rekreacija
                             where r.Opis == cbTipSetnje.SelectedItem.ToString()
                             select r).SingleOrDefault();

                query.KodKuce = true;
                query.Setnja = int.Parse(tbTrajanjeSetnje.Text.ToString());

                context.SaveChanges();
            }

            UcitajDGVRekreacijaTemporal();
            UcitajDGVRekreacijaPovijest();
        }
    }
}
