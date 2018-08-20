namespace HRManager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btn_about = new System.Windows.Forms.Button();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lbl_t = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_about.BackgroundImage")));
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_about.Enabled = false;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(0, 0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(378, 262);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "关于软件";
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // txt_tip
            // 
            this.txt_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txt_tip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tip.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt_tip.ForeColor = System.Drawing.Color.SlateBlue;
            this.txt_tip.Location = new System.Drawing.Point(120, 161);
            this.txt_tip.Multiline = true;
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.ReadOnly = true;
            this.txt_tip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_tip.Size = new System.Drawing.Size(223, 88);
            this.txt_tip.TabIndex = 14;
            this.txt_tip.Text = resources.GetString("txt_tip.Text");
            // 
            // txt_c
            // 
            this.txt_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txt_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_c.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_c.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt_c.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_c.Location = new System.Drawing.Point(121, 51);
            this.txt_c.Multiline = true;
            this.txt_c.Name = "txt_c";
            this.txt_c.ReadOnly = true;
            this.txt_c.Size = new System.Drawing.Size(188, 101);
            this.txt_c.TabIndex = 12;
            this.txt_c.Text = "人力资源管理系统\r\n\r\nV2.0.0.0\r\n\r\n2017年5月20日\r\n\r\nSanMco团队";
            this.txt_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_tip.Location = new System.Drawing.Point(40, 161);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(77, 14);
            this.lbl_tip.TabIndex = 13;
            this.lbl_tip.Text = "软件说明：";
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_t.Location = new System.Drawing.Point(40, 50);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(77, 98);
            this.lbl_t.TabIndex = 11;
            this.lbl_t.Text = "软件名称：\r\n\r\n软件版本：\r\n\r\n版本日期：\r\n\r\n软件作者：\r\n";
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Close.Location = new System.Drawing.Point(350, 11);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(25, 16);
            this.lbl_Close.TabIndex = 9;
            this.lbl_Close.Text = "×";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Min.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Min.Location = new System.Drawing.Point(323, 12);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(25, 16);
            this.lbl_Min.TabIndex = 8;
            this.lbl_Min.Text = "—";
            this.lbl_Min.Click += new System.EventHandler(this.lbl_Min_Click);
            this.lbl_Min.MouseEnter += new System.EventHandler(this.lbl_Min_MouseEnter);
            this.lbl_Min.MouseLeave += new System.EventHandler(this.lbl_Min_MouseLeave);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Title.Location = new System.Drawing.Point(27, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(63, 14);
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "关于软件";
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(2, 3);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(22, 22);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 10;
            this.pic_logo.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.ControlBox = false;
            this.Controls.Add(this.txt_tip);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_t);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于软件";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_logo;

    }
}