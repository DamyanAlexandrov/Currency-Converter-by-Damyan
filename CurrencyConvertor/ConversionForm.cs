namespace Currency_Converter
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            const decimal ConversionCoefficient = 1.95583m;
            decimal amountBGN = this.numericUpDowAmmount.Value;
            decimal amountEUR = amountBGN / ConversionCoefficient;

            this.resultLable.Text = $"{amountBGN} BGN = {amountEUR:f2} EUR";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}