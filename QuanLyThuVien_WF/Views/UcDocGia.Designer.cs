namespace QuanLyThuVien_WF.Views
{
    partial class UcDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDocGia));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.TxtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaDocGia = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.CbbGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dvgDocGia = new DevExpress.XtraGrid.GridControl();
            this.dvgdg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocGiaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbDocGiaID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbDocGiaID);
            this.groupControl1.Controls.Add(this.BtnHuyBo);
            this.groupControl1.Controls.Add(this.BtnLuu);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnCapNhat);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Controls.Add(this.TxtDienThoai);
            this.groupControl1.Controls.Add(this.TxtHoTen);
            this.groupControl1.Controls.Add(this.lblNgheNghiep);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.TxtDiaChi);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtMaDocGia);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.dtpNgaySinh);
            this.groupControl1.Controls.Add(this.CbbGioiTinh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1282, 203);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin cần điền";
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBo.ImageOptions.Image")));
            this.BtnHuyBo.Location = new System.Drawing.Point(798, 141);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(113, 35);
            this.BtnHuyBo.TabIndex = 2;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.ImageOptions.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(667, 141);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(113, 35);
            this.BtnLuu.TabIndex = 2;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.ImageOptions.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(536, 141);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(113, 35);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCapNhat.ImageOptions.Image")));
            this.BtnCapNhat.Location = new System.Drawing.Point(405, 141);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(113, 35);
            this.BtnCapNhat.TabIndex = 2;
            this.BtnCapNhat.Text = "Cập Nhật";
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.ImageOptions.Image")));
            this.BtnThem.Location = new System.Drawing.Point(274, 141);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(113, 35);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm Mới";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(712, 100);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(190, 20);
            this.TxtDienThoai.TabIndex = 1;
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(712, 36);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(190, 20);
            this.TxtHoTen.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện Thoại";
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Location = new System.Drawing.Point(1015, 68);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(190, 20);
            this.TxtDiaChi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(939, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ Tên";
            // 
            // TxtMaDocGia
            // 
            this.TxtMaDocGia.Location = new System.Drawing.Point(347, 36);
            this.TxtMaDocGia.Name = "TxtMaDocGia";
            this.TxtMaDocGia.Size = new System.Drawing.Size(190, 20);
            this.TxtMaDocGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(939, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.EditValue = null;
            this.dtpNgaySinh.Location = new System.Drawing.Point(712, 68);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.DisplayFormat.FormatString = "";
            this.dtpNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgaySinh.Properties.EditFormat.FormatString = "";
            this.dtpNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgaySinh.Properties.Mask.EditMask = "";
            this.dtpNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNgaySinh.Size = new System.Drawing.Size(190, 20);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // CbbGioiTinh
            // 
            this.CbbGioiTinh.Location = new System.Drawing.Point(1015, 36);
            this.CbbGioiTinh.Name = "CbbGioiTinh";
            this.CbbGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbbGioiTinh.Size = new System.Drawing.Size(190, 20);
            this.CbbGioiTinh.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dvgDocGia);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 203);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 312);
            this.groupControl2.TabIndex = 2;
            // 
            // dvgDocGia
            // 
            this.dvgDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDocGia.Location = new System.Drawing.Point(2, 21);
            this.dvgDocGia.MainView = this.dvgdg;
            this.dvgDocGia.Name = "dvgDocGia";
            this.dvgDocGia.Size = new System.Drawing.Size(1278, 289);
            this.dvgDocGia.TabIndex = 0;
            this.dvgDocGia.UseEmbeddedNavigator = true;
            this.dvgDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvgdg});
            // 
            // dvgdg
            // 
            this.dvgdg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDG,
            this.TenDG,
            this.DocGiaID,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT});
            this.dvgdg.GridControl = this.dvgDocGia;
            this.dvgdg.Name = "dvgdg";
            this.dvgdg.OptionsBehavior.Editable = false;
            this.dvgdg.OptionsFind.AlwaysVisible = true;
            this.dvgdg.OptionsFind.FindDelay = 500;
            this.dvgdg.OptionsFind.FindNullPrompt = "Nhập nội dung cần tìm..";
            this.dvgdg.OptionsFind.ShowFindButton = false;
            this.dvgdg.OptionsSelection.MultiSelect = true;
            this.dvgdg.OptionsView.ShowGroupPanel = false;
            this.dvgdg.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvgdg_FocusedRowChanged);
            // 
            // MaDG
            // 
            this.MaDG.Caption = "Mã Độc Giả";
            this.MaDG.FieldName = "MaDG";
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = true;
            this.MaDG.VisibleIndex = 0;
            // 
            // TenDG
            // 
            this.TenDG.Caption = "Họ Tên";
            this.TenDG.FieldName = "TenDG";
            this.TenDG.Name = "TenDG";
            this.TenDG.Visible = true;
            this.TenDG.VisibleIndex = 1;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            // 
            // SDT
            // 
            this.SDT.Caption = "Điện Thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 6;
            // 
            // DocGiaID
            // 
            this.DocGiaID.Caption = "Độc Giả ID";
            this.DocGiaID.FieldName = "DocGiaID";
            this.DocGiaID.Name = "DocGiaID";
            this.DocGiaID.Visible = true;
            this.DocGiaID.VisibleIndex = 2;
            // 
            // cbbDocGiaID
            // 
            this.cbbDocGiaID.FormattingEnabled = true;
            this.cbbDocGiaID.Location = new System.Drawing.Point(348, 68);
            this.cbbDocGiaID.Name = "cbbDocGiaID";
            this.cbbDocGiaID.Size = new System.Drawing.Size(104, 21);
            this.cbbDocGiaID.TabIndex = 3;
            this.cbbDocGiaID.SelectedIndexChanged += new System.EventHandler(this.cbbDocGiaID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Độc Giả";
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.Location = new System.Drawing.Point(460, 71);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(58, 13);
            this.lblNgheNghiep.TabIndex = 0;
            this.lblNgheNghiep.Text = "Điện Thoại";
            // 
            // UcDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcDocGia";
            this.Size = new System.Drawing.Size(1282, 515);
            this.Load += new System.EventHandler(this.UcDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBo;
        private DevExpress.XtraEditors.SimpleButton BtnLuu;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.TextEdit TxtDienThoai;
        private DevExpress.XtraEditors.TextEdit TxtHoTen;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit TxtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private DevExpress.XtraEditors.ComboBoxEdit CbbGioiTinh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dvgDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView dvgdg;
        private DevExpress.XtraGrid.Columns.GridColumn MaDG;
        private DevExpress.XtraGrid.Columns.GridColumn TenDG;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DocGiaID;
        private System.Windows.Forms.ComboBox cbbDocGiaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgheNghiep;
    }
}
