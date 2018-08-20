namespace HRManager
{
    partial class MailSet
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
            this.lbl_tip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.txt_id1 = new System.Windows.Forms.TextBox();
            this.txt_smtpk1 = new System.Windows.Forms.TextBox();
            this.txt_smtp1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.txt_smtpk2 = new System.Windows.Forms.TextBox();
            this.txt_smtp2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tip
            // 
            this.lbl_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(396, 22);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(304, 40);
            this.lbl_tip.TabIndex = 8;
            this.lbl_tip.Text = "邮件服务器配置";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txt_pass1);
            this.groupBox1.Controls.Add(this.txt_id1);
            this.groupBox1.Controls.Add(this.txt_smtpk1);
            this.groupBox1.Controls.Add(this.txt_smtp1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(254, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 发送邮件服务器配置 ";
            // 
            // txt_pass1
            // 
            this.txt_pass1.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_pass1.Location = new System.Drawing.Point(255, 140);
            this.txt_pass1.MaxLength = 30;
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.PasswordChar = '●';
            this.txt_pass1.Size = new System.Drawing.Size(190, 24);
            this.txt_pass1.TabIndex = 3;
            // 
            // txt_id1
            // 
            this.txt_id1.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_id1.Location = new System.Drawing.Point(255, 105);
            this.txt_id1.MaxLength = 30;
            this.txt_id1.Name = "txt_id1";
            this.txt_id1.Size = new System.Drawing.Size(190, 24);
            this.txt_id1.TabIndex = 2;
            // 
            // txt_smtpk1
            // 
            this.txt_smtpk1.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_smtpk1.Location = new System.Drawing.Point(255, 70);
            this.txt_smtpk1.MaxLength = 30;
            this.txt_smtpk1.Name = "txt_smtpk1";
            this.txt_smtpk1.Size = new System.Drawing.Size(190, 24);
            this.txt_smtpk1.TabIndex = 1;
            // 
            // txt_smtp1
            // 
            this.txt_smtp1.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_smtp1.Location = new System.Drawing.Point(255, 30);
            this.txt_smtp1.MaxLength = 30;
            this.txt_smtp1.Name = "txt_smtp1";
            this.txt_smtp1.Size = new System.Drawing.Size(190, 24);
            this.txt_smtp1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "邮箱密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "邮箱账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SMTP地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_pass2);
            this.groupBox2.Controls.Add(this.txt_id2);
            this.groupBox2.Controls.Add(this.txt_smtpk2);
            this.groupBox2.Controls.Add(this.txt_smtp2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(254, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 重置密码服务器设置";
            // 
            // txt_pass2
            // 
            this.txt_pass2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_pass2.Location = new System.Drawing.Point(255, 139);
            this.txt_pass2.MaxLength = 30;
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '●';
            this.txt_pass2.Size = new System.Drawing.Size(190, 24);
            this.txt_pass2.TabIndex = 3;
            // 
            // txt_id2
            // 
            this.txt_id2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_id2.Location = new System.Drawing.Point(255, 104);
            this.txt_id2.MaxLength = 30;
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.Size = new System.Drawing.Size(190, 24);
            this.txt_id2.TabIndex = 2;
            // 
            // txt_smtpk2
            // 
            this.txt_smtpk2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_smtpk2.Location = new System.Drawing.Point(255, 69);
            this.txt_smtpk2.MaxLength = 30;
            this.txt_smtpk2.Name = "txt_smtpk2";
            this.txt_smtpk2.Size = new System.Drawing.Size(190, 24);
            this.txt_smtpk2.TabIndex = 1;
            // 
            // txt_smtp2
            // 
            this.txt_smtp2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_smtp2.Location = new System.Drawing.Point(255, 29);
            this.txt_smtp2.MaxLength = 30;
            this.txt_smtp2.Name = "txt_smtp2";
            this.txt_smtp2.Size = new System.Drawing.Size(190, 24);
            this.txt_smtp2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "邮箱密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "邮箱账号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "SMTP端口：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "SMTP地址：";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ok.FlatAppearance.BorderSize = 2;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ok.Location = new System.Drawing.Point(254, 495);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(154, 35);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "保存配置";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.FlatAppearance.BorderSize = 2;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clear.Location = new System.Drawing.Point(677, 495);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(154, 35);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "同步配置";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(252, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "注意：请务必保证邮件服务器相关信息被配置！";
            // 
            // ofd
            // 
            this.ofd.FileName = "BackMail";
            this.ofd.Filter = "XML文件|*.XML";
            // 
            // MailSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailSet";
            this.Text = "MailSet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.TextBox txt_id1;
        private System.Windows.Forms.TextBox txt_smtpk1;
        private System.Windows.Forms.TextBox txt_smtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.TextBox txt_smtpk2;
        private System.Windows.Forms.TextBox txt_smtp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}