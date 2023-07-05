namespace QuanLyThuVien_WF.Views
{
    partial class UcNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNguoiDung));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.cbbMaTT = new System.Windows.Forms.ComboBox();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenTT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaNguoiDung = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.dvgnd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgnd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.dvgNguoiDung);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 515);
            this.groupControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbQuyen);
            this.groupControl1.Controls.Add(this.cbbMaTT);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Controls.Add(this.BtnHuyBo);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.BtnLuu);
            this.groupControl1.Controls.Add(this.lblTenTT);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtNhapLai);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.TxtMaNguoiDung);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1278, 196);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Cần Điền";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbQuyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(551, 59);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbbQuyen.TabIndex = 49;
            // 
            // cbbMaTT
            // 
            this.cbbMaTT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaTT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaTT.FormattingEnabled = true;
            this.cbbMaTT.Location = new System.Drawing.Point(551, 32);
            this.cbbMaTT.Name = "cbbMaTT";
            this.cbbMaTT.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTT.TabIndex = 49;
            this.cbbMaTT.SelectedIndexChanged += new System.EventHandler(this.cbbMaTT_SelectedIndexChanged);
            // 
            // BtnXoa
            // 
            this.BtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.ImageOptions.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(277, 121);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(113, 35);
            this.BtnXoa.TabIndex = 46;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.ImageOptions.Image")));
            this.BtnThem.Location = new System.Drawing.Point(136, 121);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(113, 35);
            this.BtnThem.TabIndex = 44;
            this.BtnThem.Text = "Thêm Mới";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBo.ImageOptions.Image")));
            this.BtnHuyBo.Location = new System.Drawing.Point(559, 121);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(113, 35);
            this.BtnHuyBo.TabIndex = 48;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quyền";
            // 
            // BtnLuu
            // 
            this.BtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.ImageOptions.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(418, 121);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(113, 35);
            this.BtnLuu.TabIndex = 47;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // lblTenTT
            // 
            this.lblTenTT.AutoSize = true;
            this.lblTenTT.Location = new System.Drawing.Point(708, 36);
            this.lblTenTT.Name = "lblTenTT";
            this.lblTenTT.Size = new System.Drawing.Size(11, 13);
            this.lblTenTT.TabIndex = 27;
            this.lblTenTT.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Thủ Thư";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.EditValue = "";
            this.txtNhapLai.Location = new System.Drawing.Point(215, 85);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Properties.NullText = "Mã TS";
            this.txtNhapLai.Properties.UseSystemPasswordChar = true;
            this.txtNhapLai.Size = new System.Drawing.Size(190, 20);
            this.txtNhapLai.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhập lại MK";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(215, 59);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.NullText = "Mã TS";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(190, 20);
            this.txtMatKhau.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mật khẩu";
            // 
            // TxtMaNguoiDung
            // 
            this.TxtMaNguoiDung.EditValue = "";
            this.TxtMaNguoiDung.Location = new System.Drawing.Point(215, 33);
            this.TxtMaNguoiDung.Name = "TxtMaNguoiDung";
            this.TxtMaNguoiDung.Properties.NullText = "Mã TS";
            this.TxtMaNguoiDung.Size = new System.Drawing.Size(190, 20);
            this.TxtMaNguoiDung.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Người Dùng";
            // 
            // dvgNguoiDung
            // 
            this.dvgNguoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgNguoiDung.Location = new System.Drawing.Point(2, 223);
            this.dvgNguoiDung.MainView = this.dvgnd;
            this.dvgNguoiDung.Name = "dvgNguoiDung";
            this.dvgNguoiDung.Size = new System.Drawing.Size(1278, 290);
            this.dvgNguoiDung.TabIndex = 0;
            this.dvgNguoiDung.UseEmbeddedNavigator = true;
            this.dvgNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvgnd});
            this.dvgNguoiDung.Load += new System.EventHandler(this.dvgNguoiDung_Load);
            // 
            // dvgnd
            // 
            this.dvgnd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaND,
            this.MaTT,
            this.MatKhau});
            this.dvgnd.GridControl = this.dvgNguoiDung;
            this.dvgnd.Name = "dvgnd";
            this.dvgnd.OptionsFind.AlwaysVisible = true;
            this.dvgnd.OptionsFind.FindDelay = 500;
            this.dvgnd.OptionsFind.FindNullPrompt = "Nhập nội dung cần tìm...";
            this.dvgnd.OptionsFind.ShowFindButton = false;
            this.dvgnd.OptionsSelection.MultiSelect = true;
            this.dvgnd.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvgts_FocusedRowChanged);
            // 
            // MaND
            // 
            this.MaND.Caption = "Mã Người Dùng";
            this.MaND.FieldName = "MaNguoiDung";
            this.MaND.Name = "MaND";
            this.MaND.Visible = true;
            this.MaND.VisibleIndex = 0;
            // 
            // MaTT
            // 
            this.MaTT.Caption = "Mã Thủ Thư";
            this.MaTT.FieldName = "MaTT";
            this.MaTT.Name = "MaTT";
            this.MaTT.Visible = true;
            this.MaTT.VisibleIndex = 1;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật Khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            // 
            // UcNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "UcNguoiDung";
            this.Size = new System.Drawing.Size(1282, 515);
            this.Load += new System.EventHandler(this.UcNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dvgNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView dvgnd;
        private DevExpress.XtraGrid.Columns.GridColumn MaND;
        private DevExpress.XtraGrid.Columns.GridColumn MaTT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBo;
        private DevExpress.XtraEditors.SimpleButton BtnLuu;
        private DevExpress.XtraEditors.TextEdit TxtMaNguoiDung;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaTT;
        private DevExpress.XtraEditors.TextEdit txtNhapLai;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTenTT;
    }
}
