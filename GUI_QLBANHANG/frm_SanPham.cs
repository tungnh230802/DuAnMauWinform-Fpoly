using BUS_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBANHANG
{
    public partial class frm_SanPham : Form
    {
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        string email = frm_main.mail;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        string saveDirectory = Application.StartupPath + "\\Images\\";
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void LoadGridView_SanPham()
        {
            dgv_sanpham.DataSource = bus_SanPham.GetSanPham();
            dgv_sanpham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_sanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_sanpham.Columns[2].HeaderText = "Số Lượng";
            dgv_sanpham.Columns[3].HeaderText = "Đơn giá Bán";
            dgv_sanpham.Columns[4].HeaderText = "Đơn giá Bán";
            dgv_sanpham.Columns[5].HeaderText = "Ghi Chú";
            dgv_sanpham.Columns[6].HeaderText = "Hình Ảnh";
            dgv_sanpham.Columns[7].Visible = false;
        }

        private void ResetValue()
        {
            txb_timkiem.Text = "Nhập tên hàng";
            txb_timkiem.BackColor = Color.LightGray;

            txb_MaHang.Text = null;
            txb_tensp.Text = null;
            txb_soluong.Text = null;
            txb_dongiaban.Text = null;
            txb_dongianhap.Text = null;
            txb_ghichu.Text = null;
            txb_hinh.Text = null;
            ptb_hinh.Image = null;


            txb_MaHang.Enabled = false;
            txb_tensp.Enabled = false;
            txb_soluong.Enabled = false;
            txb_dongiaban.Enabled = false;
            txb_dongianhap.Enabled = false;
            txb_ghichu.Enabled = false;
            txb_hinh.Enabled = false;
            btn_mohinh.Enabled = false;

            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            dgv_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadGridView_KhachHang();
            ResetValue();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txb_MaHang.Text = null;
            txb_tensp.Text = null;
            txb_soluong.Text = null;
            txb_dongiaban.Text = null;
            txb_dongianhap.Text = null;
            txb_ghichu.Text = null;
            txb_hinh.Text = null;
            ptb_hinh.Image = null;

            txb_tensp.Enabled = true;
            txb_soluong.Enabled = true;
            txb_dongiaban.Enabled = true;
            txb_dongianhap.Enabled = true;
            txb_ghichu.Enabled = true;
            btn_mohinh.Enabled = true;


            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;

            txb_tensp.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int maHang = int.Parse(txb_MaHang.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus_SanPham.DeleteSanPham(maHang))
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
            int IntSoLuong;
            bool isInt = int.TryParse(txb_soluong.Text.Trim(), out IntSoLuong);
            int FloatNhap;
            bool IsFloatNhap = int.TryParse(txb_dongianhap.Text.Trim(), out FloatNhap);
            int FloatBan;
            bool IsFloatBan = int.TryParse(txb_dongiaban.Text.Trim(), out FloatBan);
            if (string.IsNullOrEmpty(txb_tensp.Text))
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_tensp.Focus();
            }
            else if (string.IsNullOrEmpty(txb_soluong.Text))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_soluong.Focus();
            }
            else if (string.IsNullOrEmpty(txb_ghichu.Text))
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_ghichu.Focus();
            }
            else if (string.IsNullOrEmpty(txb_dongiaban.Text))
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongiaban.Focus();
            }
            else if (string.IsNullOrEmpty(txb_dongianhap.Text))
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongianhap.Focus();
            }
            else if (!isInt || int.Parse(txb_soluong.Text) < 0)
            {
                MessageBox.Show("Số lượng phải là số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_soluong.Focus();
            }
            else if (!IsFloatBan || int.Parse(txb_dongiaban.Text) < 0)
            {
                MessageBox.Show("đơn giá bán số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongiaban.Focus();
            }
            else if (!IsFloatNhap || int.Parse(txb_dongianhap.Text) < 0)
            {
                MessageBox.Show("đơn giá nhập số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongianhap.Focus();
            }
            else if (string.IsNullOrEmpty(txb_hinh.Text.Trim()))
            {
                MessageBox.Show("Bạn phải upload hình", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_SanPham sp = new DTO_SanPham(int.Parse(txb_MaHang.Text),txb_tensp.Text, IntSoLuong, FloatBan, FloatNhap,
                    txb_hinh.Text, txb_ghichu.Text);
                if (bus_SanPham.UpdateSanPham(sp))
                {
                    MessageBox.Show("cập nhập sản phẩm thành công");
                    if(!string.IsNullOrEmpty(fileAddress) && txb_hinh.Text != checkUrlImage)
                    {     
                            File.Copy(fileAddress, fileSavePath, true);
                    }    
                    ResetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("cập nhập sản phẩm không thành công");
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int IntSoLuong;
            bool isInt = int.TryParse(txb_soluong.Text.Trim(), out IntSoLuong);
            int FloatNhap;
            bool IsFloatNhap = int.TryParse(txb_dongianhap.Text.Trim(), out FloatNhap);
            int FloatBan;
            bool IsFloatBan = int.TryParse(txb_dongiaban.Text.Trim(), out FloatBan);
            if (string.IsNullOrEmpty(txb_tensp.Text))
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_tensp.Focus();
            }
            else if (string.IsNullOrEmpty(txb_soluong.Text))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_soluong.Focus();
            }
            else if (string.IsNullOrEmpty(txb_ghichu.Text))
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_ghichu.Focus();
            }
            else if (string.IsNullOrEmpty(txb_dongiaban.Text))
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongiaban.Focus();
            }
            else if (string.IsNullOrEmpty(txb_dongianhap.Text))
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongianhap.Focus();
            }
            else if (!isInt || int.Parse(txb_soluong.Text) < 0)
            {
                MessageBox.Show("Số lượng phải là số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_soluong.Focus();
            }
            else if (!IsFloatBan || int.Parse(txb_dongiaban.Text) < 0)
            {
                MessageBox.Show("đơn giá bán số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongiaban.Focus();
            }
            else if (!IsFloatNhap || int.Parse(txb_dongianhap.Text) < 0)
            {
                MessageBox.Show("đơn giá nhập số và lớn hơn 0", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_dongianhap.Focus();
            }
            else if (string.IsNullOrEmpty(txb_hinh.Text.Trim()))
            {
                MessageBox.Show("Bạn phải upload hình", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_SanPham sp = new DTO_SanPham(txb_tensp.Text, IntSoLuong, FloatBan, FloatNhap,
                    fileName, txb_ghichu.Text,email);
                if (bus_SanPham.InsertSanPham(sp))
                {
                    if(txb_hinh.Text != checkUrlImage)
                        File.Copy(fileAddress, fileSavePath, true);

                    MessageBox.Show("Thêm sản phẩm thành công");
                    ResetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_KhachHang();
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_KhachHang();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tensp = txb_timkiem.Text;
            DataTable dtSP = bus_SanPham.SearchSanPham(tensp);
            if (dtSP.Rows.Count > 0)
            {
                dgv_sanpham.DataSource = dtSP;
                dgv_sanpham.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgv_sanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
                dgv_sanpham.Columns[2].HeaderText = "Số Lượng";
                dgv_sanpham.Columns[3].HeaderText = "Đơn giá Bán";
                dgv_sanpham.Columns[4].HeaderText = "Đơn giá Bán";
                dgv_sanpham.Columns[5].HeaderText = "Ghi Chú";
                dgv_sanpham.Columns[6].HeaderText = "Hình Ảnh";
                dgv_sanpham.Columns[7].Visible = false;
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

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_sanpham.Rows.Count > 1)
            {
                txb_tensp.Enabled = true;
                txb_soluong.Enabled = true;
                txb_dongiaban.Enabled = true;
                txb_dongianhap.Enabled = true;
                txb_ghichu.Enabled = true;
                btn_mohinh.Enabled = true;

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;

                txb_tensp.Focus();

                txb_MaHang.Text = dgv_sanpham.CurrentRow.Cells["MAHANG"].Value?.ToString();
                txb_tensp.Text = dgv_sanpham.CurrentRow.Cells["TENHANG"].Value?.ToString();
                txb_soluong.Text = dgv_sanpham.CurrentRow.Cells["SOLUONG"].Value?.ToString();
                txb_dongiaban.Text = dgv_sanpham.CurrentRow.Cells["DONGIABAN"].Value?.ToString();
                txb_dongianhap.Text = dgv_sanpham.CurrentRow.Cells["DONGIANHAP"].Value?.ToString();
                string hinh = txb_hinh.Text = dgv_sanpham.CurrentRow.Cells["HINHANH"].Value?.ToString();
                txb_ghichu.Text = dgv_sanpham.CurrentRow.Cells["GHICHU"].Value?.ToString();

                checkUrlImage = txb_hinh.Text;
                try
                {
                    ptb_hinh.Image = Image.FromFile(saveDirectory + hinh);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Bạn không có dữ liệu nào", "thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_mohinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                ptb_hinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);

                fileSavePath = saveDirectory + fileName;
                txb_hinh.Text = fileName;
            }
        }
    }
}
