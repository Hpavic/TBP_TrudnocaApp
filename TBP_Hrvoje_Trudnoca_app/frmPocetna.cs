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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefreshGUI();
            frmRegistracija formRegistracija = new frmRegistracija();
            formRegistracija.ShowDialog();
        }

        private void RefreshGUI()
        {
            labelLozinkaNijeIspravna.Visible = false;
            labelKorisnickoImeNePostoji.Visible = false;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            RefreshGUI();

            if (ProvjeriPrijavu() == true)
            {
                int id = DohvatiIdKorisnika();
                this.Hide();
                frmTrudnocaAppMain formTrudnocaAppMain = new frmTrudnocaAppMain(id);
                formTrudnocaAppMain.ShowDialog();
            }
            else
            {
                PostaviLabele();
            }
        }

        private int DohvatiIdKorisnika()
        {
            int idKorisnika = 0;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.KorisnickoIme == tbKorisnickoIme.Text
                            select k.Id;

                foreach (var item in query)
                {
                    idKorisnika = int.Parse(item.ToString());
                }
            }

            if(idKorisnika > 0)
                return idKorisnika;
            return 0;
        }

        private bool ProvjeriPrijavu()
        {
            if (ProvjeriKorisnickoIme() == true && ProvjeriLozinku() == true)
                return true;
            else
                return false;
        }

        private bool ProvjeriKorisnickoIme()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            select k.KorisnickoIme;

                foreach (var item in query)
                {
                    if (item == tbKorisnickoIme.Text)
                        return true;
                }

                return false;
            }
        }

        private bool ProvjeriLozinku()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.KorisnickoIme == tbKorisnickoIme.Text
                            select k.Lozinka;

                foreach (var item in query)
                {
                    if (item == tbLozinka.Text.ToString())
                        return true;
                }

                return false;
            }
        }

        private void PostaviLabele()
        {
            if (ProvjeriKorisnickoIme() == true && ProvjeriLozinku() == false)
                labelLozinkaNijeIspravna.Visible = true;
            else if (ProvjeriKorisnickoIme() == false) 
            {
                labelKorisnickoImeNePostoji.Visible = true;
            }
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }
    }
}
