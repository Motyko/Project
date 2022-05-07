using System.Data.SqlClient;

namespace Project
{
    public partial class CarsInsert : Form
    {
        SqlConnection kapcs = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=CityCars");

        public CarsInsert()
        {
            InitializeComponent();
        }

        private void SetDefaultValues()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
        }

        void InserCarInDb()
        {
            try
            {
                kapcs.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand($"INSERT INTO Cars(Rendszam, Evjarat, Gyartmany, Tipus, Motor, Szin, Extra, Ar, Datum) VALUES ('{tb1.Text}', {int.Parse(tb2.Text)}, '{tb3.Text}', '{tb4.Text}', '{tb5.Text}', '{tb6.Text}', '{tb7.Text}', {int.Parse(tb8.Text)}, '{tb9.Text}')", kapcs);
                da.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Az adat beillesztés sikertelen volt!\n{ex.Message}\n");
            }
            finally
            {
                kapcs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb1.Text))
            {
                MessageBox.Show("A gépkocsi rendszámát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(tb2.Text))
            {
                MessageBox.Show("A gépkocsi évjáratát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb3.Text))
            {
                MessageBox.Show("A gépkocsi gyártmányát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(tb4.Text))
            {
                MessageBox.Show("A gépkocsi típusát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb5.Text))
            {
                MessageBox.Show("A gépkocsi motorikus tulajdonságát kötelező megadni!");
                return;
            }

            if (string.IsNullOrEmpty(tb6.Text))
            {
                MessageBox.Show("A gépkocsi színét kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb7.Text))
            {
                MessageBox.Show("Amennyiben nincs benne extra jelöld(-)-vel kérlek!");
                return;
            }

            if (string.IsNullOrEmpty(tb8.Text))
            {
                MessageBox.Show("A gépkocsi árát kötelező megadni!");
                return;
            }
            if (string.IsNullOrEmpty(tb9.Text))
            {
                MessageBox.Show("A gépkocsi hozzáadás dátumát kötelező megadni!");
                return;
            }
            else
            {
                InserCarInDb();
                SetDefaultValues();
            }

        }
    }
}
