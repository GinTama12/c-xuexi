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
            ushort P_usint_temp;//����ֲ�����

            if (ushort.TryParse(//�������ַ���ת��Ϊ��ֵ

                text.Text, out P_usint_temp))

            {

                MessageBox.Show(//���������

                    (P_usint_temp % 4 == 0 && P_usint_temp % 100 != 0)//�ж��Ƿ�Ϊ����

                    || P_usint_temp % 400 == 0 ? "����������꣡" : "����Ĳ������꣡",

                    "��ʾ��");

            }

            else

            {

                MessageBox.Show(//��ʾ������ֵ����ȷ

                    "��������ȷ��ֵ��", "����");

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
