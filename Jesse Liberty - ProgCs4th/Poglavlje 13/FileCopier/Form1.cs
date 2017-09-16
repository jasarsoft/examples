using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// File Copier - Windows Forms demostracijski program
/// (c) Copyright 2005 Liberty Association, Inc.
/// </summary>
namespace FileCopier
{
    /// <summary>
    /// Obrazac za demonstraciju Windows Forms implementacije
    /// </summary>
    public partial class frmFileCopier : Form
    {
        private const int MaxLevel = 2;

        public frmFileCopier()
        {
            InitializeComponent();

            FillDirectoryTree(tvwSource, true);
            FillDirectoryTree(tvwTargetDir, false);
        }

        /// <summary>
        /// Ugnjezdena klasa koja zna kako uspordjivati dvije datoteke
        /// koje zelimo sortirati od vece prema manjoj
        /// </summary>
        public class FileComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo file1, FileInfo file2)
            {
                if (file1.Length > file2.Length)
                    return -1;
                else if (file1.Length < file2.Length)
                    return 1;
                else
                    return 0;
            }

            public bool Equals(FileInfo x, FileInfo y)
            {
                throw new NotImplementedException();
            }

            public int GetHashCode(FileInfo x)
            {
                throw new NotImplementedException();
            }
        }

        private void FillDirectoryTree(TreeView tvw, bool isSource)
        {
            //popunjava tvwSource, the Source TreeView sa sadrzajem
            //lokalnog tvrdog diska; najprije brise sve cvorove;
            tvw.Nodes.Clear();

            //uzima logicke diskove i stavlja ih u korijenske covorove
            //popunjava polje s logicnkim diskovima na stroju
            string[] strDrives = Environment.GetLogicalDrives();

            //prolazi kroz diskove i dodaje ih stablu
            //koristi blok try/catch pa ako disk nije spreman npr prazna disketa ili CD
            //nece biti dodan na popis
            foreach (string rootDirectoryName in strDrives)
            {
                try
                {
                    //popunjava polje sa mapama prve razine
                    //ako disk nije spreman bit ce izbacena iznimka
                    DirectoryInfo dir = new DirectoryInfo(rootDirectoryName);
                    dir.GetDirectories(); //forsira iznimku ako disk nije spreman
                    TreeNode ndRoot = new TreeNode(rootDirectoryName);
                    //dodaje cvor za svaku korijensku mapu
                    tvw.Nodes.Add(ndRoot);
                    //dodaje cvorove pod mapa
                    //ako je TreeView izvor onda uzima i imena datoteka
                    if(isSource)
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, true, 1);
                    }
                    else
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, false, 1);
                    }
                }
                //hvata pogreske poput diska koji nije spreman
                catch {}

                Application.DoEvents();   
            }
        }

        /// <summary>
        /// uzima sve pod mape ispod prosliedjenog cvora mape
        /// dodaje ih u stablo mapa;
        /// proslijedjeni parametri su roditeljski cvor za tu podmapu, i Boolen zastavica koja govori
        /// da li treba uzeti datoteke iz podmape.
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="fullName"></param>
        /// <param name="getFileNames"></param>
        /// <param name="level"></param>
        private void GetSubDirectoryNodes(TreeNode parentNode, string fullName, bool getFileNames, int level)
        {
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();

            //dodaje cvor-potomak za svaku mapu
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                //ne prikazuje skrivene mape
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0) continue;

                ///<summary>
                /// Svaka mapa ima punu putanju.
                /// Trebamo ju podjelite na kosim crtama, i upotrijebit samo zadnji cvor u stablu.
                /// Potrebno je dvaput napisati kosu crtu jer je ona inace znak za prekid
                ///</summary>
                TreeNode subNode = new TreeNode(dirSub.Name);
                parentNode.Nodes.Add(subNode);

                //rekurzivno poziva GetSubDirectoryNodes
                if (level < MaxLevel)
                    GetSubDirectoryNodes(subNode, dirSub.FullName, getFileNames, level + 1);
            }
            if(getFileNames)
            {
                //uzima datoteke za svoj cvor
                FileInfo[] files = dir.GetFiles();
                //nakon spremanja cvorova, sada sprema datoteke iz mape
                foreach(FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    parentNode.Nodes.Add(fileNode);
                }
            }
        }

        /// <summary>
        /// Uzima cvor i vraca punu putanju
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetParentString(TreeNode node)
        {
            //ako je ovo korijenski cvor (c:\) vraca tekst
            if (node.Parent == null)
                return node.Text;
            else
            {
                //vraca se gore i uzima putanju zatim dodaje ovaj cvor i kosu crtu
                //ako je ovaj cvor list, ne dodaje kosu crtu
                return GetParentString(node.Parent) + node.Text + (node.Nodes.Count == 0 ? "" : "\\");
            }
        }

        /// <summary>
        /// S popisom i polje na raspolaganju popunjava popis imena svih odabranih datoteka
        /// </summary>
        /// <param name="node"></param>
        /// <param name="fileNames"></param>
        /// Popunjava ArrayList sa punim putanjama odabranih datoteka
        private void GetCheckedFiles(TreeNode node, List<string> fileNames)
        {
            //ako je list...
            if(node.Nodes.Count == 0)
            {
                //ako je cvor odabran
                if(node.Checked)
                {
                    //uzima punu putanju i dodaje je na arrayList
                    string fullPath = GetParentString(node);
                    fileNames.Add(fullPath);
                }
            }
            else //ako ovaj cvor nije list
            {
                //ako ovaj cvor nije list
                foreach(TreeNode n in node.Nodes)
                {
                    GetCheckedFiles(n, fileNames);
                }
            }
        }

        private List<FileInfo> GetFileList()
        {
            //stvara nesortirano polje punih putanja datoteka
            List<string> fileNames = new List<string>();

            //ArrayList fileNames = new ArrayList();

            //popunjava fileNames ArrayList s punom putanjom svake datoteke za kopiranje
            foreach(TreeNode theNode in tvwSource.Nodes)
            {
                GetCheckedFiles(theNode, fileNames);
            }

            //pravi popis za cuvanje FileInfo objekata
            List<FileInfo> fileList = new List<FileInfo>();
            //ArrayList fileList = new ArrayList();

            //za svako ime datoteke iz nesortiranog polja ako ime odgovara datoteci (a ne mapi) dodaje ga na popis datoteka
            foreach(string fileName in fileNames)
            {
                //stvara datoteku s imenom
                FileInfo file = new FileInfo(fileName);
                //provjerava postoji li na disku i ne uspjeva ako je mapa
                if(file.Exists)
                {
                    //i kljuc i vrijednost je datoteka
                    //da li bi bilo lakse kad bi imali praznu vrijednost
                    fileList.Add(file);
                }
            }

            //stvara instancu sucelja IComparer
            IComparer<FileInfo> comparer = (IComparer<FileInfo>)new FileComparer();

            //prosljedjuje komparator metodi za sortiranje tako da je popis
            //sortiran s metodom za sortiranje
            fileList.Sort(comparer);
            return fileList;
        }

        /// <summary>
        /// Rekurzija postavlja ili brise oznake za potvrdu
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        private void SetCheck(TreeNode node, bool check)
        {
            //trazi sve cvorove potomke ovog cvora
            foreach(TreeNode n in node.Nodes)
            {
                n.Checked = check; //potvrdjuje cvor
                //ako je to cvor u stablu, rekurzivno prolazi
                if(n.Nodes.Count != 0)
                {
                    SetCheck(n, check);
                }
            }
        }

        /// <summary>
        /// Ako korisnik pritisne Cancel zatvara se
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Pravi sortirani popis svih datoteka odabranih za kopiranje u odredisnu mapu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //uzima popis
            List<FileInfo> fileList = GetFileList();

            //kopira datoteke
            foreach(FileInfo file in fileList)
            {
                try
                {
                    //osvjezava natpis da prikazuje napredak
                    lblStatus.Text = "Copying " + txtTargetDir.Text + "\\" + file.Name + "...";
                    Application.DoEvents();

                    //kopira datoteku u odredisnu mapu
                    file.CopyTo(txtTargetDir.Text + "\\" + file.Name, chkOverwrite.Checked);
                }
                catch (Exception ex)
                {
                    //mozda zelite nesto vise od prikazivanja poruke
                    MessageBox.Show(ex.Message);
                }
            }

            lblStatus.Text = "Done.";
            Application.DoEvents();
        }

        /// <summary>
        /// Govori korijenu svakog stabla da ponisti odabir svih cvorova ispod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChar_Click(object sender, EventArgs e)
        {
            //uzima cvor na najvisem polozaju za svaki disk i govori mu da se rekurzivno ocisti
            foreach(TreeNode node in tvwSource.Nodes)
            {
                SetCheck(node, false);
            }
        }

        /// <summary>
        /// Provjerava da li korisnik zaista zeli brisanje.
        /// Pravi popis i brise svaku datoteku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //pita korisnika je li siguran
            System.Windows.Forms.DialogResult result = 
                MessageBox.Show("Are you quite sure?",  //poruka
                "Delete files",                         //natpis
                MessageBoxButtons.OKCancel,             //gumbi
                MessageBoxIcon.Exclamation,             //ikone
                MessageBoxDefaultButton.Button2);       //podrazumni gumb

            //ako je korisnik siguran
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //prolazi kroz popis i brise datoteke
                //uzima popis odabranih datoteka
                List<FileInfo> fileNames = GetFileList();

                foreach(FileInfo file in fileNames)
                {
                    try
                    {
                        //azurira natpis da prikazuje napredak
                        lblStatus.Text = "Deleting " + file.Name + "...";
                        Application.DoEvents();

                        //brisanje
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        //mozda zelite nesto vise od prikazivanja poruke
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            lblStatus.Text = "Done.";
            Application.DoEvents();
        }

        /// <summary>
        /// Uzima punu putanju mape odabrane mape i kopira je u txtTargetDir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwTargetDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //uzima punu putanju za odabranu mapu
            string theFullPath = GetParentString(e.Node);

            //ako nije list zavrsit ce sa obrnutom kosom crtom
            //brise kosu crtu
            if(theFullPath.EndsWith("\\"))
            {
                theFullPath = theFullPath.Substring(0, theFullPath.Length - 1);
            }

            //dodaje putanju u polje za tekst
            txtTargetDir.Text = theFullPath;
        }

        /// <summary>
        /// Obiljezava svaki cvor ispod tekuceg s trenutnom vrijednosti obiljezenog cvora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwSource_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //poziva metodu za rekurzivni prolaz
            //e.node je cvor koji korisnik je odabrao
            //stanje oznake za potvrdu je vec promjenjeno dok se stiglo do ovog mjesta
            //zbog toga zelimo proslijediti stanje e.node.Checked
            if(e.Action != TreeViewAction.Unknown)
            {
                SetCheck(e.Node, e.Node.Checked);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeView tvw = (TreeView)sender;
            bool getFiles = tvw == tvwSource;
            TreeNode currentNode = e.Node;
            string fullName = currentNode.FullPath;
            currentNode.Nodes.Clear();
            GetSubDirectoryNodes(currentNode, fullName, getFiles, 1);
        }
    }
}
