using BUS_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBANHANG
{
    public partial class frm_NhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadGridView_Nhanvien();
            ResetValue();
        }

        private void LoadGridView_Nhanvien()
        {
            dgv_nhanvien.DataSource = bus_NhanVien.getNhanVien();
            dgv_nhanvien.Columns[0].HeaderText = "Email";
            dgv_nhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_nhanvien.Columns[2].HeaderText = "Địa Chỉ";
            dgv_nhanvien.Columns[3].HeaderText = "Vai Trò";
            dgv_nhanvien.Columns[4].HeaderText = "Tình Trạng";
        }

        private void ResetValue()
        {
            txb_timkiem.Text = "Nhập tên nhân viên";
            txb_timkiem.BackColor = Color.LightGray;

            txb_email.Text = null;
            txb_tennv.Text = null;
            txb_diachi.Text = null;

            txb_email.Enabled = false;
            txb_tennv.Enabled = false;
            txb_diachi.Enabled = false;

            rdo_hd.Enabled = false;
            rdo_ngunghd.Enabled = false;
            rdo_nv.Enabled = false;
            rdo_quantri.Enabled = false;

            rdo_hd.Checked = false;
            rdo_ngunghd.Checked = false;
            rdo_nv.Checked = false;
            rdo_quantri.Checked = false;

            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txb_email.Text = null;
            txb_tennv.Text = null;
            txb_diachi.Text = null;

            txb_email.Enabled = true;
            txb_tennv.Enabled = true;
            txb_diachi.Enabled = true;

            rdo_hd.Enabled = true;
            rdo_ngunghd.Enabled = true;
            rdo_nv.Enabled = true;
            rdo_quantri.Enabled = true;

            rdo_hd.Checked = false;
            rdo_ngunghd.Checked = false;
            rdo_nv.Checked = false;
            rdo_quantri.Checked = false;

            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;

            txb_email.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            if(txb_email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_email.Focus();
            }
            else if (!IsValidEmail(txb_email.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng email", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_email.Focus();
            }
            else if(txb_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_tennv.Focus();
            }
            else if (txb_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_diachi.Focus();
            }
            else if(rdo_nv.Checked == false && rdo_quantri.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập vai trò", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdo_hd.Checked == false && rdo_ngunghd.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập Tình Trạng", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int role = 0;
                if (rdo_quantri.Checked)
                {
                    role = 1;
                }
                int TinhTrang = 0;
                if (rdo_hd.Checked)
                {
                    TinhTrang = 1;
                }
                DTO_NhanVien nv = new DTO_NhanVien(txb_tennv.Text, txb_email.Text, txb_diachi.Text,
                    role, TinhTrang);
                if(bus_NhanVien.InsertNhanVien(nv))
                {
                    SendEmail(txb_email.Text);
                    MessageBox.Show("Thêm thành công");
                    ResetValue();
                    LoadGridView_Nhanvien();
                }else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void SendEmail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("tungnh230802@gmail.com", "Hoangtung230802");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("tungnh230802@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "Tạo tài khoản nhân viên thành công";
                Msg.Body = "Mật khẩu mặc định của bạn là: 1234";
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_nhanvien.Rows.Count > 1)
            {
                txb_tennv.Enabled = true;
                txb_diachi.Enabled = true;

                rdo_hd.Enabled = true;
                rdo_ngunghd.Enabled = true;
                rdo_nv.Enabled = true;
                rdo_quantri.Enabled = true;

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;

                txb_email.Text = dgv_nhanvien.CurrentRow.Cells["email"].Value?.ToString();
                txb_tennv.Text = dgv_nhanvien.CurrentRow.Cells["tennv"].Value?.ToString();
                txb_diachi.Text = dgv_nhanvien.CurrentRow.Cells["diachi"].Value?.ToString();
                if (!string.IsNullOrEmpty(dgv_nhanvien.CurrentRow.Cells["email"].Value?.ToString()))
                {
                    if (int.Parse(dgv_nhanvien.CurrentRow.Cells["vaitro"].Value?.ToString()) == 1)
                        rdo_quantri.Checked = true;
                    else
                        rdo_nv.Checked = true;
                    if (int.Parse(dgv_nhanvien.CurrentRow.Cells["tinhtrang"].Value?.ToString()) == 1)
                        rdo_hd.Checked = true;
                    else
                        rdo_ngunghd.Checked = true;
                }
                else
                {
                    rdo_hd.Checked = false;
                    rdo_ngunghd.Checked = false;
                    rdo_nv.Checked = false;
                    rdo_quantri.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn không có dữ liệu nào", "thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(txb_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_tennv.Focus();
            }
            else if (txb_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_diachi.Focus();
            }
            else if(rdo_nv.Checked == false && rdo_quantri.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập vai trò", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdo_hd.Checked == false && rdo_ngunghd.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập Tình Trạng", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int role = 0;
                if (rdo_quantri.Checked)
                {
                    role = 1;
                }
                int TinhTrang = 0;
                if (rdo_hd.Checked)
                {
                    TinhTrang = 1;
                }

                DTO_NhanVien nv = new DTO_NhanVien(txb_tennv.Text, txb_email.Text, txb_diachi.Text,
                    role, TinhTrang);
                if (bus_NhanVien.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValue();
                    LoadGridView_Nhanvien();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string email = txb_email.Text;
            if(MessageBox.Show("Bạn có chắc muốn xóa dữ liệu","Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus_NhanVien.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValue();
                    LoadGridView_Nhanvien();
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

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_Nhanvien();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenNv = txb_timkiem.Text;
            DataTable dtNv = bus_NhanVien.SearchNhanVien(tenNv);
            if(dtNv.Rows.Count > 0)
            {
                dgv_nhanvien.DataSource = dtNv;
                dgv_nhanvien.Columns[0].HeaderText = "Email";
                dgv_nhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
                dgv_nhanvien.Columns[2].HeaderText = "Địa Chỉ";
                dgv_nhanvien.Columns[3].HeaderText = "Vai Trò";
                dgv_nhanvien.Columns[4].HeaderText = "Tình Trạng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txb_timkiem.Text = "Nhập tên nhân viên";
            ResetValue();
        }

        private void txb_timkiem_Click(object sender, EventArgs e)
        {
            txb_timkiem.Text = null;
            txb_timkiem.BackColor = Color.White;
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_Nhanvien();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
