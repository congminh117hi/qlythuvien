namespace QuanLyThuVien_WF.Views
{
    partial class UcKhoaLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcKhoaLop));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dvgKhoa = new DevExpress.XtraGrid.GridControl();
            this.dvgkh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnXoaKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThemKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHuyBoKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuuKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dvgLop = new DevExpress.XtraGrid.GridControl();
            this.dvglp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnXoaLop = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMaKh = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.BtnThemLop = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuuLop = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHuyBoLop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvglp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dvgKhoa);
            this.groupControl1.Controls.Add(this.txtTenKhoa);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.TxtMaKhoa);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.BtnXoaKhoa);
            this.groupControl1.Controls.Add(this.BtnThemKhoa);
            this.groupControl1.Controls.Add(this.BtnHuyBoKhoa);
            this.groupControl1.Controls.Add(this.BtnLuuKhoa);
            this.groupControl1.Location = new System.Drawing.Point(13, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 585);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin khoa";
            // 
            // dvgKhoa
            // 
            this.dvgKhoa.Location = new System.Drawing.Point(5, 164);
            this.dvgKhoa.MainView = this.dvgkh;
            this.dvgKhoa.Name = "dvgKhoa";
            this.dvgKhoa.Size = new System.Drawing.Size(473, 416);
            this.dvgKhoa.TabIndex = 55;
            this.dvgKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvgkh});
            this.dvgKhoa.DataSourceChanged += new System.EventHandler(this.dvgKhoa_DataSourceChanged);
            this.dvgKhoa.Load += new System.EventHandler(this.dvgKhoa_Load);
            // 
            // dvgkh
            // 
            this.dvgkh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dvgkh.GridControl = this.dvgKhoa;
            this.dvgkh.Name = "dvgkh";
            this.dvgkh.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvgkh_FocusedRowChanged);
            // 
            // MaKhoa
            // 
            this.MaKhoa.Caption = "Mã Khoa";
            this.MaKhoa.FieldName = "MaKhoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Visible = true;
            this.MaKhoa.VisibleIndex = 0;
            // 
            // TenKhoa
            // 
            this.TenKhoa.Caption = "Tên Khoa";
            this.TenKhoa.FieldName = "TenKhoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Visible = true;
            this.TenKhoa.VisibleIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(279, 59);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(154, 20);
            this.txtTenKhoa.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên Khoa";
            // 
            // TxtMaKhoa
            // 
            this.TxtMaKhoa.Location = new System.Drawing.Point(79, 59);
            this.TxtMaKhoa.Name = "TxtMaKhoa";
            this.TxtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.TxtMaKhoa.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã Khoa";
            // 
            // BtnXoaKhoa
            // 
            this.BtnXoaKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoaKhoa.ImageOptions.SvgImage")));
            this.BtnXoaKhoa.Location = new System.Drawing.Point(126, 99);
            this.BtnXoaKhoa.Name = "BtnXoaKhoa";
            this.BtnXoaKhoa.Size = new System.Drawing.Size(92, 35);
            this.BtnXoaKhoa.TabIndex = 50;
            this.BtnXoaKhoa.Text = "Xóa";
            this.BtnXoaKhoa.Click += new System.EventHandler(this.BtnXoaKhoa_Click);
            // 
            // BtnThemKhoa
            // 
            this.BtnThemKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemKhoa.ImageOptions.Image")));
            this.BtnThemKhoa.Location = new System.Drawing.Point(28, 99);
            this.BtnThemKhoa.Name = "BtnThemKhoa";
            this.BtnThemKhoa.Size = new System.Drawing.Size(92, 35);
            this.BtnThemKhoa.TabIndex = 49;
            this.BtnThemKhoa.Text = "Thêm Mới";
            this.BtnThemKhoa.Click += new System.EventHandler(this.BtnThemKhoa_Click);
            // 
            // BtnHuyBoKhoa
            // 
            this.BtnHuyBoKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBoKhoa.ImageOptions.Image")));
            this.BtnHuyBoKhoa.Location = new System.Drawing.Point(322, 99);
            this.BtnHuyBoKhoa.Name = "BtnHuyBoKhoa";
            this.BtnHuyBoKhoa.Size = new System.Drawing.Size(92, 35);
            this.BtnHuyBoKhoa.TabIndex = 52;
            this.BtnHuyBoKhoa.Text = "Hủy Bỏ";
            this.BtnHuyBoKhoa.Click += new System.EventHandler(this.BtnHuyBoKhoa_Click);
            // 
            // BtnLuuKhoa
            // 
            this.BtnLuuKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuuKhoa.ImageOptions.Image")));
            this.BtnLuuKhoa.Location = new System.Drawing.Point(224, 99);
            this.BtnLuuKhoa.Name = "BtnLuuKhoa";
            this.BtnLuuKhoa.Size = new System.Drawing.Size(92, 35);
            this.BtnLuuKhoa.TabIndex = 51;
            this.BtnLuuKhoa.Text = "Lưu";
            this.BtnLuuKhoa.Click += new System.EventHandler(this.BtnLuuKhoa_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dvgLop);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.BtnXoaLop);
            this.groupControl2.Controls.Add(this.TxtMaKh);
            this.groupControl2.Controls.Add(this.txtMaLop);
            this.groupControl2.Controls.Add(this.BtnThemLop);
            this.groupControl2.Controls.Add(this.BtnLuuLop);
            this.groupControl2.Controls.Add(this.BtnHuyBoLop);
            this.groupControl2.Location = new System.Drawing.Point(498, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(407, 585);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách lớp";
            // 
            // dvgLop
            // 
            this.dvgLop.Location = new System.Drawing.Point(6, 169);
            this.dvgLop.MainView = this.dvglp;
            this.dvgLop.Name = "dvgLop";
            this.dvgLop.Size = new System.Drawing.Size(400, 410);
            this.dvgLop.TabIndex = 54;
            this.dvgLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvglp});
            this.dvgLop.DataSourceChanged += new System.EventHandler(this.dvgLop_DataSourceChanged);
            this.dvgLop.Load += new System.EventHandler(this.dvgLop_Load);
            // 
            // dvglp
            // 
            this.dvglp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLop,
            this.clMaKhoa});
            this.dvglp.GridControl = this.dvgLop;
            this.dvglp.Name = "dvglp";
            this.dvglp.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvglp_FocusedRowChanged);
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã Lớp";
            this.MaLop.FieldName = "MaLop";
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 0;
            // 
            // clMaKhoa
            // 
            this.clMaKhoa.Caption = "Mã Khoa";
            this.clMaKhoa.FieldName = "MaKhoa";
            this.clMaKhoa.Name = "clMaKhoa";
            this.clMaKhoa.Visible = true;
            this.clMaKhoa.VisibleIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã Lớp";
            // 
            // BtnXoaLop
            // 
            this.BtnXoaLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoaLop.ImageOptions.SvgImage")));
            this.BtnXoaLop.Location = new System.Drawing.Point(105, 114);
            this.BtnXoaLop.Name = "BtnXoaLop";
            this.BtnXoaLop.Size = new System.Drawing.Size(92, 35);
            this.BtnXoaLop.TabIndex = 50;
            this.BtnXoaLop.Text = "Xóa";
            this.BtnXoaLop.Click += new System.EventHandler(this.BtnXoaLop_Click);
            // 
            // TxtMaKh
            // 
            this.TxtMaKh.Enabled = false;
            this.TxtMaKh.Location = new System.Drawing.Point(217, 59);
            this.TxtMaKh.Name = "TxtMaKh";
            this.TxtMaKh.Size = new System.Drawing.Size(176, 20);
            this.TxtMaKh.TabIndex = 54;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(52, 59);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(94, 20);
            this.txtMaLop.TabIndex = 54;
            // 
            // BtnThemLop
            // 
            this.BtnThemLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemLop.ImageOptions.Image")));
            this.BtnThemLop.Location = new System.Drawing.Point(7, 114);
            this.BtnThemLop.Name = "BtnThemLop";
            this.BtnThemLop.Size = new System.Drawing.Size(92, 35);
            this.BtnThemLop.TabIndex = 49;
            this.BtnThemLop.Text = "Thêm Mới";
            this.BtnThemLop.Click += new System.EventHandler(this.BtnThemLop_Click);
            // 
            // BtnLuuLop
            // 
            this.BtnLuuLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuuLop.ImageOptions.Image")));
            this.BtnLuuLop.Location = new System.Drawing.Point(203, 114);
            this.BtnLuuLop.Name = "BtnLuuLop";
            this.BtnLuuLop.Size = new System.Drawing.Size(92, 35);
            this.BtnLuuLop.TabIndex = 51;
            this.BtnLuuLop.Text = "Lưu";
            this.BtnLuuLop.Click += new System.EventHandler(this.BtnLuuLop_Click);
            // 
            // BtnHuyBoLop
            // 
            this.BtnHuyBoLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBoLop.ImageOptions.Image")));
            this.BtnHuyBoLop.Location = new System.Drawing.Point(301, 114);
            this.BtnHuyBoLop.Name = "BtnHuyBoLop";
            this.BtnHuyBoLop.Size = new System.Drawing.Size(92, 35);
            this.BtnHuyBoLop.TabIndex = 52;
            this.BtnHuyBoLop.Text = "Hủy Bỏ";
            this.BtnHuyBoLop.Click += new System.EventHandler(this.BtnHuyBoLop_Click);
            // 
            // UcKhoaLop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcKhoaLop";
            this.Size = new System.Drawing.Size(1217, 622);
            this.Load += new System.EventHandler(this.UcKhoaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvglp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnXoaKhoa;
        private DevExpress.XtraEditors.SimpleButton BtnThemKhoa;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBoKhoa;
        private DevExpress.XtraEditors.SimpleButton BtnLuuKhoa;
        private DevExpress.XtraEditors.SimpleButton BtnXoaLop;
        private DevExpress.XtraEditors.SimpleButton BtnThemLop;
        private DevExpress.XtraEditors.SimpleButton BtnLuuLop;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBoLop;
        private DevExpress.XtraGrid.GridControl dvgKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView dvgkh;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtMaKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dvgLop;
        private DevExpress.XtraGrid.Views.Grid.GridView dvglp;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn clMaKhoa;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit TxtMaKh;
    }
}
