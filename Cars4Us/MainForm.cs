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

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm();
            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();
            form.ShowDialog();
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            PricingForm form = new PricingForm();
            form.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            form.ShowDialog();
        }
    }
}
