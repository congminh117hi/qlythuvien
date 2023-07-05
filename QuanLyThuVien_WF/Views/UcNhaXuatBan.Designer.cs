namespace QuanLyThuVien_WF.Views
{
    partial class UcNhaXuatBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNhaXuatBan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNXB = new DevExpress.XtraEditors.TextEdit();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaNXB = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.TxtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dvgNXB = new DevExpress.XtraGrid.GridControl();
            this.dgnxb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgnxb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnHuyBo);
            this.groupControl1.Controls.Add(this.BtnLuu);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnCapNhat);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Controls.Add(this.TxtNXB);
            this.groupControl1.Controls.Add(this.TxtEmail);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtMaNXB);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TxtDiaChi);
            this.groupControl1.Controls.Add(this.TxtDienThoai);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1282, 210);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin cần điền";
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBo.Image")));
            this.BtnHuyBo.Location = new System.Drawing.Point(798, 141);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(113, 35);
            this.BtnHuyBo.TabIndex = 2;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(667, 141);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(113, 35);
            this.BtnLuu.TabIndex = 2;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(536, 141);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(113, 35);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("BtnCapNhat.Image")));
            this.BtnCapNhat.Location = new System.Drawing.Point(405, 141);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(113, 35);
            this.BtnCapNhat.TabIndex = 2;
            this.BtnCapNhat.Text = "Cập Nhật";
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.Image")));
            this.BtnThem.Location = new System.Drawing.Point(274, 141);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(113, 35);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm Mới";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TxtNXB
            // 
            this.TxtNXB.Location = new System.Drawing.Point(375, 69);
            this.TxtNXB.Name = "TxtNXB";
            this.TxtNXB.Size = new System.Drawing.Size(190, 20);
            this.TxtNXB.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(667, 68);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(190, 20);
            this.TxtEmail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Nhà Xuất Bản";
            // 
            // TxtMaNXB
            // 
            this.TxtMaNXB.Location = new System.Drawing.Point(375, 36);
            this.TxtMaNXB.Name = "TxtMaNXB";
            this.TxtMaNXB.Size = new System.Drawing.Size(190, 20);
            this.TxtMaNXB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Xuất Bản";
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Location = new System.Drawing.Point(375, 102);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(190, 20);
            this.TxtDiaChi.TabIndex = 1;
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(667, 36);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDienThoai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDienThoai.Size = new System.Drawing.Size(190, 20);
            this.TxtDienThoai.TabIndex = 1;
            this.TxtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDienThoai_KeyPress);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dvgNXB);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 210);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 305);
            this.groupControl2.TabIndex = 4;
            // 
            // dvgNXB
            // 
            this.dvgNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgNXB.Location = new System.Drawing.Point(2, 21);
            this.dvgNXB.MainView = this.dgnxb;
            this.dvgNXB.Name = "dvgNXB";
            this.dvgNXB.Size = new System.Drawing.Size(1278, 282);
            this.dvgNXB.TabIndex = 0;
            this.dvgNXB.UseEmbeddedNavigator = true;
            this.dvgNXB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgnxb});
            // 
            // dgnxb
            // 
            this.dgnxb.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChi,
            this.SDT,
            this.Email});
            this.dgnxb.GridControl = this.dvgNXB;
            this.dgnxb.Name = "dgnxb";
            this.dgnxb.OptionsBehavior.Editable = false;
            this.dgnxb.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgnxb.OptionsFind.AlwaysVisible = true;
            this.dgnxb.OptionsFind.FindDelay = 500;
            this.dgnxb.OptionsFind.FindNullPrompt = "Nhập nội dung cần tìm...";
            this.dgnxb.OptionsFind.ShowFindButton = false;
            this.dgnxb.OptionsSelection.MultiSelect = true;
            this.dgnxb.OptionsView.ShowGroupPanel = false;
            this.dgnxb.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgnxb_FocusedRowChanged);
            // 
            // MaNXB
            // 
            this.MaNXB.Caption = "Mã Nhà Xuất Bản";
            this.MaNXB.FieldName = "MaNXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Visible = true;
            this.MaNXB.VisibleIndex = 0;
            // 
            // TenNXB
            // 
            this.TenNXB.Caption = "Tên Nhà Xuất Bản";
            this.TenNXB.FieldName = "TenNXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Visible = true;
            this.TenNXB.VisibleIndex = 1;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            // 
            // SDT
            // 
            this.SDT.Caption = "Điện thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Thư Điện Tử";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // UcNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcNhaXuatBan";
            this.Size = new System.Drawing.Size(1282, 515);
            this.Load += new System.EventHandler(this.UcNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgnxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBo;
        private DevExpress.XtraEditors.SimpleButton BtnLuu;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.TextEdit TxtNXB;
        private DevExpress.XtraEditors.TextEdit TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtMaNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dvgNXB;
        private DevExpress.XtraGrid.Views.Grid.GridView dgnxb;
        private DevExpress.XtraEditors.TextEdit TxtDiaChi;
        private DevExpress.XtraEditors.TextEdit TxtDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn TenNXB;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
    }
}
