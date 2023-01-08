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
    public partial class frmMedicina : Form
    {
        private int korisnikovId;
        public frmMedicina(int id)
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

        private void frmMedicina_Load(object sender, EventArgs e)
        {
            UcitajDGVMedicinaTemporal();
            UcitajDGVMedicinaPovijest();
        }

        private void UcitajDGVMedicinaTemporal()
        {
            dgvMedicina.DataSource = NapuniDGVMedicinaTemporal();
            dgvMedicina.Columns["Korisnici"].Visible = false;
            dgvMedicina.Columns["IdKorisnika"].Visible = false;
            textBoxNazivLijeka.Text = string.Empty;
            textBoxOpisLijeka.Text = string.Empty;
            textBoxCijena.Text = string.Empty;
            textBoxNovaCijena.Text = string.Empty;
        }

        private object NapuniDGVMedicinaTemporal()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from m in context.Medicina
                            where m.IdKorisnika == korisnikovId
                            select m;

                return query.ToList();
            }
        }

        private void UcitajDGVMedicinaPovijest()
        {
            dgvMedicinaPovijest.DataSource = NapuniDGVMedicinaPovijest();
            dgvMedicinaPovijest.Columns["IdKorisnika"].Visible = false;
        }

        private object NapuniDGVMedicinaPovijest()
        {
            using (var context = new TrudnocaAppEntities())
            {
                var query = from r in context.MedicinaPovijest
                            where r.IdKorisnika == korisnikovId
                            select r;

                return query.ToList();
            }
        }

        private void dgvMedicina_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicina.Rows[e.RowIndex];
                textBoxTrenutniNaziv.Text = row.Cells[2].Value.ToString();
                textBoxTrenutnaCijena.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonDodajLijek_Click(object sender, EventArgs e)
        {
            if (textBoxNazivLijeka.Text != string.Empty && textBoxOpisLijeka.Text != string.Empty && textBoxCijena.Text != string.Empty)
            {
                using (var context = new TrudnocaAppEntities())
                {
                    string naziv = textBoxNazivLijeka.Text;
                    string opis = textBoxOpisLijeka.Text;
                    decimal cijena = decimal.Parse(textBoxCijena.Text);

                    context.Database.ExecuteSqlCommand(String.Format("INSERT INTO Medicina (IdKorisnika, Naziv, Opis, Cijena) VALUES ({0}, '{1}', '{2}', {3})", korisnikovId, naziv, opis, cijena));
                }

                UcitajDGVMedicinaTemporal();
                UcitajDGVMedicinaPovijest();
            }
            else
            {
                MessageBox.Show("Popunite naziv, opis i cijenu kako bi mogli dodati novi lijek!");
            }
        }

        private void buttonNovaCijena_Click(object sender, EventArgs e)
        {
            if (textBoxTrenutniNaziv.Text != string.Empty)
            {
                using (var context = new TrudnocaAppEntities())
                {

                    var query = (from m in context.Medicina
                                 where m.Naziv == textBoxTrenutniNaziv.Text
                                 select m).SingleOrDefault();

                    if (textBoxNovaCijena.Text != string.Empty)
                        query.Cijena = decimal.Parse(textBoxNovaCijena.Text);
                    else
                        MessageBox.Show("Upišite novu cijenu kako bi se promjene mogle izvršiti!");

                    context.SaveChanges();
                }

                UcitajDGVMedicinaTemporal();
                UcitajDGVMedicinaPovijest();
            }
            else
            {
                MessageBox.Show("Odaberite red u tablici trenutnih lijekova kako bi mogli ažurirati novu cijenu!");
            }
        }

        private Medicina GetChosenMedicina()
        {
            return dgvMedicina.CurrentRow.DataBoundItem as Medicina;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            Medicina chosenMedicina = GetChosenMedicina();

            if(chosenMedicina != null)
            {
                using (var context = new TrudnocaAppEntities())
                {
                    context.Medicina.Attach(chosenMedicina);
                    context.Medicina.Remove(chosenMedicina);
                    context.SaveChanges();
                }
            }

            UcitajDGVMedicinaTemporal();
            UcitajDGVMedicinaPovijest();
        }
    }
}
