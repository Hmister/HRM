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
    public partial class Express : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        Entity.Express ap = new Entity.Express();
        public Express(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            ap.pID = p.pID;
            dataGridView1.DataSource = EBLL.MoneyBLL.unio(ap);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //try
            //{
                dataGridView1.DataSource = EBLL.MoneyBLL.unio(ap);
                if (this.rad_type.Checked)
                {
                    ap.eType = this.comboBox2.Text;
                    dataGridView1.DataSource = EBLL.MoneyBLL.pin(ap);

                }
                else if (this.rad_time.Checked)
                {
                    ap.eTime = this.dateTimePicker1.Value;
                    dataGridView1.DataSource = EBLL.MoneyBLL.depa(ap);

                }
                else
                {
                    dataGridView1.DataSource = EBLL.MoneyBLL.unio(ap);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}

        }
















    }
}
