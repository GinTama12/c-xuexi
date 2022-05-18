namespace WinFormsApp10
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort P_usint_temp;//定义局部变量

            if (ushort.TryParse(//将输入字符串转换为数值

                text.Text, out P_usint_temp))

            {

                MessageBox.Show(//输出计算结果

                    (P_usint_temp % 4 == 0 && P_usint_temp % 100 != 0)//判断是否为闰年

                    || P_usint_temp % 400 == 0 ? "输入的是闰年！" : "输入的不是闰年！",

                    "提示！");

            }

            else

            {

                MessageBox.Show(//提示输入数值不正确

                    "请输入正确数值！", "错误！");

            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
