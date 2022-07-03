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
    public partial class frmMojaBeba : Form
    {
        public enum Spol
        {
            Neodređeno,
            Muško,
            Žensko
        }

        private int korisnikovId;

        public frmMojaBeba(int id)
        {
            InitializeComponent();
            korisnikovId = id;
        }

        private void frmMojaBeba_Load(object sender, EventArgs e)
        {
            PopuniComboBoxSpol();
            PopuniPodatkeBebe();
            PopuniDueDateiStarost();
            PopuniVelicinu();
        }

        private void PopuniComboBoxSpol()
        {
            cbSpol.DataSource = Enum.GetValues(typeof(Spol));
        }

        private void PopuniPodatkeBebe()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from b in context.Beba
                            where b.IdKorisnika == korisnikovId
                            select b;

                foreach (var item in query)
                {
                    if(item.Naziv != null)
                    {
                        tbImeBebe.Text = item.Naziv.ToString();
                        labelMojaBebaImeBebeDrugi.Text = tbImeBebe.Text;
                        labelMojaBebaImeBebeDrugi.Visible = true;
                    }
                    else
                    {
                        labelFaliMiIme.Visible = true;
                    }
                    
                    cbSpol.Text = item.Spol.ToString();
                }
            }
        }

        private void PopuniDueDateiStarost()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from k in context.Korisnici
                            where k.Id == korisnikovId
                            select k.DueDate;

                foreach (var item in query)
                {
                    string datumVrijeme = item.Date.ToString();
                    string samoDatum = datumVrijeme.Substring(0,10);

                    string mjesec = samoDatum.Split('/').ElementAt(0);
                    string dan = samoDatum.Split('/').ElementAt(1);
                    string godina = samoDatum.Split('/').ElementAt(2);

                    string trenutniDan = DateTime.Now.Day.ToString();
                    string trenutniMjesec = DateTime.Now.Month.ToString();
                    string trenutnaGodina = DateTime.Now.Year.ToString();

                    if (int.Parse(trenutnaGodina) == int.Parse(godina.Substring(0, 4)))
                    {
                        if(int.Parse(dan) > int.Parse(trenutniDan)) 
                        {
                            if (int.Parse(dan) - int.Parse(trenutniDan) > 15)
                                labelZaPopunjeno.Text = (int.Parse(mjesec) - int.Parse(trenutniMjesec) + 1).ToString();
                            else
                                labelZaPopunjeno.Text = (int.Parse(mjesec) - int.Parse(trenutniMjesec)).ToString();
                        }
                        else
                        {
                            if (int.Parse(trenutniDan) - int.Parse(dan) > 15)
                                labelZaPopunjeno.Text = (int.Parse(mjesec) - int.Parse(trenutniMjesec) - 1).ToString();
                            else
                                labelZaPopunjeno.Text = (int.Parse(mjesec) - int.Parse(trenutniMjesec)).ToString();
                        }
                    }
                    else
                    {
                        if (int.Parse(dan) > int.Parse(trenutniDan))
                        {
                            if (int.Parse(dan) - int.Parse(trenutniDan) > 15)
                                labelZaPopunjeno.Text = (13 - int.Parse(trenutniMjesec) + int.Parse(mjesec)).ToString();
                            else
                                labelZaPopunjeno.Text = (12 - int.Parse(trenutniMjesec) + int.Parse(mjesec)).ToString();
                        }
                        else
                        {
                            if (int.Parse(trenutniDan) - int.Parse(dan) > 15)
                                labelZaPopunjeno.Text = (13 - int.Parse(trenutniMjesec) + int.Parse(mjesec)).ToString();
                            else
                                labelZaPopunjeno.Text = (12 - int.Parse(trenutniMjesec) + int.Parse(mjesec)).ToString();
                        }
                    }

                    if (int.Parse(labelZaPopunjeno.Text) == 0)
                    {
                        labelStarostPopunjeno.Text = (9 - int.Parse(labelZaPopunjeno.Text)).ToString() + " mjeseci";
                        labelZaPopunjeno.Text += " mjeseci";
                        labelUskoroPorod.Visible = true;
                        labelUskoroDolazim.Visible = true;
                        labelMojaBebaStarostCetvrti.Text = labelStarostPopunjeno.Text;
                    }
                    else if (int.Parse(labelZaPopunjeno.Text) == 1) 
                    {
                        labelStarostPopunjeno.Text = (9 - int.Parse(labelZaPopunjeno.Text)).ToString() + " mjeseci";
                        labelZaPopunjeno.Text += " mjesec";
                        labelMojaBebaStarostCetvrti.Text = labelStarostPopunjeno.Text;
                    }
                    else if (int.Parse(labelZaPopunjeno.Text) >= 2 && int.Parse(labelZaPopunjeno.Text) <= 4)
                    {
                        labelStarostPopunjeno.Text = (9 - int.Parse(labelZaPopunjeno.Text)).ToString() + " mjeseci";
                        labelZaPopunjeno.Text += " mjeseca";
                        labelMojaBebaStarostCetvrti.Text = labelStarostPopunjeno.Text;
                    }
                    else
                    {
                        labelStarostPopunjeno.Text = (9 - int.Parse(labelZaPopunjeno.Text)).ToString() + " mjeseca";
                        labelZaPopunjeno.Text += " mjeseci";
                        labelMojaBebaStarostCetvrti.Text = labelStarostPopunjeno.Text;
                    }

                    switch (int.Parse(mjesec))
                    {
                        case 1:
                            labelDueDateRijecima.Text = dan + ". siječnja " + godina.Substring(0, 4) + ".";
                            break;
                        case 2:
                            labelDueDateRijecima.Text = dan + ". veljače " + godina.Substring(0, 4) + ".";
                            break;
                        case 3:
                            labelDueDateRijecima.Text = dan + ". ožujka " + godina.Substring(0, 4) + ".";
                            break;
                        case 4:
                            labelDueDateRijecima.Text = dan + ". travnja " + godina.Substring(0, 4) + ".";
                            break;
                        case 5:
                            labelDueDateRijecima.Text = dan + ". svibnja " + godina.Substring(0, 4) + ".";
                            break;
                        case 6:
                            labelDueDateRijecima.Text = dan + ". lipnja " + godina.Substring(0, 4) + ".";
                            break;
                        case 7:
                            labelDueDateRijecima.Text = dan + ". srpnja " + godina.Substring(0, 4) + ".";
                            break;
                        case 8:
                            labelDueDateRijecima.Text = dan + ". kolovoza " + godina.Substring(0, 4) + ".";
                            break;
                        case 9:
                            labelDueDateRijecima.Text = dan + ". rujna " + godina.Substring(0, 4) + ".";
                            break;
                        case 10:
                            labelDueDateRijecima.Text = dan + ". listopada " + godina.Substring(0, 4) + ".";
                            break;
                        case 11:
                            labelDueDateRijecima.Text = dan + ". studenog " + godina.Substring(0, 4) + ".";
                            break;
                        case 12:
                            labelDueDateRijecima.Text = dan + ". prosinca " + godina.Substring(0, 4) + ".";
                            break;
                    }
                }
            }
        }

        private void PopuniVelicinu()
        {
            int starost = int.Parse(labelStarostPopunjeno.Text.Substring(0, 1));

            using (var context = new TrudnocaAppEntities())
            {
                var query = from v in context.Velicina
                            where v.PocetniMjesec <= starost && v.ZavrsniMjesec >= starost
                            select v;

                foreach (var item in query)
                {
                    labelMojaBebaTekstSesti.Text = item.Naziv.ToString();
                }
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            int id = korisnikovId;
            this.Hide();
            frmTrudnocaAppMain frmTrudnocaApp = new frmTrudnocaAppMain(id);
            frmTrudnocaApp.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            RefreshGUI();

            AzurirajPromjene();
            PopuniPodatkeBebe();
        }

        private void RefreshGUI()
        {
            labelNemaPromjena.Visible = false;
        }

        private void AzurirajPromjene()
        {
            int brojacPromjena = 0;

            using (var context = new TrudnocaAppEntities())
            {
                var query = from b in context.Beba
                            where b.IdKorisnika == korisnikovId
                            select b;

                foreach (Beba item in query)
                {
                    if (tbImeBebe.Text != item.Naziv && tbImeBebe.Text != string.Empty)
                    {
                        item.Naziv = tbImeBebe.Text;
                        brojacPromjena++;
                        labelFaliMiIme.Visible = false;
                    }
                    if (cbSpol.SelectedItem.ToString() != item.Spol)
                    {
                        item.Spol = cbSpol.SelectedItem.ToString();
                        brojacPromjena++;
                        if(cbSpol.SelectedItem.ToString() == "Muško")
                        {
                            labelMojaBebaTekstPrvi.BackColor = Color.LightBlue;
                            labelMojaBebaTekstTreci.BackColor = Color.LightBlue;
                            labelMojaBebaTekstPeti.BackColor = Color.LightBlue;
                        }
                        else if (cbSpol.SelectedItem.ToString() == "Žensko")
                        {
                            labelMojaBebaTekstPrvi.BackColor = Color.LightPink;
                            labelMojaBebaTekstTreci.BackColor = Color.LightPink;
                            labelMojaBebaTekstPeti.BackColor = Color.LightPink;
                        }
                        else
                        {
                            labelMojaBebaTekstPrvi.BackColor = Color.White;
                            labelMojaBebaTekstTreci.BackColor = Color.White;
                            labelMojaBebaTekstPeti.BackColor = Color.White;
                        }
                    }
                }

                if (brojacPromjena == 0)
                    labelNemaPromjena.Visible = true;
                else
                    context.SaveChanges();
            }
        }
    }
}
