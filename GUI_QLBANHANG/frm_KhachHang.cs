using BUS_QLBANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBANHANG
{
    public partial class frm_KhachHang : Form
    {
        BUS_KhachHang bus_KhachHang = new BUS_KhachHang();
        string email = frm_main.mail;
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void LoadGridView_KhachHang()
        {
            dgv_nhanvien.DataSource = bus_KhachHang.GetKhachHang();
            dgv_nhanvien.Columns[0].HeaderText = "Điện Thoại";
            dgv_nhanvien.Columns[1].HeaderText = "Họ và Tên";
            dgv_nhanvien.Columns[2].HeaderText = "Địa Chỉ";
            dgv_nhanvien.Columns[3].HeaderText = "Giới Tính";
            dgv_nhanvien.Columns[4].Visible = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int dienThoai;
            string txb_dienthoai = txb_sdt.Text.Trim().ToString();
            bool isInt = int.TryParse(txb_dienthoai, out dienThoai);
            string phai = "Nam";
            if (rdo_nu.Checked)
                phai = "Nữ";
            if (!isInt)
            {
                MessageBox.Show("Bạn phải nhập số nguyên",)
            }
        }
    }
}
