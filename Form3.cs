namespace Practice1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void prev_form_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            platform_text.Text = "";
        }

        private void platform_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Title = "Open Text File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = System.IO.File.ReadAllText(ofd.FileName);
                platform_text.Text = fileContent;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.Title = "Save Text File";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, platform_text.Text);
            }
        }
    }
}
