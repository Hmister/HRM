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
    public partial class MoneyModel : Form
    {
        public MoneyModel()
        {
            InitializeComponent();
        }

        //检测是否点击保存配置
        private bool isSave = false;
        //实体类
        Entity.MoneyModel mm =null;

        /// <summary>
        /// 同步设置到独立客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_up_Click(object sender, EventArgs e)
        {
            Msg.Box.Show("同步配置前，需选择中员工端旧文件！");
            DialogResult dr= ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return;
            }
           
            if (BLL.SalaryBLL.UpSave(ofd.FileName) == true)
            {
                Msg.Box.Show("恭喜您，同步成功！");
            }
            else
            {
                Msg.Box.Show("抱歉，同步失败！");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
             mm = new Entity.MoneyModel();
            if (this.txt_allDay.Text == "" || this.txt_allMoney.Text == "" || this.txt_day.Text == "" || this.txt_hAdd.Text == "" || this.txt_hDel.Text == "")
            {
                Msg.Box.Show("请填入完整信息！");
                return;
            }

            isSave = true;
            try
            {
                mm.shouldDay = int.Parse(this.txt_allDay.Text);
                mm.allAdd = double.Parse(this.txt_allMoney.Text);
                mm.goDay = int.Parse(this.txt_day.Text);
                mm.houeAdd = double.Parse(this.txt_hAdd.Text);
                mm.hourDel = double.Parse(this.txt_hDel.Text);
            }
            catch(Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }

            BLL.SalaryBLL.SaveSet(mm);
            Msg.Box.Show("恭喜您，保存成功！");
            this.txt_allDay.ReadOnly=true;
            this.txt_allMoney.ReadOnly = true;
            this.txt_day.ReadOnly = true;
            this.txt_hAdd.ReadOnly = true;
            this.txt_hDel.ReadOnly = true;

        }

        private void MoneyModel_Load(object sender, EventArgs e)
        {
            mm = BLL.SalaryBLL.OpenSet();
            this.txt_allDay.Text = mm.shouldDay.ToString();
            this.txt_allMoney.Text = mm.allAdd.ToString();
            this.txt_day.Text = mm.goDay.ToString();
            this.txt_hAdd.Text = mm.houeAdd.ToString();
            this.txt_hDel.Text = mm.hourDel.ToString();
        }


        /// <summary>
        /// 开始建模
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                Msg.Box.Show("请先保存设定的值！");
                return;
            }
            Entity.Pay p = new Entity.Pay();
            p.payTime = System.DateTime.Now;
            if (BLL.SalaryBLL.IsHave(p) == true)
            {
                Msg.Box.Show("下月的工资单已存在，请勿重复添加！");
                return;
            }
            try
            {
                this.pgr_go.Enabled = true;
                BLL.SalaryBLL.MakeMode();
                this.pgr_go.Value = 100;
                this.pgr_go.Enabled = false;
                Msg.Box.Show("恭喜您，建模成功！");
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (this.pgr_go.Value == 100)
            {
                this.pgr_go.Value = 0;
            }
            this.pgr_go.Value += 10;
        }
    }
}
