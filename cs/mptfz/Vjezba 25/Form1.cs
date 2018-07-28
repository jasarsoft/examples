using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba_25
{
    public partial class fclsMain : Form
    {
        public fclsMain()
        {
            InitializeComponent();

            this.chkListaIzbora.Items.Add("deset");
        }

        private void btnPrebaci_Click(object sender, EventArgs e)
        {
            //provjeravamo postoji li neki potvrdjnie element u kontroli CheckedListBox
            if(this.chkListaIzbora.CheckedItems.Count > 0)
            {
                //ispraznimo kontrolu ListBox u koju stavljamo izabrane elemente
                this.lstSelektovani.Items.Clear();

                //prodjimo u petlji kroz kolekciju CheckedItems kontrole CheckedListBox
                //i dodajmo elemente u okvir Selected
                foreach(string item in this.chkListaIzbora.CheckedItems)
                {
                    this.lstSelektovani.Items.Add(item.ToString());
                }

                //ponistimo sve sto je potvrdjeno u kontroli CheckedListBox
                for(int i = 0; i < this.chkListaIzbora.Items.Count; i++)
                {
                    this.chkListaIzbora.SetItemChecked(i, false);
                }
            }
        }
    }
}
