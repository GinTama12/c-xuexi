namespace WinFormsApp9
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
             Form2 form = new Form2();

        }
        Form2 form = new Form2();
        public void button1_Click(object sender, EventArgs e)
        {
           
            form.Show();  
        }

        public void button2_Click(object sender, EventArgs e)
        {
         form.Hide();
        }
    }
}