using BUS_QLBANHANG;
using DTO_QLBANHANG;
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
            dgv_khachhang.DataSource = bus_KhachHang.GetKhachHang();
            dgv_khachhang.Columns[0].HeaderText = "Điện Thoại";
            dgv_khachhang.Columns[1].HeaderText = "Họ và Tên";
            dgv_khachhang.Columns[2].HeaderText = "Địa Chỉ";
            dgv_khachhang.Columns[3].HeaderText = "Giới Tính";
            dgv_khachhang.Columns[4].Visible = false;
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            int dienThoai;
            string txb_dienthoai = txb_sdt.Text.Trim().ToString();
            bool isInt = int.TryParse(txb_dienthoai, out dienThoai);
            string phai = "Nam";

            if (rdo_nu.Checked)
                phai = "Nữ";

            if (string.IsNullOrEmpty(txb_sdt.Text))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_sdt.Focus();
            }
            else if (!isInt)
            {
                MessageBox.Show("Bạn phải nhập số nguyên", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_sdt.Focus();
                
                if(dienThoai < 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại > 0", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_sdt.Focus();
                }
            } 
            else if (string.IsNullOrEmpty(txb_diachi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_diachi.Focus();
            }
            else if (rdo_nu.Checked == false && rdo_nam.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txb_sdt.Text, txb_tenkh.Text,
                    txb_diachi.Text, phai, email);

                if (bus_KhachHang.InsertKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void ResetValue()
        {
            txb_timkiem.Text = "Nhập số điện thoại";
            txb_timkiem.BackColor = Color.LightGray;

            txb_sdt.Text = null;
            txb_tenkh.Text = null;
            txb_diachi.Text = null;

            txb_sdt.Enabled = false;
            txb_tenkh.Enabled = false;
            txb_diachi.Enabled = false;

            rdo_nam.Enabled = false;
            rdo_nu.Enabled = false;

            rdo_nam.Checked = false;
            rdo_nu.Checked = false;

            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txb_sdt.Text = null;
            txb_tenkh.Text = null;
            txb_diachi.Text = null;

            txb_sdt.Enabled = true;
            txb_tenkh.Enabled = true;
            txb_diachi.Enabled = true;

            rdo_nam.Enabled = true;
            rdo_nu.Enabled = true;

            rdo_nam.Checked = false;
            rdo_nu.Checked = false;

            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;

            txb_sdt.Focus();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            dgv_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadGridView_KhachHang();
            ResetValue();
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_khachhang.Rows.Count > 1)
            {
                txb_sdt.Enabled = true;
                txb_tenkh.Enabled = true;
                txb_diachi.Enabled = true;

                rdo_nam.Enabled = true;
                rdo_nu.Enabled = true;

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;

                txb_sdt.Text = dgv_khachhang.CurrentRow.Cells["dienthoai"].Value?.ToString();
                txb_tenkh.Text = dgv_khachhang.CurrentRow.Cells["tenkhach"].Value?.ToString();
                txb_diachi.Text = dgv_khachhang.CurrentRow.Cells["diachi"].Value?.ToString();
                string phai = dgv_khachhang.CurrentRow.Cells["phai"].Value?.ToString();
                if (phai == "Nam")
                    rdo_nam.Checked = true;
                else if (phai == "Nữ")
                    rdo_nu.Checked = true;
                else
                {
                    rdo_nam.Checked = false;
                    rdo_nu.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn không có dữ liệu nào", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_KhachHang();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_KhachHang();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sdt = txb_sdt.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus_KhachHang.DeleteKhachHang(sdt))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValue();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int dienThoai;
            string txb_dienthoai = txb_sdt.Text.Trim().ToString();
            bool isInt = int.TryParse(txb_dienthoai, out dienThoai);
            string phai = "Nam";

            if (rdo_nu.Checked)
                phai = "Nữ";

            if (string.IsNullOrEmpty(txb_sdt.Text))
            {
                MessageBox.Show("Bạn phải số điện thoại", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_sdt.Focus();
            }
            else if (!isInt)
            {
                MessageBox.Show("Bạn phải nhập số nguyên", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_sdt.Focus();

                if (dienThoai < 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại > 0", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_sdt.Focus();
                }
            }
            else if (string.IsNullOrEmpty(txb_diachi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_diachi.Focus();
            }
            else if (rdo_nu.Checked == false && rdo_nam.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txb_sdt.Text, txb_tenkh.Text,
                    txb_diachi.Text, phai);

                if (bus_KhachHang.UpdateKhachHang(kh))
                {
                    MessageBox.Show("cập nhật thành công");
                    ResetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("cập nhật không thành công");
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sdt = txb_timkiem.Text;
            DataTable dtKH = bus_KhachHang.SearchKhachHang(sdt);
            if (dtKH.Rows.Count > 0)
            {
                dgv_khachhang.DataSource = dtKH;
                dgv_khachhang.Columns[0].HeaderText = "Điện Thoại";
                dgv_khachhang.Columns[1].HeaderText = "Họ và Tên";
                dgv_khachhang.Columns[2].HeaderText = "Địa Chỉ";
                dgv_khachhang.Columns[3].HeaderText = "Giới Tính";
                dgv_khachhang.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txb_timkiem.Text = "Nhập số điện thoại";
            ResetValue();
        }

        private void txb_timkiem_Click(object sender, EventArgs e)
        {
            txb_timkiem.Text = null;
            txb_timkiem.BackColor = Color.White;
        }
    }
}
