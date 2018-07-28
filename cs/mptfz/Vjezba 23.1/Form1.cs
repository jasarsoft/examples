using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba_23._1
{
    public partial class fclsMain : Form
    {
        public fclsMain()
        {
            InitializeComponent();
            this.btnOK.Enabled = false;

            //podesavamo vrijednost Tag na false zbog testiranja
            //podataka da li su ispravno unijeti
            this.txtAdresa.Tag = false;
            this.txtGodiste.Tag = false;
            this.txtIme.Tag = false;

            //prijavljujemo dogadjaje
            this.txtIme.Validating += new CancelEventHandler(this.txtBoxPrazan_Validacija);
            this.txtAdresa.Validating += new CancelEventHandler(this.txtBoxPrazan_Validacija);
            this.txtGodiste.KeyPress += new KeyPressEventHandler(this.txtGodiste_KeyPress);
            this.txtGodiste.Validating += new CancelEventHandler(this.txtBoxPrazan_Validacija);

            this.txtIme.TextChanged += new EventHandler(this.txtBox_TextPromjenjen);
            this.txtAdresa.TextChanged += new EventHandler(this.txtBox_TextPromjenjen);
            this.txtGodiste.TextChanged += new EventHandler(this.txtBox_TextPromjenjen);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string izlaz;

            izlaz = "Ime i prezime: " + this.txtIme.Text + "\r\n";
            izlaz += "Adresa: " + this.txtAdresa.Text + "\r\n";
            izlaz += "Zanimanje: " + (string)(this.chkProgramer.Checked ? "Progamer" : "Not a progmaer") + "\r\n";
            izlaz += "Pol: " + (string)(this.rdoZensko.Checked ? "Zensko" : "Musko") + "\r\n";
            izlaz += "Godina: " + this.txtGodiste.Text;

            this.txtIzlaz.Text = izlaz;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string izlaz;

            izlaz = "Ime i prezime= Tvoje ime i prezime\r\n";
            izlaz += "Adresa = Tvoja adresa\r\n";
            izlaz += "Zanimanje = Cekirajte Programer ako ste progamer\r\n";
            izlaz += "Pol = Izaberite vas pol\r\n";
            izlaz += "Godina: Godina rodjenja";

            this.txtIzlaz.Text = izlaz;
        }

        private void txtBoxPrazan_Validacija(object sender, CancelEventArgs e)
        {
            //znamo da je posiljalac kontrola TextBox pa konvertujemo objekat sender u taj tip
            TextBox tb = (TextBox)sender;
            //ako tekst nije unijet setujemo poju pozadine u crveno
            //to radimo koristeci tag vrijednost kontrola pomocu koje provjeravamo validnost
            if(tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
                //u slucaju da hocemo da nastvimo sa daljnom obradom kao sto necemo
                //dodajli bismo sljedcu liniju e.Cancel = true;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            //na kraju zovemo rutinu ValidacijaZaSve koja setuje osbinu enabled za ok dugme;
            ValidacijaZaSve();
        }


        private void txtGodiste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; //ukljanja znak
        }

        private void txtBox_TextPromjenjen(object sender, EventArgs e)
        {
            //konvertujemo prametar sender u tip TextBox
            TextBox tb = (TextBox)sender;
            //provjeravamo ispravnost podataka i podesavamo boju pozadine
            if(tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }

            //podesavamo dugme OK
            ValidacijaZaSve();
        }

        private void ValidacijaZaSve()
        {
            //setovanje osobina Enabled dugmeta ok na true ako su svi tag vrijednsot true;
            this.btnOK.Enabled = ((bool)(this.txtAdresa.Tag) &&
                                  (bool)(this.txtGodiste.Tag) &&
                                  (bool)(this.txtIme.Tag));
        }
    }
}
