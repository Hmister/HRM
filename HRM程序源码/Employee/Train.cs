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
    public partial class Train : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        Entity.Train a = new Entity.Train();
        public Train(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            a.pID = p.pID;
            dataGridView1.DataSource = EBLL.TrainBLL.TPNotes(a);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = EBLL.TrainBLL.TPNotes(a);
                if (this.rad_lv.Checked)
                {
                    a.nResult = this.comboBox2.Text;
                    dataGridView1.DataSource = EBLL.TrainBLL.DT(a);

                }
                else if (this.rad_time.Checked)
                {
                    a.tpStart = this.dateTimePicker1.Value;
                    dataGridView1.DataSource = EBLL.TrainBLL.DTT(a);
                }
                else
                {
                    dataGridView1.DataSource = EBLL.TrainBLL.TPNotes(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
