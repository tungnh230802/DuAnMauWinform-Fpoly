
namespace GUI_QLBANHANG
{
    partial class frm_ThongTinNv
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_oddPass = new System.Windows.Forms.TextBox();
            this.lbl_oddPass = new System.Windows.Forms.Label();
            this.txb_newPass = new System.Windows.Forms.TextBox();
            this.lbl_newPass = new System.Windows.Forms.Label();
            this.txb_retypePass = new System.Windows.Forms.TextBox();
            this.lbl_retypePass = new System.Windows.Forms.Label();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_title.Location = new System.Drawing.Point(83, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(248, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Đổi Mật Khẩu Nhân Viên";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(29, 79);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(107, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email Nhân Viên";
            // 
            // txb_email
            // 
            this.txb_email.Enabled = false;
            this.txb_email.Location = new System.Drawing.Point(29, 98);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(360, 22);
            this.txb_email.TabIndex = 2;
            // 
            // txb_oddPass
            // 
            this.txb_oddPass.Location = new System.Drawing.Point(29, 150);
            this.txb_oddPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_oddPass.Name = "txb_oddPass";
            this.txb_oddPass.PasswordChar = '*';
            this.txb_oddPass.Size = new System.Drawing.Size(360, 22);
            this.txb_oddPass.TabIndex = 4;
            // 
            // lbl_oddPass
            // 
            this.lbl_oddPass.AutoSize = true;
            this.lbl_oddPass.ForeColor = System.Drawing.Color.Blue;
            this.lbl_oddPass.Location = new System.Drawing.Point(29, 130);
            this.lbl_oddPass.Name = "lbl_oddPass";
            this.lbl_oddPass.Size = new System.Drawing.Size(82, 16);
            this.lbl_oddPass.TabIndex = 3;
            this.lbl_oddPass.Text = "Mật Khẩu Cũ";
            // 
            // txb_newPass
            // 
            this.txb_newPass.Location = new System.Drawing.Point(29, 201);
            this.txb_newPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_newPass.Name = "txb_newPass";
            this.txb_newPass.PasswordChar = '*';
            this.txb_newPass.Size = new System.Drawing.Size(360, 22);
            this.txb_newPass.TabIndex = 6;
            // 
            // lbl_newPass
            // 
            this.lbl_newPass.AutoSize = true;
            this.lbl_newPass.ForeColor = System.Drawing.Color.Blue;
            this.lbl_newPass.Location = new System.Drawing.Point(29, 181);
            this.lbl_newPass.Name = "lbl_newPass";
            this.lbl_newPass.Size = new System.Drawing.Size(88, 16);
            this.lbl_newPass.TabIndex = 5;
            this.lbl_newPass.Text = "Mật Khẩu Mới";
            // 
            // txb_retypePass
            // 
            this.txb_retypePass.Location = new System.Drawing.Point(29, 250);
            this.txb_retypePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_retypePass.Name = "txb_retypePass";
            this.txb_retypePass.PasswordChar = '*';
            this.txb_retypePass.Size = new System.Drawing.Size(360, 22);
            this.txb_retypePass.TabIndex = 8;
            // 
            // lbl_retypePass
            // 
            this.lbl_retypePass.AutoSize = true;
            this.lbl_retypePass.ForeColor = System.Drawing.Color.Blue;
            this.lbl_retypePass.Location = new System.Drawing.Point(29, 230);
            this.lbl_retypePass.Name = "lbl_retypePass";
            this.lbl_retypePass.Size = new System.Drawing.Size(145, 16);
            this.lbl_retypePass.TabIndex = 7;
            this.lbl_retypePass.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // btn_doimk
            // 
            this.btn_doimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_doimk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_doimk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_doimk.Location = new System.Drawing.Point(29, 290);
            this.btn_doimk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(361, 34);
            this.btn_doimk.TabIndex = 9;
            this.btn_doimk.Text = "Đổi Mật Khẩu";
            this.btn_doimk.UseVisualStyleBackColor = false;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(29, 329);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(361, 32);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_ThongTinNv
            // 
            this.AcceptButton = this.btn_doimk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.txb_retypePass);
            this.Controls.Add(this.lbl_retypePass);
            this.Controls.Add(this.txb_newPass);
            this.Controls.Add(this.lbl_newPass);
            this.Controls.Add(this.txb_oddPass);
            this.Controls.Add(this.lbl_oddPass);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongTinNv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_oddPass;
        private System.Windows.Forms.Label lbl_oddPass;
        private System.Windows.Forms.TextBox txb_newPass;
        private System.Windows.Forms.Label lbl_newPass;
        private System.Windows.Forms.TextBox txb_retypePass;
        private System.Windows.Forms.Label lbl_retypePass;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Button btn_thoat;
    }
}