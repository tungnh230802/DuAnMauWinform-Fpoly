
namespace GUI_QLBANHANG
{
    partial class frm_ThongKe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_spNhapKho = new System.Windows.Forms.TabPage();
            this.dgv_NhapKho = new System.Windows.Forms.DataGridView();
            this.tp_TonKho = new System.Windows.Forms.TabPage();
            this.dgv_tonKho = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_spNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapKho)).BeginInit();
            this.tp_TonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_spNhapKho);
            this.tabControl1.Controls.Add(this.tp_TonKho);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_spNhapKho
            // 
            this.tp_spNhapKho.Controls.Add(this.dgv_NhapKho);
            this.tp_spNhapKho.Location = new System.Drawing.Point(4, 25);
            this.tp_spNhapKho.Name = "tp_spNhapKho";
            this.tp_spNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tp_spNhapKho.Size = new System.Drawing.Size(974, 442);
            this.tp_spNhapKho.TabIndex = 0;
            this.tp_spNhapKho.Text = "Sản Phẩm Nhập Kho";
            this.tp_spNhapKho.UseVisualStyleBackColor = true;
            // 
            // dgv_NhapKho
            // 
            this.dgv_NhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhapKho.Location = new System.Drawing.Point(3, 3);
            this.dgv_NhapKho.Name = "dgv_NhapKho";
            this.dgv_NhapKho.Size = new System.Drawing.Size(968, 433);
            this.dgv_NhapKho.TabIndex = 1;
            // 
            // tp_TonKho
            // 
            this.tp_TonKho.Controls.Add(this.dgv_tonKho);
            this.tp_TonKho.Location = new System.Drawing.Point(4, 25);
            this.tp_TonKho.Name = "tp_TonKho";
            this.tp_TonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tp_TonKho.Size = new System.Drawing.Size(974, 442);
            this.tp_TonKho.TabIndex = 1;
            this.tp_TonKho.Text = "Tồn Kho";
            this.tp_TonKho.UseVisualStyleBackColor = true;
            // 
            // dgv_tonKho
            // 
            this.dgv_tonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_tonKho.Location = new System.Drawing.Point(3, 3);
            this.dgv_tonKho.Name = "dgv_tonKho";
            this.dgv_tonKho.Size = new System.Drawing.Size(968, 436);
            this.dgv_tonKho.TabIndex = 0;
            // 
            // btn_dong
            // 
            this.btn_dong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dong.ForeColor = System.Drawing.Color.Black;
            this.btn_dong.Location = new System.Drawing.Point(862, 478);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 46);
            this.btn_dong.TabIndex = 22;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 537);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_spNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhapKho)).EndInit();
            this.tp_TonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_spNhapKho;
        private System.Windows.Forms.DataGridView dgv_NhapKho;
        private System.Windows.Forms.TabPage tp_TonKho;
        private System.Windows.Forms.DataGridView dgv_tonKho;
        private System.Windows.Forms.Button btn_dong;
    }
}