using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access
{
    public partial class Form1 : Form
    {
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source = Automobili.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet set = new DataSet();

        public Form1()
        {
            InitializeComponent();

            adapter.SelectCommand = new OleDbCommand("SELECT * FROM InformacijeAutomobila", konekcija);
            set.Clear();
            adapter.Fill(set);
            Tabela.DataSource = set.Tables[0];
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.InsertCommand = new OleDbCommand("INSERT INTO InformacijeAutomobila VALUES(@ID, @Marka, @Model, @MaxBrzina, @Tezina)", konekcija);
                adapter.InsertCommand.Parameters.Add("@ID", OleDbType.Integer).Value = ID.Text;
                adapter.InsertCommand.Parameters.Add("@Marka", OleDbType.VarChar).Value = Marka.Text;
                adapter.InsertCommand.Parameters.Add("@Model", OleDbType.VarChar).Value = Model.Text;
                adapter.InsertCommand.Parameters.Add("@MaxBrzina", OleDbType.Integer).Value = MaxBrzina.Text;
                adapter.InsertCommand.Parameters.Add("@Tezina", OleDbType.Integer).Value = Tezina.Text;

                konekcija.Open();
                adapter.InsertCommand.ExecuteNonQuery();

                ID.Text = "";
                Marka.Text = "";
                Model.Text = "";
                MaxBrzina.Text = "";
                Tezina.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void izmjeni_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.UpdateCommand = new OleDbCommand("UPDATE InformacijeAutomobila SET Marka = '" + Marka.Text + "' WHERE (ID = " + ID.Text + ")", konekcija);
                
                konekcija.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.DeleteCommand = new OleDbCommand("DELETE FROM InformacijeAutomobila WHERE (ID = " + ID.Text + ")", konekcija);

                konekcija.Open();
                adapter.DeleteCommand.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void osvjezi_Click(object sender, EventArgs e)
        {
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM InformacijeAutomobila", konekcija);
            set.Clear();
            adapter.Fill(set);
            Tabela.DataSource = set.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
