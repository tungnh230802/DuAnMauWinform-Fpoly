
namespace GUI_QLBANHANG
{
    partial class frm_KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_tenkh = new System.Windows.Forms.TextBox();
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.ForeColor = System.Drawing.Color.Black;
            this.rdo_nu.Location = new System.Drawing.Point(696, 122);
            this.rdo_nu.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(43, 20);
            this.rdo_nu.TabIndex = 13;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.ForeColor = System.Drawing.Color.Black;
            this.rdo_nam.Location = new System.Drawing.Point(582, 122);
            this.rdo_nam.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(55, 20);
            this.rdo_nam.TabIndex = 12;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.BackColor = System.Drawing.Color.LightGray;
            this.txb_timkiem.Location = new System.Drawing.Point(302, 412);
            this.txb_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(253, 22);
            this.txb_timkiem.TabIndex = 43;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(586, 400);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(109, 46);
            this.btn_timkiem.TabIndex = 42;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_dong
            // 
            this.btn_dong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dong.ForeColor = System.Drawing.Color.Black;
            this.btn_dong.Location = new System.Drawing.Point(856, 454);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 46);
            this.btn_dong.TabIndex = 41;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.ForeColor = System.Drawing.Color.Black;
            this.btn_danhsach.Location = new System.Drawing.Point(718, 454);
            this.btn_danhsach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(109, 46);
            this.btn_danhsach.TabIndex = 40;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            // 
            // btn_boqua
            // 
            this.btn_boqua.ForeColor = System.Drawing.Color.Black;
            this.btn_boqua.Location = new System.Drawing.Point(586, 454);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(109, 46);
            this.btn_boqua.TabIndex = 39;
            this.btn_boqua.Text = "Bỏ Qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(446, 454);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(109, 46);
            this.btn_luu.TabIndex = 38;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(302, 454);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 46);
            this.btn_sua.TabIndex = 37;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(166, 454);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 46);
            this.btn_xoa.TabIndex = 36;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(31, 454);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 46);
            this.btn_them.TabIndex = 35;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(26, 190);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.Size = new System.Drawing.Size(939, 185);
            this.dgv_nhanvien.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(481, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Giới Tính:";
            // 
            // txb_diachi
            // 
            this.txb_diachi.Location = new System.Drawing.Point(566, 82);
            this.txb_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txb_diachi.Name = "txb_diachi";
            this.txb_diachi.Size = new System.Drawing.Size(359, 22);
            this.txb_diachi.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(481, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txb_tenkh
            // 
            this.txb_tenkh.Location = new System.Drawing.Point(150, 124);
            this.txb_tenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tenkh.Name = "txb_tenkh";
            this.txb_tenkh.Size = new System.Drawing.Size(279, 22);
            this.txb_tenkh.TabIndex = 30;
            // 
            // txb_sdt
            // 
            this.txb_sdt.Location = new System.Drawing.Point(150, 85);
            this.txb_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(279, 22);
            this.txb_sdt.TabIndex = 29;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.ForeColor = System.Drawing.Color.Blue;
            this.lbl_tennv.Location = new System.Drawing.Point(25, 124);
            this.lbl_tennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(77, 16);
            this.lbl_tennv.TabIndex = 27;
            this.lbl_tennv.Text = "Họ và Tên :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(25, 85);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(76, 16);
            this.lbl_email.TabIndex = 26;
            this.lbl_email.Text = "Điện Thoại:";
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.rdo_nu);
            this.Controls.Add(this.rdo_nam);
            this.Controls.Add(this.txb_timkiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_tenkh);
            this.Controls.Add(this.txb_sdt);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_tenkh;
        private System.Windows.Forms.TextBox txb_sdt;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.Label lbl_email;
    }
}