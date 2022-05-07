using System.Data.SqlClient;

namespace Project
{
    public partial class Cars : Form
    {
        SqlConnection kapcsolat = new SqlConnection(@"Server=(localdb)\MSSQLlocalDB; Database=CityCars");

        public Cars()
        {
            InitializeComponent();
        }

        private void feltolt()
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB; Database=CityCars";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = "SELECT * FROM Cars";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();
            dgvCars.Rows.Clear();
            ures();
            while (lekerdez.Read())
            {
                DateTime date = Convert.ToDateTime(lekerdez[9]);
                string dt = date.ToString("yyyy-MM-dd");
                dgvCars.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2], lekerdez[3], lekerdez[4], lekerdez[5], lekerdez[6], lekerdez[7], lekerdez[8], dt);
            }
            kapcsolat.Close();
        }

        private void ures()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            tbId.Text = "";
        }

        void UpdateCarInDb()
        {
            try
            {
                kapcsolat.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = new SqlCommand($"UPDATE cars SET Rendszam='{textBox1.Text}', Evjarat={textBox2.Text}, Gyartmany='{textBox3.Text}', Tipus='{textBox4.Text}', Motor='{textBox5.Text}', Szin='{textBox6.Text}', Extra='{textBox7.Text}', Ar={textBox8.Text}, Datum='{textBox9.Text}'  WHERE Id ={tbId.Text};", kapcsolat);
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

        void DeleteCarFromDb()
        {
            try
            {
                kapcsolat.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.DeleteCommand = new SqlCommand($"DELETE FROM Cars WHERE id={tbId.Text};", kapcsolat);
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            feltolt();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1)
            {
                textBox1.Text=dgvCars.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text=dgvCars.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text=dgvCars.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text=dgvCars.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text=dgvCars.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox6.Text=dgvCars.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox7.Text=dgvCars.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox8.Text=dgvCars.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox9.Text=dgvCars.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbId.Text = dgvCars.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                ures();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form f2 = new CarsInsert();
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("A módosításhoz ki kell jelölni egy elemet!");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("A gépkocsi rendszámát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("A gépkocsi évjáratát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("A gépkocsi gyártmányát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("A gépkocsi típusát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("A gépkocsi motorikus tulajdonságát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("A gépkocsi színét kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Amennyiben nincs benne extra jelöld(-)-vel kérlek!");
                return;
            }

            if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("A gépkocsi árát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("A gépkocsi hozzáadás dátumát kötelező megadni!");
                return;
            }
            else
            {
                UpdateCarInDb();
                ures();
                feltolt();
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("A törléshez ki kell jelölni egy elemet!");
                return;
            }
            else
            {
                DeleteCarFromDb();
                ures();
                feltolt();
                MessageBox.Show("Sikeres törlés!");
            }
        }
    }


}
