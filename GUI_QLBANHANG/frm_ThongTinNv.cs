using BUS_QLBANHANG;
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
    public partial class frm_ThongTinNv : Form
    {
        string email;
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public frm_ThongTinNv(string _email)
        {
            InitializeComponent();
            email = _email;
            txb_email.Text = email;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            if(txb_oddPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_oddPass.Focus();
                return;
            } else if (txb_newPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu Mới", "thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_newPass.Focus();
                return;
            }
            else if (txb_retypePass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu Mới", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_retypePass.Focus();
                return;
            }
            else if (txb_retypePass.Text.Trim() != txb_newPass.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật khẩu và nhập lại mật khẩu giống nhau", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_retypePass.Focus();
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn cập nhật mật khẩu", "confirm",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matKhauMoi = bus_nhanvien.encryption(txb_newPass.Text);
                    string matKhauCu = bus_nhanvien.encryption(txb_oddPass.Text);

                    if(bus_nhanvien.DoiMatKhau(txb_email.Text, matKhauCu, matKhauMoi))
                    {
                        frm_main.profile = 1;
                        frm_main.section = 0;
                        SendEmail(email, txb_newPass.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("mật khẩu cũ không đúng, cập nhật mật khẩu không thành cồng");
                        txb_retypePass.Text = null;
                        txb_oddPass.Text = null;
                        txb_newPass.Text = null;
                    }
                }
                else
                {
                    txb_retypePass.Text = null;
                    txb_oddPass.Text = null;
                    txb_newPass.Text = null;
                }
            }
        }

        private void SendEmail(string email, string matKhauMoi)
        {
            Thread th = new Thread(() =>
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.UseDefaultCredentials = false;

                    NetworkCredential cred = new NetworkCredential("tungnh230802@gmail.com", "Hoangtung230802");
                    MailMessage Msg = new MailMessage();
                    Msg.From = new MailAddress("tungnh230802@gmail.com");
                    Msg.To.Add(email);
                    Msg.Subject = "Cập nhật mật khẩu thành công!";
                    Msg.Body = "chúc mừng anh, chị đã cập nhật mật khẩu thành công, mật khẩu mới của bạn là: " + matKhauMoi;
                    client.Credentials = cred;
                    client.EnableSsl = true;
                    client.Send(Msg);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            });
            th.Start();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
