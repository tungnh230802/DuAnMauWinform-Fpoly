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
        frm_dangnhap_qlbh dn;
        public frm_main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new frm_dangnhap_qlbh();
            if (!checkExistForm(dn.Name))
            {
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                ActiveChildForm("frm_dangnhap_qlbh");
                dn.Show();
            }
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
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "gioithieu.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch(FileNotFoundException) 
            {
                MessageBox.Show("không tìm thấy file");
            }
        }
    }
}
