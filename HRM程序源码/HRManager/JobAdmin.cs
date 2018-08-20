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
    public partial class JobAdmin : Form
    {
        public JobAdmin()
        {
            InitializeComponent();
        }

        Entity.Job job = new Entity.Job();
        DataTable dt=BLL.DepBLL.CDp();
        private void JobAdmin_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember ="DepName";
            this.comboBox1.ValueMember = "DepID";
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            LoadJob();
        }

        /// <summary>
        /// 加载岗位的方法
        /// </summary>
        private void LoadJob()
        {
            job.depID = int.Parse(this.comboBox1.SelectedValue.ToString());
            this.listBox1.DataSource = BLL.JobChangeBLL.LoadJobs(job);
            this.listBox1.DisplayMember = "JName";
            this.listBox1.ValueMember = "JID";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.listBox1.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            job.depID=int.Parse(this.comboBox1.SelectedValue.ToString());
            job.jName = this.textBox1.Text;
            if (BLL.JobChangeBLL.AddJob(job) == true)
            {
                Msg.Box.Show("恭喜您，添加成功！");
                LoadJob();
                this.textBox1.Text = "";
            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请先选择操作项！");
                return;
            }
            job.jID = int.Parse(this.listBox1.SelectedValue.ToString());
            job.jName = this.textBox1.Text;
            if (BLL.JobChangeBLL.UpJob(job) == true)
            {
                Msg.Box.Show("恭喜您，修改成功！");
                LoadJob();
                this.textBox1.Text = "";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请先选择操作项！");
                return;
            }
            job.jID = int.Parse(this.listBox1.SelectedValue.ToString());
            try
            {
                bool isDel = Msg.Box.RShow("是否确认删除该岗位？",Msg.Box.Ico.Question);
                if (isDel == false)
                {
                    return;
                }
                if (BLL.JobChangeBLL.DelJob(job) == true)
                {
                    Msg.Box.Show("恭喜您，删除成功！");
                    LoadJob();
                    this.textBox1.Text = "";
                }


            }
            catch
            {
                Msg.Box.Show("该岗位下存在员工，请先调整员工岗位！");
                return;
            }
        }
    }
}
