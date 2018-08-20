namespace HRManager
{
    partial class FinderManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderManager));
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_allPlan = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_changeJob = new System.Windows.Forms.Button();
            this.btn_tryUse = new System.Windows.Forms.Button();
            this.btn_if = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.Silver;
            this.lbl_tip.Location = new System.Drawing.Point(70, 45);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(263, 40);
            this.lbl_tip.TabIndex = 11;
            this.lbl_tip.Text = "人才招聘管理";
            // 
            // btn_allPlan
            // 
            this.btn_allPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_allPlan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_allPlan.BackgroundImage")));
            this.btn_allPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_allPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_allPlan.FlatAppearance.BorderSize = 2;
            this.btn_allPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_allPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_allPlan.Location = new System.Drawing.Point(77, 125);
            this.btn_allPlan.Name = "btn_allPlan";
            this.btn_allPlan.Size = new System.Drawing.Size(144, 144);
            this.btn_allPlan.TabIndex = 10;
            this.btn_allPlan.Text = "全部招聘计划";
            this.btn_allPlan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_allPlan.UseVisualStyleBackColor = false;
            this.btn_allPlan.Click += new System.EventHandler(this.btn_allPlan_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbl_tip);
            this.panel.Controls.Add(this.btn_changeJob);
            this.panel.Controls.Add(this.btn_leave);
            this.panel.Controls.Add(this.btn_tryUse);
            this.panel.Controls.Add(this.btn_if);
            this.panel.Controls.Add(this.btn_admin);
            this.panel.Controls.Add(this.btn_allPlan);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1114, 581);
            this.panel.TabIndex = 1;
            // 
            // btn_changeJob
            // 
            this.btn_changeJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_changeJob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_changeJob.BackgroundImage")));
            this.btn_changeJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changeJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changeJob.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_changeJob.FlatAppearance.BorderSize = 2;
            this.btn_changeJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_changeJob.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_changeJob.Location = new System.Drawing.Point(488, 125);
            this.btn_changeJob.Name = "btn_changeJob";
            this.btn_changeJob.Size = new System.Drawing.Size(144, 144);
            this.btn_changeJob.TabIndex = 10;
            this.btn_changeJob.Text = "部门岗位管理";
            this.btn_changeJob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_changeJob.UseVisualStyleBackColor = false;
            this.btn_changeJob.Click += new System.EventHandler(this.btn_changeJob_Click);
            // 
            // btn_tryUse
            // 
            this.btn_tryUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_tryUse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tryUse.BackgroundImage")));
            this.btn_tryUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tryUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tryUse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_tryUse.FlatAppearance.BorderSize = 2;
            this.btn_tryUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tryUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tryUse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tryUse.Location = new System.Drawing.Point(284, 331);
            this.btn_tryUse.Name = "btn_tryUse";
            this.btn_tryUse.Size = new System.Drawing.Size(144, 144);
            this.btn_tryUse.TabIndex = 10;
            this.btn_tryUse.Text = "实习人员管理";
            this.btn_tryUse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tryUse.UseVisualStyleBackColor = false;
            this.btn_tryUse.Click += new System.EventHandler(this.btn_tryUse_Click);
            // 
            // btn_if
            // 
            this.btn_if.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_if.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_if.BackgroundImage")));
            this.btn_if.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_if.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_if.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_if.FlatAppearance.BorderSize = 2;
            this.btn_if.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_if.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_if.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_if.Location = new System.Drawing.Point(77, 331);
            this.btn_if.Name = "btn_if";
            this.btn_if.Size = new System.Drawing.Size(144, 144);
            this.btn_if.TabIndex = 10;
            this.btn_if.Text = "全部应聘信息";
            this.btn_if.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_if.UseVisualStyleBackColor = false;
            this.btn_if.Click += new System.EventHandler(this.btn_if_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_admin.BackgroundImage")));
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_admin.FlatAppearance.BorderSize = 2;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_admin.Location = new System.Drawing.Point(284, 125);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(144, 144);
            this.btn_admin.TabIndex = 10;
            this.btn_admin.Text = "招聘计划管理";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_leave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_leave.BackgroundImage")));
            this.btn_leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_leave.FlatAppearance.BorderSize = 2;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_leave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_leave.Location = new System.Drawing.Point(488, 331);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(144, 144);
            this.btn_leave.TabIndex = 10;
            this.btn_leave.Text = "员工辞职审核";
            this.btn_leave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // FinderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinderManager";
            this.Text = "FinderManager";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_allPlan;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_if;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_tryUse;
        private System.Windows.Forms.Button btn_changeJob;
        private System.Windows.Forms.Button btn_leave;
    }
}