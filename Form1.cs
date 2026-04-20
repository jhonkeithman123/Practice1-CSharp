using System.Data;

namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
