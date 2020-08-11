using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWinfrom1
{
    public partial class Mainpage : Form
    {
        Form1 form1 = new Form1();
        public Mainpage()
        {
            InitializeComponent();
            pictureBox1.Load(@"D:\업무용\로고\회사로고.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        /* 인원 */
        private void btnMember_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            this.Text = "인원 현황";
        }
        /* 로그아웃 */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout!!");
            this.Hide();
            form1.Show();
            

        }
        /* 내역 */
        private void btnRecord_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            this.Text = "내역 조회";
        }
        /* 실시간 */
        private void btnRealtime_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            this.Text = "실시간 조회";
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
