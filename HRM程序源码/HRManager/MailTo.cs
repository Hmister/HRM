using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HRManager
{
    public partial class MailTo : Form
    {
        public MailTo()
        {
            InitializeComponent();
        }

        //邮件对象
        Entity.Mail mail = new Entity.Mail();
        //操作提示
        bool isu1 = false;
        bool isu2 = false;

        private void MailTo_Load(object sender, EventArgs e)
        {
            //加载部门表
            this.cmb_dep.DataSource = BLL.PersonBLL.PersonDT();
            this.cmb_dep.DisplayMember = "DepName";
            //加载计划
            this.dataGridView1.DataSource = BLL.TrainPlanBLL.SmallTP();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.lst_checked.Items.Count == 0)
            {
                Msg.Box.Show("列表内无接收人员姓名！");
                return;
            }
            if (isu1 == false)
            {
                Msg.Box.Show("请点击确认人员的按钮！");
                return;
            }
            if (isu2 == false)
            {
                Msg.Box.Show("请选择需要发送的消息！");
                return;
            }

            if (BLL.Common.ToInternet() == false)
            {
                Msg.Box.Show("请先将电脑连接至互联网！");
                return;
            }

            bool isSend = Msg.Box.RShow("是否确定发送至员工邮箱？");
            if (isSend == false)
            {
                return;
            }

          

            //人员邮件数组
            ArrayList urls = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                urls.Add(table.Rows[i][1].ToString().Trim());
            }

            try
            {
                BLL.MailToBLL.SendToPer(mail, urls);
            }
            catch (Entity.HrmException he)
            {
          
                Msg.Box.Show(he.Message);
                return;
            }

            Msg.Box.Show("恭喜您,所有邮件已成功发送！");
            this.txt_diy.Clear();
        }

        private void cmb_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            //加载岗位
            this.cmb_job.DataSource = BLL.PersonBLL.PersonDT1(this.cmb_dep.Text);
            this.cmb_job.DisplayMember = "JName";
            this.cmb_job.ValueMember = "JID";
        }

        //加载人员列表
        //数据表
        DataTable tab = null;
        DataTable table = null;
        //数据行
        DataRow dr = null;

        bool isUse = false;

        private void btn_startFind_Click(object sender, EventArgs e)
        {
            if (this.cmb_job.Text == "")
            {
                Msg.Box.Show("请先选择部门和岗位！");
                return;
            }

            try
            {

                //数据表tab结构
                //数据表
                tab = new DataTable();
                //创建姓名数据列
                DataColumn Name = new DataColumn("Name");
                Name.DataType = typeof(string);
                tab.Columns.Add(Name);
                //创建邮箱数据列
                DataColumn Mail = new DataColumn("Mail");
                Mail.DataType = typeof(string);
                tab.Columns.Add(Mail);

                //清空项与数据
                this.lst_per.Items.Clear();
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    tab.Rows[i].Delete();
                }

                //添加选项集合
                Entity.Person p = new Entity.Person();
                p.jID = int.Parse(this.cmb_job.SelectedValue.ToString());
                DataTable dt = BLL.PersonBLL.FindMail(p);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.lst_per.Items.Add(dt.Rows[i][0].ToString());
                    dr = tab.NewRow();
                    dr["Name"] = dt.Rows[i][0].ToString();
                    dr["Mail"] = dt.Rows[i][1].ToString();
                    tab.Rows.Add(dr);
                }
                this.lst_per.SelectedIndex = 0;
            }
            catch (Exception)
            {
                Msg.Box.Show("该岗位下暂无人员！");
                return;
            }

            if (isUse == false)
                {
                    //数据表table结构
                    //数据表
                    table = new DataTable();
                    //创建姓名数据列
                    DataColumn CName = new DataColumn("PName");
                    CName.DataType = typeof(string);
                    table.Columns.Add(CName);
                    //创建邮箱数据列
                    DataColumn CMail = new DataColumn("PMail");
                    CMail.DataType = typeof(string);
                    table.Columns.Add(CMail);
                }
                isUse = true;

            
          

        }

        private void btn_addAll_Click(object sender, EventArgs e)
        {
           
            if (this.lst_per.Items.Count == 0)
            {
                Msg.Box.Show("请先筛选人员！");
                return;
            }

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                this.lst_checked.Items.Add(tab.Rows[i][0].ToString());
                dr = table.NewRow();
                dr["PName"] = tab.Rows[i][0].ToString();
                dr["PMail"] = tab.Rows[i][1].ToString();
                table.Rows.Add(dr);

            }
            this.lst_checked.SelectedIndex = 0;
        }

        private void btn_addSelect_Click(object sender, EventArgs e)
        {
            if (this.lst_per.Items.Count == 0)
            {
                Msg.Box.Show("请先筛选人员！");
                return;
            }
            //添加到列表框
            this.lst_checked.Items.Add(this.lst_per.SelectedItem);
            //添加到数据表
            dr = table.NewRow();
            dr["PName"] = tab.Rows[this.lst_per.SelectedIndex][0].ToString();
            dr["PMail"] = tab.Rows[this.lst_per.SelectedIndex][1].ToString();
            table.Rows.Add(dr);
            this.lst_checked.SelectedIndex = 0;
            this.lst_per.SelectedIndex = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (this.lst_checked.Items.Count == 0)
            {
                Msg.Box.Show("列表内无人员姓名！");
                return;
            }
            try
            {
                //移除列表框项
                this.lst_checked.Items.Remove(this.lst_checked.SelectedItem);
                //移除行
                table.Rows[this.lst_checked.SelectedIndex].Delete();

                this.lst_checked.SelectedIndex = 0;
            }
            catch (Exception)
            {
                Msg.Box.Show("请先选择人员！");
                return;
            }

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            isu1 = true;
            if (this.lst_checked.Items.Count == 0)
            {
                Msg.Box.Show("列表内无人员姓名！");
                return;
            }

        }

        private void btn_plan_Click(object sender, EventArgs e)
        {
            isu2 = true;
            mail.title = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "培训计划";
            mail.text = string.Format("培训课程：\n{0}\n 培训地点：\n{1}\n课程讲师：\n{2}\n开始时间：\n{3}\n结束时间：\n{4}\n课程内容:\n{5}", this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(), this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            isu2 = true;
            mail.title = "公司通知";
            mail.text = "公司" + System.DateTime.Now.ToString("yyyy年MM月dd日") + "通知如下:\n" + this.txt_diy.Text;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_diy.Clear();
        }
    }
}
