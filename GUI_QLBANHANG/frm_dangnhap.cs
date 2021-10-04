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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBANHANG
{
    public partial class frm_dangnhap : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public bool IsAdmin { get; set; }
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = txb_email.Text;
            nv.MatKhau = busNhanVien.encryption(txb_matkhau.Text);
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                frm_main.mail = nv.Email;
                MessageBox.Show("đăng nhập thành công");
                IsAdmin = busNhanVien.VaiTroNhanVien(nv.Email);
                frm_main.section = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại");
                txb_email.Text = null;
                txb_matkhau.Text = null;
                txb_email.Focus();
            }
        }

        private void lbl_quenmk_Click(object sender, EventArgs e)
        {
            if(lbl_quenmk.Text!=null)
            {
                if(busNhanVien.NhanVienQuenMk(txb_email.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RanDomString(4, true));
                    builder.Append(RanDomNumber(1000, 9000));
                    string matKhauMoi = busNhanVien.encryption(builder.ToString());
                    busNhanVien.TaoMoiMatKhau(txb_email.Text, matKhauMoi);
                    SendEmail(txb_email.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("email không tồn tại vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email để phục hồi mật khẩu!");
                txb_email.Focus();
            }
        }

        public void SendEmail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;

                NetworkCredential cred = new NetworkCredential("tungnh230802@gmail.com", "Hoangtung230802");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("tungnh230802@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                Msg.Body = "Chào anh, chị mật khẩu mới là " + matKhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("đã gửi mật khẩu đến mail của bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string RanDomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for(int i = 0; i<size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }if(lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int RanDomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_dangnhap_qlbh_Load(object sender, EventArgs e)
        {
  
        }

        public void frm_dangnhap_qlbh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
