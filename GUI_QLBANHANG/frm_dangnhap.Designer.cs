
namespace GUI_QLBANHANG
{
    partial class frm_dangnhap
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
            this.title_dangnhap = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_matkhau = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_quenmk = new System.Windows.Forms.Label();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_dangnhap
            // 
            this.title_dangnhap.AutoSize = true;
            this.title_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_dangnhap.ForeColor = System.Drawing.Color.Blue;
            this.title_dangnhap.Location = new System.Drawing.Point(93, 46);
            this.title_dangnhap.Name = "title_dangnhap";
            this.title_dangnhap.Size = new System.Drawing.Size(197, 24);
            this.title_dangnhap.TabIndex = 0;
            this.title_dangnhap.Text = "Đăng Nhập Hệ Thống";
            this.title_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(19, 95);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(93, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email Đăng Nhập:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_mk.ForeColor = System.Drawing.Color.Blue;
            this.lbl_mk.Location = new System.Drawing.Point(19, 153);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(56, 13);
            this.lbl_mk.TabIndex = 2;
            this.lbl_mk.Text = "Mật Khẩu:";
            this.lbl_mk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_email.Location = new System.Drawing.Point(23, 121);
            this.txb_email.Margin = new System.Windows.Forms.Padding(1);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(343, 20);
            this.txb_email.TabIndex = 3;
            // 
            // txb_matkhau
            // 
            this.txb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_matkhau.Location = new System.Drawing.Point(23, 181);
            this.txb_matkhau.Margin = new System.Windows.Forms.Padding(1);
            this.txb_matkhau.Name = "txb_matkhau";
            this.txb_matkhau.PasswordChar = '*';
            this.txb_matkhau.Size = new System.Drawing.Size(343, 20);
            this.txb_matkhau.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(24, 219);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ghi Nhớ Tài Khoản";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbl_quenmk
            // 
            this.lbl_quenmk.AutoSize = true;
            this.lbl_quenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_quenmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_quenmk.Location = new System.Drawing.Point(235, 220);
            this.lbl_quenmk.Name = "lbl_quenmk";
            this.lbl_quenmk.Size = new System.Drawing.Size(91, 13);
            this.lbl_quenmk.TabIndex = 6;
            this.lbl_quenmk.Text = "Quên Mật Khẩu ?";
            this.lbl_quenmk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_quenmk.Click += new System.EventHandler(this.lbl_quenmk_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_dangnhap.Location = new System.Drawing.Point(22, 252);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(1);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(344, 33);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_thoat.Location = new System.Drawing.Point(22, 288);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(1);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(344, 33);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_dangnhap
            // 
            this.AcceptButton = this.btn_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(385, 333);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.lbl_quenmk);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txb_matkhau);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.lbl_mk);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.title_dangnhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập QLBH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_dangnhap_qlbh_FormClosing);
            this.Load += new System.EventHandler(this.frm_dangnhap_qlbh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_dangnhap;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_matkhau;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_quenmk;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}

