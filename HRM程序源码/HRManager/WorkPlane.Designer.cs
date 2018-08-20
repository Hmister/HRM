namespace HRManager
{
    partial class WorkPlane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkPlane));
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addGoods = new System.Windows.Forms.Button();
            this.btn_allGoods = new System.Windows.Forms.Button();
            this.btn_work = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_ChangeInfo = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbl_tip);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.btn_addGoods);
            this.panel.Controls.Add(this.btn_allGoods);
            this.panel.Controls.Add(this.btn_work);
            this.panel.Controls.Add(this.btn_info);
            this.panel.Controls.Add(this.btn_ChangeInfo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1114, 581);
            this.panel.TabIndex = 0;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(70, 45);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(263, 40);
            this.lbl_tip.TabIndex = 8;
            this.lbl_tip.Text = "日常工作管理";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(515, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 144);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加请假记录";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addGoods
            // 
            this.btn_addGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_addGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addGoods.BackgroundImage")));
            this.btn_addGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addGoods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_addGoods.FlatAppearance.BorderSize = 2;
            this.btn_addGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addGoods.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addGoods.Location = new System.Drawing.Point(515, 335);
            this.btn_addGoods.Name = "btn_addGoods";
            this.btn_addGoods.Size = new System.Drawing.Size(144, 144);
            this.btn_addGoods.TabIndex = 6;
            this.btn_addGoods.Text = " 添 加 物 资";
            this.btn_addGoods.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addGoods.UseVisualStyleBackColor = false;
            this.btn_addGoods.Click += new System.EventHandler(this.btn_addGoods_Click);
            // 
            // btn_allGoods
            // 
            this.btn_allGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_allGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_allGoods.BackgroundImage")));
            this.btn_allGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_allGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allGoods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_allGoods.FlatAppearance.BorderSize = 2;
            this.btn_allGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_allGoods.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_allGoods.Location = new System.Drawing.Point(297, 335);
            this.btn_allGoods.Name = "btn_allGoods";
            this.btn_allGoods.Size = new System.Drawing.Size(144, 144);
            this.btn_allGoods.TabIndex = 6;
            this.btn_allGoods.Text = "现有物资详情";
            this.btn_allGoods.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_allGoods.UseVisualStyleBackColor = false;
            this.btn_allGoods.Click += new System.EventHandler(this.btn_allGoods_Click);
            // 
            // btn_work
            // 
            this.btn_work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_work.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_work.BackgroundImage")));
            this.btn_work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_work.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_work.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_work.FlatAppearance.BorderSize = 2;
            this.btn_work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_work.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_work.Location = new System.Drawing.Point(77, 335);
            this.btn_work.Name = "btn_work";
            this.btn_work.Size = new System.Drawing.Size(144, 144);
            this.btn_work.TabIndex = 6;
            this.btn_work.Text = "人员考勤记录";
            this.btn_work.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_work.UseVisualStyleBackColor = false;
            this.btn_work.Click += new System.EventHandler(this.btn_work_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info.BackgroundImage")));
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_info.FlatAppearance.BorderSize = 2;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_info.Location = new System.Drawing.Point(77, 136);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(144, 144);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "人员休假记录";
            this.btn_info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_ChangeInfo
            // 
            this.btn_ChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_ChangeInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChangeInfo.BackgroundImage")));
            this.btn_ChangeInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_ChangeInfo.FlatAppearance.BorderSize = 2;
            this.btn_ChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ChangeInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ChangeInfo.Location = new System.Drawing.Point(297, 136);
            this.btn_ChangeInfo.Name = "btn_ChangeInfo";
            this.btn_ChangeInfo.Size = new System.Drawing.Size(144, 144);
            this.btn_ChangeInfo.TabIndex = 6;
            this.btn_ChangeInfo.Text = "人员请假审核";
            this.btn_ChangeInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ChangeInfo.UseVisualStyleBackColor = false;
            this.btn_ChangeInfo.Click += new System.EventHandler(this.btn_ChangeInfo_Click);
            // 
            // WorkPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkPlane";
            this.Text = "WorkPlane";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_ChangeInfo;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_work;
        private System.Windows.Forms.Button btn_addGoods;
        private System.Windows.Forms.Button btn_allGoods;
    }
}