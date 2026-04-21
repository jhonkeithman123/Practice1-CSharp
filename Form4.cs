namespace Practice1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void next_form_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prev_form_btn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputBox.Text = listBox1.SelectedItem?.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                MessageBox.Show("Input is empty.");
                return;
            }
            if (listBox1.Items.Contains(inputBox.Text))
            {
                MessageBox.Show("Item duplicate.");
                return;
            }
            listBox1.Items.Add(inputBox.Text);
            inputBox.Text = "";
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            inputBox.Text = "";
        }
    }
}
