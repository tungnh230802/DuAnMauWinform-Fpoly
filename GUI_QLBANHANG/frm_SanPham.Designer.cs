
namespace GUI_QLBANHANG
{
    partial class frm_SanPham
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
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_tensp = new System.Windows.Forms.TextBox();
            this.txb_MaHang = new System.Windows.Forms.TextBox();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txb_dongianhap = new System.Windows.Forms.TextBox();
            this.txb_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_dongiaban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_hinh = new System.Windows.Forms.TextBox();
            this.txb_ghichu = new System.Windows.Forms.TextBox();
            this.btn_mohinh = new System.Windows.Forms.Button();
            this.ptb_hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.BackColor = System.Drawing.Color.LightGray;
            this.txb_timkiem.Location = new System.Drawing.Point(300, 436);
            this.txb_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(253, 22);
            this.txb_timkiem.TabIndex = 44;
            this.txb_timkiem.Click += new System.EventHandler(this.txb_timkiem_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(584, 424);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(109, 46);
            this.btn_timkiem.TabIndex = 43;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dong.ForeColor = System.Drawing.Color.Black;
            this.btn_dong.Location = new System.Drawing.Point(854, 478);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 46);
            this.btn_dong.TabIndex = 42;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.ForeColor = System.Drawing.Color.Black;
            this.btn_danhsach.Location = new System.Drawing.Point(716, 478);
            this.btn_danhsach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(109, 46);
            this.btn_danhsach.TabIndex = 41;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.ForeColor = System.Drawing.Color.Black;
            this.btn_boqua.Location = new System.Drawing.Point(584, 478);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(109, 46);
            this.btn_boqua.TabIndex = 40;
            this.btn_boqua.Text = "Bỏ Qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(444, 478);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(109, 46);
            this.btn_luu.TabIndex = 39;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(300, 478);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 46);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(164, 478);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 46);
            this.btn_xoa.TabIndex = 37;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(29, 478);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 46);
            this.btn_them.TabIndex = 36;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(24, 209);
            this.dgv_sanpham.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(944, 207);
            this.dgv_sanpham.TabIndex = 35;
            this.dgv_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(441, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Hình:";
            // 
            // txb_tensp
            // 
            this.txb_tensp.Location = new System.Drawing.Point(146, 89);
            this.txb_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tensp.Name = "txb_tensp";
            this.txb_tensp.Size = new System.Drawing.Size(279, 22);
            this.txb_tensp.TabIndex = 31;
            // 
            // txb_MaHang
            // 
            this.txb_MaHang.Location = new System.Drawing.Point(146, 59);
            this.txb_MaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaHang.Name = "txb_MaHang";
            this.txb_MaHang.Size = new System.Drawing.Size(279, 22);
            this.txb_MaHang.TabIndex = 30;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.ForeColor = System.Drawing.Color.Blue;
            this.lbl_tennv.Location = new System.Drawing.Point(21, 89);
            this.lbl_tennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(71, 16);
            this.lbl_tennv.TabIndex = 28;
            this.lbl_tennv.Text = "Tên Hàng:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(21, 59);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 16);
            this.lbl_email.TabIndex = 27;
            this.lbl_email.Text = "Mã Hàng:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_title.Location = new System.Drawing.Point(405, 12);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(167, 37);
            this.lbl_title.TabIndex = 26;
            this.lbl_title.Text = "Sản Phẩm";
            // 
            // txb_dongianhap
            // 
            this.txb_dongianhap.Location = new System.Drawing.Point(146, 149);
            this.txb_dongianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txb_dongianhap.Name = "txb_dongianhap";
            this.txb_dongianhap.Size = new System.Drawing.Size(279, 22);
            this.txb_dongianhap.TabIndex = 48;
            // 
            // txb_soluong
            // 
            this.txb_soluong.Location = new System.Drawing.Point(146, 119);
            this.txb_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txb_soluong.Name = "txb_soluong";
            this.txb_soluong.Size = new System.Drawing.Size(279, 22);
            this.txb_soluong.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Đơn Giá Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số Lượng:";
            // 
            // txb_dongiaban
            // 
            this.txb_dongiaban.Location = new System.Drawing.Point(146, 179);
            this.txb_dongiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txb_dongiaban.Name = "txb_dongiaban";
            this.txb_dongiaban.Size = new System.Drawing.Size(279, 22);
            this.txb_dongiaban.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Đơn Giá Bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(441, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ghi Chú:";
            // 
            // txb_hinh
            // 
            this.txb_hinh.Location = new System.Drawing.Point(504, 59);
            this.txb_hinh.Margin = new System.Windows.Forms.Padding(4);
            this.txb_hinh.Multiline = true;
            this.txb_hinh.Name = "txb_hinh";
            this.txb_hinh.Size = new System.Drawing.Size(162, 46);
            this.txb_hinh.TabIndex = 52;
            // 
            // txb_ghichu
            // 
            this.txb_ghichu.Location = new System.Drawing.Point(504, 116);
            this.txb_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ghichu.Multiline = true;
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.Size = new System.Drawing.Size(285, 85);
            this.txb_ghichu.TabIndex = 53;
            // 
            // btn_mohinh
            // 
            this.btn_mohinh.ForeColor = System.Drawing.Color.Black;
            this.btn_mohinh.Location = new System.Drawing.Point(684, 59);
            this.btn_mohinh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mohinh.Name = "btn_mohinh";
            this.btn_mohinh.Size = new System.Drawing.Size(105, 31);
            this.btn_mohinh.TabIndex = 54;
            this.btn_mohinh.Text = "Mở Hình:";
            this.btn_mohinh.UseVisualStyleBackColor = true;
            this.btn_mohinh.Click += new System.EventHandler(this.btn_mohinh_Click);
            // 
            // ptb_hinh
            // 
            this.ptb_hinh.Location = new System.Drawing.Point(823, 59);
            this.ptb_hinh.Name = "ptb_hinh";
            this.ptb_hinh.Size = new System.Drawing.Size(140, 142);
            this.ptb_hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_hinh.TabIndex = 55;
            this.ptb_hinh.TabStop = false;
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 537);
            this.Controls.Add(this.ptb_hinh);
            this.Controls.Add(this.btn_mohinh);
            this.Controls.Add(this.txb_ghichu);
            this.Controls.Add(this.txb_hinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_dongiaban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_dongianhap);
            this.Controls.Add(this.txb_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_timkiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_tensp);
            this.Controls.Add(this.txb_MaHang);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SanPham";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_tensp;
        private System.Windows.Forms.TextBox txb_MaHang;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txb_dongianhap;
        private System.Windows.Forms.TextBox txb_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_dongiaban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_hinh;
        private System.Windows.Forms.TextBox txb_ghichu;
        private System.Windows.Forms.Button btn_mohinh;
        private System.Windows.Forms.PictureBox ptb_hinh;
    }
}