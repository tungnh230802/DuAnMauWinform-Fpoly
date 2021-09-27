
namespace GUI_QLBANHANG
{
    partial class frm_NhanVien
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
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_tennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.pnl_role = new System.Windows.Forms.Panel();
            this.rdo_quantri = new System.Windows.Forms.RadioButton();
            this.rdo_nv = new System.Windows.Forms.RadioButton();
            this.pnl_tinhtrang = new System.Windows.Forms.Panel();
            this.rdo_ngunghd = new System.Windows.Forms.RadioButton();
            this.rdo_hd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.pnl_role.SuspendLayout();
            this.pnl_tinhtrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_title.Location = new System.Drawing.Point(399, 11);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(168, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Nhân Viên";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(15, 58);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.ForeColor = System.Drawing.Color.Blue;
            this.lbl_tennv.Location = new System.Drawing.Point(15, 97);
            this.lbl_tennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(100, 16);
            this.lbl_tennv.TabIndex = 2;
            this.lbl_tennv.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Role:";
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(140, 58);
            this.txb_email.Margin = new System.Windows.Forms.Padding(4);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(279, 22);
            this.txb_email.TabIndex = 4;
            // 
            // txb_tennv
            // 
            this.txb_tennv.Location = new System.Drawing.Point(140, 97);
            this.txb_tennv.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tennv.Name = "txb_tennv";
            this.txb_tennv.Size = new System.Drawing.Size(279, 22);
            this.txb_tennv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(471, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txb_diachi
            // 
            this.txb_diachi.Location = new System.Drawing.Point(556, 55);
            this.txb_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txb_diachi.Multiline = true;
            this.txb_diachi.Name = "txb_diachi";
            this.txb_diachi.Size = new System.Drawing.Size(401, 64);
            this.txb_diachi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(471, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(18, 188);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.Size = new System.Drawing.Size(939, 185);
            this.dgv_nhanvien.TabIndex = 14;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(23, 452);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 46);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(158, 452);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 46);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(294, 452);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 46);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(438, 452);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(109, 46);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.ForeColor = System.Drawing.Color.Black;
            this.btn_boqua.Location = new System.Drawing.Point(578, 452);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(109, 46);
            this.btn_boqua.TabIndex = 19;
            this.btn_boqua.Text = "Bỏ Qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.ForeColor = System.Drawing.Color.Black;
            this.btn_danhsach.Location = new System.Drawing.Point(710, 452);
            this.btn_danhsach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(109, 46);
            this.btn_danhsach.TabIndex = 20;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.ForeColor = System.Drawing.Color.Black;
            this.btn_dong.Location = new System.Drawing.Point(848, 452);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 46);
            this.btn_dong.TabIndex = 21;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(578, 398);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(109, 46);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.BackColor = System.Drawing.Color.LightGray;
            this.txb_timkiem.Location = new System.Drawing.Point(294, 410);
            this.txb_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(253, 22);
            this.txb_timkiem.TabIndex = 23;
            this.txb_timkiem.Click += new System.EventHandler(this.txb_timkiem_Click);
            // 
            // pnl_role
            // 
            this.pnl_role.Controls.Add(this.rdo_quantri);
            this.pnl_role.Controls.Add(this.rdo_nv);
            this.pnl_role.Location = new System.Drawing.Point(140, 126);
            this.pnl_role.Name = "pnl_role";
            this.pnl_role.Size = new System.Drawing.Size(279, 43);
            this.pnl_role.TabIndex = 24;
            // 
            // rdo_quantri
            // 
            this.rdo_quantri.AutoSize = true;
            this.rdo_quantri.ForeColor = System.Drawing.Color.Black;
            this.rdo_quantri.Location = new System.Drawing.Point(141, 11);
            this.rdo_quantri.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_quantri.Name = "rdo_quantri";
            this.rdo_quantri.Size = new System.Drawing.Size(77, 20);
            this.rdo_quantri.TabIndex = 15;
            this.rdo_quantri.TabStop = true;
            this.rdo_quantri.Text = "Quản Trị";
            this.rdo_quantri.UseVisualStyleBackColor = true;
            // 
            // rdo_nv
            // 
            this.rdo_nv.AutoSize = true;
            this.rdo_nv.ForeColor = System.Drawing.Color.Black;
            this.rdo_nv.Location = new System.Drawing.Point(5, 13);
            this.rdo_nv.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_nv.Name = "rdo_nv";
            this.rdo_nv.Size = new System.Drawing.Size(88, 20);
            this.rdo_nv.TabIndex = 14;
            this.rdo_nv.TabStop = true;
            this.rdo_nv.Text = "Nhân Viên";
            this.rdo_nv.UseVisualStyleBackColor = true;
            // 
            // pnl_tinhtrang
            // 
            this.pnl_tinhtrang.Controls.Add(this.rdo_ngunghd);
            this.pnl_tinhtrang.Controls.Add(this.rdo_hd);
            this.pnl_tinhtrang.Location = new System.Drawing.Point(559, 126);
            this.pnl_tinhtrang.Name = "pnl_tinhtrang";
            this.pnl_tinhtrang.Size = new System.Drawing.Size(398, 43);
            this.pnl_tinhtrang.TabIndex = 25;
            // 
            // rdo_ngunghd
            // 
            this.rdo_ngunghd.AutoSize = true;
            this.rdo_ngunghd.ForeColor = System.Drawing.Color.Black;
            this.rdo_ngunghd.Location = new System.Drawing.Point(157, 11);
            this.rdo_ngunghd.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_ngunghd.Name = "rdo_ngunghd";
            this.rdo_ngunghd.Size = new System.Drawing.Size(133, 20);
            this.rdo_ngunghd.TabIndex = 13;
            this.rdo_ngunghd.TabStop = true;
            this.rdo_ngunghd.Text = "Ngừng Hoạt Động";
            this.rdo_ngunghd.UseVisualStyleBackColor = true;
            // 
            // rdo_hd
            // 
            this.rdo_hd.AutoSize = true;
            this.rdo_hd.ForeColor = System.Drawing.Color.Black;
            this.rdo_hd.Location = new System.Drawing.Point(19, 13);
            this.rdo_hd.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_hd.Name = "rdo_hd";
            this.rdo_hd.Size = new System.Drawing.Size(90, 20);
            this.rdo_hd.TabIndex = 12;
            this.rdo_hd.TabStop = true;
            this.rdo_hd.Text = "Hoạt Động";
            this.rdo_hd.UseVisualStyleBackColor = true;
            // 
            // frm_NhanVien
            // 
            this.AcceptButton = this.btn_luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_dong;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.pnl_tinhtrang);
            this.Controls.Add(this.pnl_role);
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
            this.Controls.Add(this.txb_tennv);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.pnl_role.ResumeLayout(false);
            this.pnl_role.PerformLayout();
            this.pnl_tinhtrang.ResumeLayout(false);
            this.pnl_tinhtrang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.Panel pnl_role;
        private System.Windows.Forms.RadioButton rdo_quantri;
        private System.Windows.Forms.RadioButton rdo_nv;
        private System.Windows.Forms.Panel pnl_tinhtrang;
        private System.Windows.Forms.RadioButton rdo_ngunghd;
        private System.Windows.Forms.RadioButton rdo_hd;
    }
}