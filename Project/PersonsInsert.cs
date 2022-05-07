using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Project
{
    public partial class PersonsInsert : Form
    {
        SqlConnection kapcs = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=CityCars");

        public PersonsInsert()
        {
            InitializeComponent();
        }

        private void SetDefaultValuesP()
        {
            tb1P.Text = "";
            tb2P.Text = "";
            tb3P.Text = "";
            tb4P.Text = "";
            tb5P.Text = "";
            dateTimePicker1Ins.Value = DateTime.Now;
        }

        void InsertPersonInDb()
        {
            try
            {
                kapcs.Open();

                DateTime dateIns = Convert.ToDateTime(dateTimePicker1Ins.Value);
                string dtIns = dateIns.ToString("yyyy-MM-dd");
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand($"INSERT INTO Person(Szig, Nev, Irsz, Varos, Cim, Datum) VALUES ('{tb1P.Text}', '{tb2P.Text}', {int.Parse(tb3P.Text)}, '{tb4P.Text}', '{tb5P.Text}', '{dtIns}')", kapcs);
                da.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Az adat beillesztés sikertelen volt!\n{ex.Message}");
            }
            finally
            {
                kapcs.Close();
            }
        }

        private void btn_addP_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb1P.Text))
            {
                MessageBox.Show("A személyi számot kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(tb2P.Text))
            {
                MessageBox.Show("A nevet kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb3P.Text))
            {
                MessageBox.Show("Az irányító számot kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(tb4P.Text))
            {
                MessageBox.Show("A várost kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb5P.Text))
            {
                MessageBox.Show("A címet kötelező megadni!");
                return;
            }
            InsertPersonInDb();
            SetDefaultValuesP();
        }

        private void dateTimePicker1Ins_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1Ins.CustomFormat = ("yyyy-MM-dd");
        }
    }
}
