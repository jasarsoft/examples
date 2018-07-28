using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Vjezba_27
{
    public partial class fclsMain : Form
    {
        //polje koje ce sadrzavati predhodne foldere
        private System.Collections.Specialized.StringCollection folderCol;

        public fclsMain()
        {
            InitializeComponent();

            //inicijalizujemo ListView i kolekciju foldera
            folderCol = new System.Collections.Specialized.StringCollection();
            KreirajHeaderlistView();
            FilujListView(@"C:\");
            folderCol.Add(@"C:\");
        }

        private void KreirajHeaderlistView()
        {
            ColumnHeader colHeader;

            //prvo zaglavlje
            colHeader = new ColumnHeader();
            colHeader.Text = "Naziv fajla";
            this.lwFajloviFolder.Columns.Add(colHeader); //ubacijemo zaglavlje

            colHeader = new ColumnHeader();
            colHeader.Text = "Velicina fajla";
            this.lwFajloviFolder.Columns.Add(colHeader);

            colHeader = new ColumnHeader();
            colHeader.Text = "Posljenji prstup";
            this.lwFajloviFolder.Columns.Add(colHeader);
        }

        private void FilujListView(string root)
        {
            try
            {
                //dve lokalne promjenljive za kreiranje elemenata za ubacivanje
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                //ako nema korenog folder nista ne moze ubaciti
                if (root.CompareTo("") == 0)
                    return;

                //uzimamo informacije o koren folderu
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);
                //citamo fajlove i folder iz korenskog folder
                DirectoryInfo[] dirs = dir.GetDirectories(); //folderi
                FileInfo[] files = dir.GetFiles(); //fajlovi

                //brisemo ListView. Zovemo metodu Clear kolecije Items, a ne samoe kontrole ListView.
                //Metoda Clear kontrole ListView brise sve ukljucujuci i zaglavlja kolona, a mi hocmeo
                //da izbrisemo samo elemente iz prikaza
                this.lwFajloviFolder.Items.Clear();

                //podesimo oznaku na trenutnu putanju
                this.lblTrenutnaPutanja.Text = root;

                //stopiramo oznaku na trenutnu putanju
                this.lwFajloviFolder.BeginUpdate();


                //prodjimo kroz folder korenskog foldera i ubacimo ih
                foreach(DirectoryInfo di in dirs)
                {
                    //kreiramo glavni ListViewItem
                    lvi = new ListViewItem();
                    lvi.Text = di.Name; //ime foldera
                    lvi.ImageIndex = 0; //index ikone foldera je 0
                    lvi.Tag = di.FullName; //podesimo tag na putanju foldera

                    //kreiramo dva podelementa
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = ""; //folder nema velicinu i zato je ova kolona prazna
                    lvi.SubItems.Add(lvsi); //dodajemo podelemente u ListViewItem

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString(); //posljenja kolona koji je pristup
                    lvi.SubItems.Add(lvsi); //dodajemo podelemente u ListViewItem

                    this.lwFajloviFolder.Items.Add(lvi);
                }

                //prolazimo kroz sve fajlove korenskog foldera
                foreach(FileInfo fi in files)
                {
                    //kreiramo glavni ListViewItem
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name; //ime fajla
                    lvi.ImageIndex = 1; //ikona kojom prikazujemo folder ima index 1
                    lvi.Tag = fi.FullName; //podesimo tag na putanju foldera

                    //kreiramo dva podelementa
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString(); //velicina fajla
                    lvi.SubItems.Add(lvsi); //dodajemo podelemente kolkciji SubItems

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString(); //posljenja kolona koji je pristup
                    lvi.SubItems.Add(lvsi); //dodajemo podelemente u ListViewItem

                    this.lwFajloviFolder.Items.Add(lvi);
                }

                //omogucimo prikaz novi elemenata;
                //sada se prikazuju novi elementi
                this.lwFajloviFolder.EndUpdate();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void lwFajloviFolder_ItemActivate(object sender, EventArgs e)
        {
            ///konvertujemo parametar sender u tip ListView i citamo svojstvo tag za priv izabrani elemente
            ListView lw = (ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();

            if(lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    //pkusamo da pokreno fajl
                    System.Diagnostics.Process.Start(filename);
                }
                catch (Exception)
                {
                    //ako poksaj nije uspjeo napustamo metodu
                    return;
                }
            }
            else
            {
                //ubacijuemo elemnte
                FilujListView(filename);
                folderCol.Add(filename);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            if(folderCol.Count > 1)
            {
                FilujListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
            {
                FilujListView(folderCol[0].ToString());
            }
        }

        private void rdoLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lwFajloviFolder.View = View.LargeIcon;
        }

        private void rdoSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lwFajloviFolder.View = View.SmallIcon;
        }

        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lwFajloviFolder.View = View.List;
        }

        private void rdoDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lwFajloviFolder.View = View.Details;
        }
    }
}
