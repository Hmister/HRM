using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //窗体加载事件
        private void Login_Load(object sender, EventArgs e)
        {
           
            this.txt_id.Select(0,0);
            
        }


        //拖动窗体
        private Point mPoint = new Point();
      
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            } 
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }


        // 退出程序
        private void btn_Quit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        // 最小化窗口
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        // 退出程序
        private void btn_Tui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // 清空密码
        private void pic_reset_Click(object sender, EventArgs e)
        {
            this.txt_pass.Clear();
            this.pic_reset.Visible = false;
        }



        //显示清除按钮
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            this.pic_reset.Visible = true;
            
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (this.txt_pass.Text == "")
            {
                this.lbl_pass_tip.Visible = true;
            }
            this.pic_reset.Visible = false;
        }

        
        // 密码明密转换
        private void pic_nosee_Click(object sender, EventArgs e)
        {
            this.pic_nosee.Visible = false;
            this.pic_see.Visible = true;
            this.txt_pass.PasswordChar = '\0';
        }

        private void pic_see_Click(object sender, EventArgs e)
        {

            this.pic_nosee.Visible = true;
            this.pic_see.Visible = false;
            this.txt_pass.PasswordChar = '●';
        }



        // 退出按钮样式
        private void btn_Tui_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Tui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btn_Tui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));

        }

        private void btn_Tui_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Tui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_Tui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));

        }


        //最小化按钮样式
        private void btn_min_MouseEnter(object sender, EventArgs e)
        {
            this.btn_min.BackColor = System.Drawing.Color.DimGray;
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));

        }

        private void btn_min_MouseLeave(object sender, EventArgs e)
        {
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));

        }


        //注册链接样式
        private void lbl_reg_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(183)))), ((int)(((byte)(181)))));

        }

        private void lbl_reg_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_reg.ForeColor = System.Drawing.Color.White;

        }


        //帐号密码提示
        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (this.txt_id.Text == "")
            {
                this.lbl_id_tip.Visible = true;
            }
        }

        private void txt_id_Click(object sender, EventArgs e)
        {
            this.lbl_id_tip.Visible = false;
        }

        private void lbl_pass_tip_Click(object sender, EventArgs e)
        {
            this.lbl_pass_tip.Visible = false;
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            this.lbl_pass_tip.Visible = false;
        }

        private void lbl_id_tip_Click(object sender, EventArgs e)
        {
            this.lbl_id_tip.Visible = false;
        }


        //取消提示
        private void btn_login_Leave(object sender, EventArgs e)
        {

            this.pic_tip.Visible = false;
            this.lbl_tip.Visible = false;
        }


        //登录功能
        private void btn_login_Click(object sender, EventArgs e)
          {
            //判断是否为空
            if (this.txt_id.Text == "" || this.txt_pass.Text == "")
            {
                this.pic_tip.Visible = true;
                this.lbl_tip.Visible = true;
                this.lbl_tip.Text = "帐号或密码不能为空！";
                return;
            }
            Entity.Users users = new Entity.Users();
            users.uName = this.txt_id.Text;
            users.uPwd = this.txt_pass.Text;

            //声明变量接收登陆情况
            bool IsTrue;
            try
            {
                IsTrue = BLL.LoginBLL.TestLogin(users);
            }
            catch (Exception)
            {
                Msg.Box.Show("请先将软件连接至数据库！", "警告信息", Msg.Box.Ico.Warining);
                return;
            }

            //错误提示

            if (IsTrue == false)
            {
                this.pic_tip.Visible = true;
                this.lbl_tip.Visible = true;
                this.lbl_tip.Text = "帐号或密码错误！";
                return;
            }
            else
            {
                string msg;
                if (BLL.LoginBLL.UserInfo(users, out msg) == 0)
                {
                    this.pic_tip.Visible = true;
                    this.lbl_tip.Visible = true;
                    this.lbl_tip.Text =msg;
                }
                else
                {
                    (new Main(users)).Show(this);
                    this.Hide();
                    this.ico_all.Visible = false;
                }
             }
        }
        
        //注册帐号
        private void lbl_reg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();

        }


        //退出程序
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //显示界面
        private void 登陆界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ico_all_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                this.btn_login.Focus();
            }
            else
            {
                this.Hide();
            }
        }


        //登录按钮样式
        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            this.btn_login.BackgroundImage = Image.FromFile(@"Source\Common\btn_e.png");
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            this.btn_login.BackgroundImage = Image.FromFile(@"Source\Common\btn_u.png");
        }


        //退出按钮样式
        private void btn_Quit_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Quit.BackgroundImage = Image.FromFile(@"Source\Common\btn_e.png");
        }

        private void btn_Quit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Quit.BackgroundImage = Image.FromFile(@"Source\Common\btn_u.png");

        }


        //打开关于软件
        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=Application.OpenForms["About"];
            if (f == null)
            {
                About a = new About();
                a.ShowDialog();
            }
            else
            {
                f.Focus();
            }
        }


        //打开异常反馈
        private void 异常反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FindBug"];  //查找是否打开过FindBug窗体  
            if (f == null)  //没打开过  
            {
                FindBug fb = new FindBug();
                fb.ShowDialog(); //重新new一个Show出来  
            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            FindPass.Main m = new FindPass.Main();
            m.ShowDialog();
        }
    }
}
