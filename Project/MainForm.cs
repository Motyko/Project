namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            Form f1 = new Cars();
            f1.Owner = this;
            f1.ShowDialog();
        }

        private void btn_renter_Click(object sender, EventArgs e)
        {
            Form f2 = new Persons();
            f2.Owner = this;
            f2.ShowDialog();
        }
    }
}