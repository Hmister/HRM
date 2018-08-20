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
    public partial class Main : Form
    {
        //软件开始时间
        private static DateTime startTime;

        //login对象
        Entity.Users users = null;
        public Main(Entity.Users u)
        {
            InitializeComponent();
            startTime = System.DateTime.Now;
            this.lbl_nowTime.Text = startTime.ToString();
            users = u;
            this.lbl_userID.Text = users.uID.ToString();
            this.lbl_userName.Text = users.uName.ToString();
            this.lbl_lastTime.Text = users.lastTime.ToString();
            LoadUserLogo();

        }

        /// <summary>
        /// 加载用户头像
        /// </summary>
        public void LoadUserLogo()
        {
            string path = @"Source\User\" + users.logo + ".png";
            this.pic_userLogo.Image = Image.FromFile(path);
        }

        //拖动窗体
        private Point mPoint = new Point();

        private void Main_Load(object sender, EventArgs e)
        {
            //全屏界面
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            bool isExit = Msg.Box.RShow("请再次确认是否退出系统？","退出系统",Msg.Box.Ico.Question);
            if (isExit == true)
            {
                Application.Exit();
            }
           
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //打开帮助反馈窗口
            (new FindBug()).ShowDialog(this);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ico_main_DoubleClick(object sender, EventArgs e)
        {

            if (this.Visible == false)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        private void lbl_www_Click(object sender, EventArgs e)
        {
            //打开网址
            System.Diagnostics.Process.Start("explorer.exe", "http://www.sanmco.com");
        }

        private void lbl_www_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_www.ForeColor = Color.Blue;
        }

        private void lbl_www_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_www.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }


        /// <summary>
        /// 顶部导航样式
        /// </summary>
        private void TopMenu(object sender)
        {
            foreach (var bt in pan_top.Controls.OfType<Button>())
            {

                if (bt == sender as Button)
                {
                    bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(93)))), ((int)(((byte)(145)))));
                }
                else
                {
                    bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
                }
            }
        }

        //主页按钮
        private void btn_index_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            this.pan_change.Controls.Clear();
            this.pan_change.BackgroundImage = Image.FromFile(@"Source\Main\background.png");
        }

        //人事管理按钮
        private void btn_people_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            //内置窗体对象
            LoadPersonPanle();

        }

        /// <summary>
        /// 加载人事界面
        /// </summary>
        public void LoadPersonPanle()
        {
            this.pan_change.Controls.Clear();
            PersonPlane p = new PersonPlane(this,users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }
        //培训模块按钮
        private void btn_train_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            //内置窗体对象
            this.pan_change.Controls.Clear();
            TrainPlane p = new TrainPlane();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        //考勤按钮
        private void btn_work_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            //内置窗体对象
            this.pan_change.Controls.Clear();
            WorkPlane p = new WorkPlane(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        //薪资按钮
        private void btn_money_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            //内置窗体对象
            this.pan_change.Controls.Clear();
            MoneyPanle p = new MoneyPanle(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();

        }

        //人才招聘按钮
        private void btn_plan_Click(object sender, EventArgs e)
        {
            TopMenu(sender);
            //内置窗体对象
            this.pan_change.Controls.Clear();
            FinderManager p = new FinderManager();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();

        }

    //重启软件
    private void btn_reStart_Click(object sender, EventArgs e)
        {
            bool reStart = Msg.Box.RShow("是否注销当前登录账号？", "注销账号", Msg.Box.Ico.Question);
            if (reStart == true)
            {
                Application.Restart();
            }
        }

        /// <summary>
        /// 侧边导航样式
        /// </summary>
        private void LeftMenu(object sender)
        {
            foreach (var bt in pan_left.Controls.OfType<Button>())
            {

                if (bt == sender as Button)
                {
                    bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
                }
                else
                {
                    bt.ForeColor = System.Drawing.SystemColors.ButtonFace;;
                }
            }
        }

        private void btn_express_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            PAppraise p = new PAppraise();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();

        }

        private void btn_trainPlan_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            AllTrainPlan p = new AllTrainPlan();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_toMsg_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            MailTo p = new MailTo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_delMoney_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            MoneyExpress p = new MoneyExpress();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_addMoney_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            WorkInfo p = new WorkInfo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            FinderIf p = new FinderIf();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
            
        }

        private void btn_useWork_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            this.pan_change.Controls.Clear();
            TryUse p = new TryUse();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            if (users.uID != 10000)
            {
                Msg.Box.Show("抱歉，您的账号没有使用使用该功能的权限！");
                return;
            }

            //内置窗体对象
            this.pan_change.Controls.Clear();
            CanPlane p = new CanPlane();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            LeftMenu(sender);
            //内置窗体对象
            this.pan_change.Controls.Clear();
            SetPlane p = new SetPlane(users,this);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        //计时器
        private void tmr_time_Tick(object sender, EventArgs e)
        {
            this.lbl_nowTime.Text = System.DateTime.Now.ToString();
            TimeSpan ts = System.DateTime.Now - startTime;
            this.lbl_runTime.Text = ts.ToString();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isExit = Msg.Box.RShow("请再次确认是否退出系统？", "退出系统", Msg.Box.Ico.Question);
            if (isExit == true)
            {
                Application.Exit();
            }
        }

        private void 注销登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool reStart = Msg.Box.RShow("是否注销当前登录账号？", "注销账号", Msg.Box.Ico.Question);
            if (reStart == true)
            {
                Application.Restart();
            }
        }

        private void 软件版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //软件版本
            Msg.Box.Show("您当前使用的软件版本是:\n全新升级版  Version：2.0.0","软件版本",Msg.Box.Ico.Info);
        }

        private void 使用帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FindBug()).ShowDialog(this);
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog(this);
        }

        private void 软件界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.LoginBLL.UpLastTime(users);
            Application.Exit();
        }

        private void btn_setIfo_Click(object sender, EventArgs e)
        {
            //内置窗体对象
            this.pan_change.Controls.Clear();
            PassChange p = new PassChange(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }

        private void btn_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void btn_Main_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void pan_top_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void pan_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void pic_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void pic_title_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            this.pan_change.Controls.Clear();
            MessageTo p = new MessageTo(users );
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.pan_change.Controls.Add(p);
            p.Show();
        }
    }
}
