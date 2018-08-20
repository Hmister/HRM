namespace HRManager
{
    partial class TrainPlane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainPlane));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_addApraise = new System.Windows.Forms.Button();
            this.btn_mailTo = new System.Windows.Forms.Button();
            this.btn_allPlan = new System.Windows.Forms.Button();
            this.btn_Lesson = new System.Windows.Forms.Button();
            this.btn_userAdmin = new System.Windows.Forms.Button();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_addApraise);
            this.panel.Controls.Add(this.btn_mailTo);
            this.panel.Controls.Add(this.btn_allPlan);
            this.panel.Controls.Add(this.btn_Lesson);
            this.panel.Controls.Add(this.btn_userAdmin);
            this.panel.Controls.Add(this.lbl_tip);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1114, 540);
            this.panel.TabIndex = 0;
            // 
            // btn_addApraise
            // 
            this.btn_addApraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_addApraise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addApraise.BackgroundImage")));
            this.btn_addApraise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addApraise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addApraise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_addApraise.FlatAppearance.BorderSize = 2;
            this.btn_addApraise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addApraise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addApraise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addApraise.Location = new System.Drawing.Point(293, 312);
            this.btn_addApraise.Name = "btn_addApraise";
            this.btn_addApraise.Size = new System.Drawing.Size(144, 144);
            this.btn_addApraise.TabIndex = 6;
            this.btn_addApraise.Text = "培训情况录入";
            this.btn_addApraise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addApraise.UseVisualStyleBackColor = false;
            this.btn_addApraise.Click += new System.EventHandler(this.btn_addApraise_Click);
            // 
            // btn_mailTo
            // 
            this.btn_mailTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_mailTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mailTo.BackgroundImage")));
            this.btn_mailTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mailTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mailTo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_mailTo.FlatAppearance.BorderSize = 2;
            this.btn_mailTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_mailTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mailTo.Location = new System.Drawing.Point(77, 312);
            this.btn_mailTo.Name = "btn_mailTo";
            this.btn_mailTo.Size = new System.Drawing.Size(144, 144);
            this.btn_mailTo.TabIndex = 6;
            this.btn_mailTo.Text = "一键培训通知";
            this.btn_mailTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mailTo.UseVisualStyleBackColor = false;
            this.btn_mailTo.Click += new System.EventHandler(this.btn_mailTo_Click);
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
            this.btn_allPlan.Location = new System.Drawing.Point(77, 124);
            this.btn_allPlan.Name = "btn_allPlan";
            this.btn_allPlan.Size = new System.Drawing.Size(144, 144);
            this.btn_allPlan.TabIndex = 6;
            this.btn_allPlan.Text = "全部培训计划";
            this.btn_allPlan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_allPlan.UseVisualStyleBackColor = false;
            this.btn_allPlan.Click += new System.EventHandler(this.btn_allPlan_Click);
            // 
            // btn_Lesson
            // 
            this.btn_Lesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_Lesson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Lesson.BackgroundImage")));
            this.btn_Lesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Lesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lesson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_Lesson.FlatAppearance.BorderSize = 2;
            this.btn_Lesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Lesson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Lesson.Location = new System.Drawing.Point(504, 124);
            this.btn_Lesson.Name = "btn_Lesson";
            this.btn_Lesson.Size = new System.Drawing.Size(144, 144);
            this.btn_Lesson.TabIndex = 6;
            this.btn_Lesson.Text = "培训课程管理";
            this.btn_Lesson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Lesson.UseVisualStyleBackColor = false;
            this.btn_Lesson.Click += new System.EventHandler(this.btn_Lesson_Click);
            // 
            // btn_userAdmin
            // 
            this.btn_userAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_userAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_userAdmin.BackgroundImage")));
            this.btn_userAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_userAdmin.FlatAppearance.BorderSize = 2;
            this.btn_userAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_userAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_userAdmin.Location = new System.Drawing.Point(293, 124);
            this.btn_userAdmin.Name = "btn_userAdmin";
            this.btn_userAdmin.Size = new System.Drawing.Size(144, 144);
            this.btn_userAdmin.TabIndex = 6;
            this.btn_userAdmin.Text = "添加培训计划";
            this.btn_userAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_userAdmin.UseVisualStyleBackColor = false;
            this.btn_userAdmin.Click += new System.EventHandler(this.btn_userAdmin_Click);
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(70, 45);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(263, 40);
            this.lbl_tip.TabIndex = 5;
            this.lbl_tip.Text = "培训管理菜单";
            // 
            // TrainPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 540);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainPlane";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_userAdmin;
        private System.Windows.Forms.Button btn_mailTo;
        private System.Windows.Forms.Button btn_allPlan;
        private System.Windows.Forms.Button btn_Lesson;
        private System.Windows.Forms.Button btn_addApraise;
        private System.Windows.Forms.Label lbl_tip;
    }
}