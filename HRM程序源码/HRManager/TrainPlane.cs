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
    public partial class TrainPlane : Form
    {
        public TrainPlane()
        {
            InitializeComponent();
        }

        private void btn_userAdmin_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AddTrainPlan p = new AddTrainPlan();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_mailTo_Click(object sender, EventArgs e)
        {

            this.panel.Controls.Clear();
            MailTo p = new MailTo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_Lesson_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            TrainLesson p = new TrainLesson();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_addApraise_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            TPNotes p = new TPNotes();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_allPlan_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AllTrainPlan p = new AllTrainPlan();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
