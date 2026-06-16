namespace Cars4Us
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm form = new CarsForm();
            form.ShowDialog();
        }
    }
}
