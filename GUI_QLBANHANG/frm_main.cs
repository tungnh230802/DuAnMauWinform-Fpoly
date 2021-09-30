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
    public partial class frm_main : Form
    {
        public static int section = 0;
        public static int profile = 0;
        public static string mail;

        frm_dangnhap dn;
        public frm_main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new frm_dangnhap();
            if (!checkExistForm(dn.Name))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(frm_dangnhap_qlbh_FormClosed);
            }
            else
            {
                ActiveChildForm(dn.Name);
            }
        }

        private void frm_dangnhap_qlbh_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main_Load(sender, e);
            this.Refresh();
        }

        private void ResetValue()
        {
            if(section == 1)
            {
                lbl_welcome.Text = "Chào " + mail;
                nhânViênToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                danhMụcToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                thôngTinHồSơToolStripMenuItem.Visible = true;
                if (!dn.IsAdmin)
                {
                    VaiTroNV();
                }
            }
            else
            {
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                thôngTinHồSơToolStripMenuItem.Visible = false;
            }
        }

        private void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }

        public bool checkExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public void ActiveChildForm(string name)
        {
            foreach(var frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if(profile == 1)
            {
                lbl_welcome.Text = null;
                profile = 0;
            }
            ResetValue();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Docs\\gioithieu.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch(FileNotFoundException) 
            {
                MessageBox.Show("không tìm thấy file");
            }
        }

        private void thôngTinHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinNv frm_ttnv = new frm_ThongTinNv(frm_main.mail);

            if (!checkExistForm(frm_ttnv.Name))
            {
                frm_ttnv.MdiParent = this;
                frm_ttnv.FormClosed += new FormClosedEventHandler(frm_ttnv_FormClosed);
                frm_ttnv.Show();
            }else
            {
                ActiveChildForm(frm_ttnv.Name);
            }
        }

        private void frm_ttnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main_Load(sender, e);
            this.Refresh();
        }
        private void frm_nv_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main_Load(sender, e);
            this.Refresh();
        }

        private void frm_kh_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main_Load(sender, e);
            this.Refresh();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm_nv = new frm_NhanVien();

            if (!checkExistForm(frm_nv.Name))
            {
                frm_nv.MdiParent = this;
                frm_nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm_nv.Dock = DockStyle.Fill;
                frm_nv.FormClosed += new FormClosedEventHandler(frm_nv_FormClosed);
                frm_nv.Show();
            }
            else
            {
                ActiveChildForm(frm_nv.Name);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = 1;
            section = 0;
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frm_main_Load(sender, e);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm_kh = new frm_KhachHang();

            if (!checkExistForm(frm_kh.Name))
            {
                frm_kh.MdiParent = this;
                frm_kh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm_kh.Dock = DockStyle.Fill;
                frm_kh.FormClosed += new FormClosedEventHandler(frm_kh_FormClosed);
                frm_kh.Show();
            }
            else
            {
                ActiveChildForm(frm_kh.Name);
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SanPham frm_sp = new frm_SanPham();

            if (!checkExistForm(frm_sp.Name))
            {
                frm_sp.MdiParent = this;
                frm_sp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm_sp.Dock = DockStyle.Fill;
                frm_sp.FormClosed += new FormClosedEventHandler(frm_kh_FormClosed);
                frm_sp.Show();
            }
            else
            {
                ActiveChildForm(frm_sp.Name);
            }
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_ThongKe frm_tk = new frm_ThongKe();

            if (!checkExistForm(frm_tk.Name))
            {
                frm_tk.MdiParent = this;
                frm_tk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm_tk.Dock = DockStyle.Fill;
                frm_tk.FormClosed += new FormClosedEventHandler(frm_kh_FormClosed);
                frm_tk.Show();
            }
            else
            {
                ActiveChildForm(frm_tk.Name);
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
