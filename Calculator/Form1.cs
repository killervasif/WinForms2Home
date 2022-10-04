using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isLabel = false;

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "." && string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.Text += "0.";
            }           
            else
            {
                txtBox.Text += (sender as Button).Text;
            }
            isLabel = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (!isLabel && txtBox.TextLength != 0)
            {
                txtBox.Text += (sender as Label).Text;
                isLabel = true;
                return;
            }
            else
            {
                MessageBox.Show("You can't use double operations or start opeartions with");
                return;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            // DataTable().Compute() metodunu kenanin gitinden firlatdim
            double result = double.Parse(new DataTable().Compute(txtBox.Text, null).ToString()!);
            if (buttonResult.ToString() == "∞")
            {
                MessageBox.Show("Nan");
            }

            MessageBox.Show(result.ToString());
        }
    }
}