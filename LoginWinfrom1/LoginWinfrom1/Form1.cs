using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1
namespace LoginWinfrom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show_logo();
        }

        public void Show_logo()
        {
            pictureBox1.Load(@"D:\업무용\로고\회사로고.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Login Success");
            Mainpage mainpage = new Mainpage();
            mainpage.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        
    }
}
