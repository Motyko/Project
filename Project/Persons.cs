using System.Data.SqlClient;

namespace Project
{
    public partial class Persons : Form
    {
        SqlConnection kapcsolat = new SqlConnection(@"Server=(localdb)\MSSQLlocalDB; Database=CityCars");

        public Persons()
        {
            InitializeComponent();
        }

        private void feltoltP()
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB; Database=CityCars";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = "SELECT * FROM Person";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();
            dgvPersons.Rows.Clear();
            ures();
            while (lekerdez.Read())
            {
                DateTime dateP = Convert.ToDateTime(lekerdez[6]);
                string dtP = dateP.ToString("yyyy-MM-dd");
                dgvPersons.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2], lekerdez[3], lekerdez[4], lekerdez[5], dtP);
            }
            kapcsolat.Close();
        }

        private void ures()
        {
            textBox1P.Text = "";
            textBox2P.Text = "";
            textBox3P.Text = "";
            textBox4P.Text = "";
            textBox5P.Text = "";
            tbIdP.Text = "";
            dateTimePicker1.CustomFormat = " ";
        }

        void UpdatePersonInDb()
        {
            try
            {
                kapcsolat.Open();

                DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
                string dt = date.ToString("yyyy-MM-dd");
                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = new SqlCommand($"UPDATE Person SET Szig='{textBox1P.Text}', Nev='{textBox2P.Text}', Irsz={textBox3P.Text}, Varos='{textBox4P.Text}', Cim='{textBox5P.Text}', datum='{dt}'  WHERE Id ={tbIdP.Text};", kapcsolat);
                da.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Az adat módosítás sikertelen volt!\n{ex.Message}");
            }
            finally
            {
                kapcsolat.Close();
            }
        }

        void DeletePersonFromDb()
        {
            try
            {
                kapcsolat.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.DeleteCommand = new SqlCommand($"DELETE FROM Person WHERE id={tbIdP.Text};", kapcsolat);
                da.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A törlés sikertelen volt\n{ex.Message}");
            }
            finally
            {
                kapcsolat.Close();
            }
        }

        private void btn_RefreshP_Click(object sender, EventArgs e)
        {
            feltoltP();
        }

        private void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                DateTime dt = Convert.ToDateTime(dgvPersons.Rows[e.RowIndex].Cells[6].Value);
                textBox1P.Text=dgvPersons.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2P.Text=dgvPersons.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3P.Text=dgvPersons.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4P.Text=dgvPersons.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5P.Text=dgvPersons.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateTimePicker1.Value = dt;
                tbIdP.Text=dgvPersons.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                ures();
            }
        }

        private void btn_NewP_Click(object sender, EventArgs e)
        {
            Form f3 = new PersonsInsert();
            f3.Owner = this;
            f3.ShowDialog();
                
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = ("yyyy-MM-dd");
        }

        private void btn_UpdateP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdP.Text))
            {
                MessageBox.Show("A módosításhoz ki kell jelölni egy elemet!");
                return;
            }

            if (string.IsNullOrEmpty(textBox1P.Text))
            {
                MessageBox.Show("A személyi számot kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(textBox2P.Text))
            {
                MessageBox.Show("A nevet kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox3P.Text))
            {
                MessageBox.Show("Az irányító számot kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(textBox4P.Text))
            {
                MessageBox.Show("A várost kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox5P.Text))
            {
                MessageBox.Show("A címet kötelező megadni!");
                return;
            }
            else
            { 
                UpdatePersonInDb();
                ures();
                feltoltP();
            }
        }

        private void btn_DeleteP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdP.Text))
            {
                MessageBox.Show("A törléshez ki kell jelölni egy elemet!");
                return;
            }
            else
            {
                DeletePersonFromDb();
                ures();
                feltoltP();
                MessageBox.Show("Sikeres törlés!");
            }
        }
    }
}
