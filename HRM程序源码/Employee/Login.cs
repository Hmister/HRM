using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //拖动窗体
        private Point mPoint = new Point();

        private void pan_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void pan_top_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            FindPass.Main m = new FindPass.Main();
            m.ShowDialog();
        }

        Entity.Person p = new Entity.Person();

        private void btn_go_Click(object sender, EventArgs e)
        {
            try
            {
                p.pID = int.Parse(this.txt_id.Text);
                p.pPwd = this.txt_pass.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                if (EBLL.LoginBLL.ChackPass(p) == true)
                {
                    Main m = new Main(p);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
