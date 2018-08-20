namespace HRManager
{
    partial class PassChange
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.txt_old = new System.Windows.Forms.TextBox();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.txt_new1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_title.Location = new System.Drawing.Point(414, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(263, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "账号密码修改";
            // 
            // lbl_tip
            // 
            this.lbl_tip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(61, 33);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(164, 161);
            this.lbl_tip.TabIndex = 1;
            this.lbl_tip.Text = "请输入原密码：\r\n\r\n\r\n请输入新密码：\r\n\r\n\r\n再输入新密码：\r\n";
            // 
            // txt_old
            // 
            this.txt_old.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_old.Font = new System.Drawing.Font("新宋体", 12F);
            this.txt_old.Location = new System.Drawing.Point(231, 31);
            this.txt_old.MaxLength = 20;
            this.txt_old.Name = "txt_old";
            this.txt_old.PasswordChar = '*';
            this.txt_old.Size = new System.Drawing.Size(213, 26);
            this.txt_old.TabIndex = 0;
            // 
            // txt_new
            // 
            this.txt_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_new.Font = new System.Drawing.Font("新宋体", 12F);
            this.txt_new.Location = new System.Drawing.Point(231, 100);
            this.txt_new.MaxLength = 20;
            this.txt_new.Name = "txt_new";
            this.txt_new.PasswordChar = '*';
            this.txt_new.Size = new System.Drawing.Size(213, 26);
            this.txt_new.TabIndex = 1;
            // 
            // txt_new1
            // 
            this.txt_new1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_new1.Font = new System.Drawing.Font("新宋体", 12F);
            this.txt_new1.Location = new System.Drawing.Point(231, 168);
            this.txt_new1.MaxLength = 20;
            this.txt_new1.Name = "txt_new1";
            this.txt_new1.PasswordChar = '*';
            this.txt_new1.Size = new System.Drawing.Size(213, 26);
            this.txt_new1.TabIndex = 2;
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
            this.btn_ok.Location = new System.Drawing.Point(294, 366);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(140, 40);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "修改密码";
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
            this.btn_clear.Location = new System.Drawing.Point(656, 366);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 40);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "重新输入";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lbl_tip);
            this.groupBox1.Controls.Add(this.txt_old);
            this.groupBox1.Controls.Add(this.txt_new);
            this.groupBox1.Controls.Add(this.txt_new1);
            this.groupBox1.Location = new System.Drawing.Point(294, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PassChange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.TextBox txt_old;
        private System.Windows.Forms.TextBox txt_new;
        private System.Windows.Forms.TextBox txt_new1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}