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
    public partial class frm_ThongKe : Form
    {
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            LoadGridview_thongKeHang();
            LoadGridview_thongKeTonKho();
        }

        private void LoadGridview_thongKeHang()
        {
            dgv_NhapKho.AutoResizeColumns();
            dgv_NhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_NhapKho.DataSource = bus_SanPham.ThongKeHang();

            dgv_NhapKho.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_NhapKho.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_NhapKho.Columns[2].HeaderText = "Số lượng sản phẩm nhập";

            dgv_NhapKho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_NhapKho.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadGridview_thongKeTonKho()
        {
            dgv_tonKho.AutoResizeColumns();
            dgv_tonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_tonKho.DataSource = bus_SanPham.ThongKeHangTonKho();

            dgv_tonKho.Columns[0].HeaderText = "Tên Sản Phẩm";
            dgv_tonKho.Columns[1].HeaderText = "Số Lượng Tồn";

            dgv_tonKho.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
