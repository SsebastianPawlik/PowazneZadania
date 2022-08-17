using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace _5.Sklep
{
    public partial class Form1 : Form
    {
        public SQLiteConnection con = new SQLiteConnection(string.Format("Data Source = {0}", Path.Combine(Application.StartupPath, @"C:\Users\Praktykant\source\repos\5.Sklep\Sklep"))); //W razie porlbemów z bazą podmienić ścieżkę
        private SQLiteCommand sql_cmd;
        private string txtQuery;
        public Form1()
        {
            InitializeComponent();
        }
        DateTime now = DateTime.Now;
        private DataTable get()
        {
            DataTable returnTable = new DataTable();
            con.Open();
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Sklep";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(returnTable);
            con.Close();
            return returnTable;
        }
        private void BTwyswietl_Click(object sender, EventArgs e)
        {
            DataTable dt = get();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void BTdodaj_Click(object sender, EventArgs e)
        {
            con.Open();
            string Nazwa = tbNazwa.Text;
            string Kategoria = tbKategoria.Text;
            string Tresc = tbTresc.Text;
            sql_cmd = con.CreateCommand();

            sql_cmd.CommandText = txtQuery = "insert into Sklep (Nazwa, Kategoria, DataUtworzenia, Tresc) values ('" + Nazwa + "','" + Kategoria + "','" + now + "','" + Tresc + "');";

            sql_cmd.ExecuteNonQuery();

            con.Close();
          
        } 

        private void BTedytuj_Click(object sender, EventArgs e) 
        {
            con.Open();
            int ID = Convert.ToInt32(tbID.Text);
            string Nazwa = tbNazwa.Text;
            string Kategoria = tbKategoria.Text;
            string Tresc = tbTresc.Text;
            sql_cmd = con.CreateCommand();

            sql_cmd.CommandText = txtQuery = "update Sklep SET Nazwa = '" + Nazwa + "', Kategoria = '" + Kategoria + "', DataModyfikacji = '" + now + "', Tresc = '" + Tresc + "' Where ID = '" + ID + "'";

            sql_cmd.ExecuteNonQuery();
            
            con.Close();
        }
       
        private void BTskasuj_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID = Convert.ToInt32(tbID.Text);
            sql_cmd = con.CreateCommand();

            sql_cmd.CommandText = txtQuery = "DELETE FROM Sklep Where ID = '" + ID + "'";

            sql_cmd.ExecuteNonQuery();

            con.Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
