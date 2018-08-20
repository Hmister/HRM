namespace HRManager
{
    partial class MoneyPanle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyPanle));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_bad = new System.Windows.Forms.Button();
            this.btn_model = new System.Windows.Forms.Button();
            this.btn_good = new System.Windows.Forms.Button();
            this.btn_money = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_bad);
            this.panel.Controls.Add(this.btn_model);
            this.panel.Controls.Add(this.btn_good);
            this.panel.Controls.Add(this.btn_money);
            this.panel.Controls.Add(this.btn_All);
            this.panel.Controls.Add(this.lbl_tip);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1114, 581);
            this.panel.TabIndex = 0;
            // 
            // btn_bad
            // 
            this.btn_bad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_bad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bad.BackgroundImage")));
            this.btn_bad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_bad.FlatAppearance.BorderSize = 2;
            this.btn_bad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_bad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bad.Location = new System.Drawing.Point(502, 129);
            this.btn_bad.Name = "btn_bad";
            this.btn_bad.Size = new System.Drawing.Size(144, 144);
            this.btn_bad.TabIndex = 14;
            this.btn_bad.Text = "处 罚 员 工";
            this.btn_bad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bad.UseVisualStyleBackColor = false;
            this.btn_bad.Click += new System.EventHandler(this.btn_bad_Click);
            // 
            // btn_model
            // 
            this.btn_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_model.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_model.BackgroundImage")));
            this.btn_model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_model.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_model.FlatAppearance.BorderSize = 2;
            this.btn_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_model.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_model.Location = new System.Drawing.Point(290, 334);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(144, 144);
            this.btn_model.TabIndex = 14;
            this.btn_model.Text = "工资表建模";
            this.btn_model.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_model.UseVisualStyleBackColor = false;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // btn_good
            // 
            this.btn_good.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_good.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_good.BackgroundImage")));
            this.btn_good.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_good.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_good.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_good.FlatAppearance.BorderSize = 2;
            this.btn_good.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_good.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_good.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_good.Location = new System.Drawing.Point(290, 129);
            this.btn_good.Name = "btn_good";
            this.btn_good.Size = new System.Drawing.Size(144, 144);
            this.btn_good.TabIndex = 14;
            this.btn_good.Text = "奖 励 员 工";
            this.btn_good.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_good.UseVisualStyleBackColor = false;
            this.btn_good.Click += new System.EventHandler(this.btn_good_Click);
            // 
            // btn_money
            // 
            this.btn_money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_money.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_money.BackgroundImage")));
            this.btn_money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_money.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_money.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_money.FlatAppearance.BorderSize = 2;
            this.btn_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_money.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_money.Location = new System.Drawing.Point(77, 334);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(144, 144);
            this.btn_money.TabIndex = 14;
            this.btn_money.Text = "工资表详情";
            this.btn_money.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_money.UseVisualStyleBackColor = false;
            this.btn_money.Click += new System.EventHandler(this.btn_money_Click);
            // 
            // btn_All
            // 
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_All.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_All.BackgroundImage")));
            this.btn_All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_All.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_All.FlatAppearance.BorderSize = 2;
            this.btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_All.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_All.Location = new System.Drawing.Point(77, 129);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(144, 144);
            this.btn_All.TabIndex = 14;
            this.btn_All.Text = "员工奖惩记录";
            this.btn_All.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_All.UseVisualStyleBackColor = false;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(70, 45);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(263, 40);
            this.lbl_tip.TabIndex = 13;
            this.lbl_tip.Text = "薪资管理功能";
            // 
            // MoneyPanle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyPanle";
            this.Text = "MoneyPanle";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_good;
        private System.Windows.Forms.Button btn_bad;
        private System.Windows.Forms.Button btn_money;
        private System.Windows.Forms.Button btn_model;
    }
}