namespace WinFormsApp6
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

        private void button1_Click(object sender, EventArgs e)
        {
            hello.Text = "¹þ¹þ";
        }

        private void lblHelloWorld_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblHelloWorld.Text = "ÎÒ²ÝÄàÂí";
        }
    }
}