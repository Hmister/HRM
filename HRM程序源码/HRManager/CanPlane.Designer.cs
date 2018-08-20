namespace HRManager
{
    partial class CanPlane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanPlane));
            this.btn_userAdmin = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dep = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_userAdmin
            // 
            this.btn_userAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_userAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_userAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_userAdmin.BackgroundImage")));
            this.btn_userAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_userAdmin.FlatAppearance.BorderSize = 2;
            this.btn_userAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_userAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_userAdmin.Location = new System.Drawing.Point(171, 234);
            this.btn_userAdmin.Name = "btn_userAdmin";
            this.btn_userAdmin.Size = new System.Drawing.Size(144, 144);
            this.btn_userAdmin.TabIndex = 0;
            this.btn_userAdmin.Text = "系统账户管理";
            this.btn_userAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_userAdmin.UseVisualStyleBackColor = false;
            this.btn_userAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.panel.Controls.Add(this.lbl_tip);
            this.panel.Controls.Add(this.btn_add);
            this.panel.Controls.Add(this.btn_dep);
            this.panel.Controls.Add(this.btn_userAdmin);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, -41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1114, 581);
            this.panel.TabIndex = 1;
            // 
            // lbl_tip
            // 
            this.lbl_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("华文行楷", 70F);
            this.lbl_tip.ForeColor = System.Drawing.Color.Silver;
            this.lbl_tip.Location = new System.Drawing.Point(74, 79);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(982, 99);
            this.lbl_tip.TabIndex = 1;
            this.lbl_tip.Text = "欢迎使用最高权限界面";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(473, 234);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(144, 144);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加系统用户";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dep
            // 
            this.btn_dep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.btn_dep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dep.BackgroundImage")));
            this.btn_dep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btn_dep.FlatAppearance.BorderSize = 2;
            this.btn_dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dep.Location = new System.Drawing.Point(760, 234);
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.Size = new System.Drawing.Size(144, 144);
            this.btn_dep.TabIndex = 0;
            this.btn_dep.Text = "公司部门管理";
            this.btn_dep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dep.UseVisualStyleBackColor = false;
            this.btn_dep.Click += new System.EventHandler(this.btn_dep_Click);
            // 
            // CanPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 540);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanPlane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_userAdmin;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dep;
    }
}