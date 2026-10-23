namespace FactorialCalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumber1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TxtNumber.Text);

            if (number < 1 || number > 20)
            {
                MessageBox.Show("Please enter a number between 1 and 20.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ulong factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= (ulong)i;
            }

            TxtFactorial.Text = $"{number}! = {factorial}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
