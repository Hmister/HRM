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
    public partial class Main : Form
    {
        Entity.Person p = null;
        public Main(Entity.Person per)
        {
            this.p = per;
            InitializeComponent();
            LoadMenu();
            LoadInfo();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认退出软件？","退出确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        /// <summary>
        /// 加载信息
        /// </summary>
        private void LoadInfo()
        {
            System.Data.DataTable dt = EBLL.LoginBLL.LoadInfo(p);
            this.lbl_id.Text = p.pID.ToString();
            this.lbl_dep.Text= dt.Rows[0][0].ToString();
            this.lbl_job.Text= dt.Rows[0][1].ToString();
            this.lbl_ltime.Text=DateTime.Parse(dt.Rows[0][2].ToString()).ToString("yyyy年MM月dd日 HH:mm:ss");
            this.lbl_money.Text = EBLL.LoginBLL.LoadMoney(p);
        }

        //加载方法
        /// <summary>
        /// 加载菜单
        /// </summary>
        public void LoadMenu()
        {
            this.panel.Controls.Clear();
            Menu w = new Menu(this,p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }

        /// <summary>
        /// 加载请假
        /// </summary>
        public void LoadLeave()
        {
            this.panel.Controls.Clear();
            Leave w = new Leave(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }

        /// <summary>
        /// 加载消息
        /// </summary>
        public void LoadMsg()
        {
            this.panel.Controls.Clear();
            MsgRead w = new MsgRead(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }

        /// <summary>
        /// 加载奖惩情况
        /// </summary>
        public void LoadExpress()
        {
            this.panel.Controls.Clear();
            Express w = new Express(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }

        /// <summary>
        /// 加载培训记录
        /// </summary>
        public void LoadTrain()
        {
            this.panel.Controls.Clear();
            Train w = new Train(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }


        /// <summary>
        /// 加载员工自评
        /// </summary>
        public void LoadAppraise()
        {
            this.panel.Controls.Clear();
            Appraise w = new Appraise(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }


        /// <summary>
        /// 加载办公物资申领
        /// </summary>
        public void LoadGoods()
        {
            this.panel.Controls.Clear();
            Goods w = new Goods(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }


        /// <summary>
        /// 加载个人资料
        /// </summary>
        public void LoadMyInfo()
        {
            this.panel.Controls.Clear();
            MyInfo w = new MyInfo(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }


        /// <summary>
        /// 加载辞职
        /// </summary>
        public void LoadResignation()
        {
            this.panel.Controls.Clear();
            Resignation w = new Resignation(this, p);
            w.TopLevel = false;
            w.Dock = DockStyle.Fill;
            this.panel.Controls.Add(w);
            w.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            EBLL.LoginBLL.UpLast(p);
        }


        /// <summary>
        /// 一键签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Work_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (EBLL.WorkBLL.DayWork(out msg,p) == true)
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
