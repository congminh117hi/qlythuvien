namespace QuanLyThuVien_WF.Views
{
    partial class UcKeSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcKeSach));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.TxtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaKeSach = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtChatLieu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dvgKeSach = new DevExpress.XtraGrid.GridControl();
            this.dvgks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SucChua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKeSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKeSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnHuyBo);
            this.groupControl1.Controls.Add(this.BtnLuu);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnCapNhat);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Controls.Add(this.TxtSucChua);
            this.groupControl1.Controls.Add(this.TxtSoLuong);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtMaKeSach);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TxtChatLieu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1282, 182);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin cần điền";
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBo.Image")));
            this.BtnHuyBo.Location = new System.Drawing.Point(798, 106);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(113, 35);
            this.BtnHuyBo.TabIndex = 2;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(667, 106);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(113, 35);
            this.BtnLuu.TabIndex = 2;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(536, 106);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(113, 35);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("BtnCapNhat.Image")));
            this.BtnCapNhat.Location = new System.Drawing.Point(405, 106);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(113, 35);
            this.BtnCapNhat.TabIndex = 2;
            this.BtnCapNhat.Text = "Cập Nhật";
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.Image")));
            this.BtnThem.Location = new System.Drawing.Point(274, 106);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(113, 35);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm Mới";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TxtSucChua
            // 
            this.TxtSucChua.Location = new System.Drawing.Point(339, 69);
            this.TxtSucChua.Name = "TxtSucChua";
            this.TxtSucChua.Size = new System.Drawing.Size(190, 20);
            this.TxtSucChua.TabIndex = 1;
            this.TxtSucChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSucChua_KeyPress);
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.Enabled = false;
            this.TxtSoLuong.Location = new System.Drawing.Point(678, 68);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.Size = new System.Drawing.Size(190, 20);
            this.TxtSoLuong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sức Chứa";
            // 
            // TxtMaKeSach
            // 
            this.TxtMaKeSach.Location = new System.Drawing.Point(339, 36);
            this.TxtMaKeSach.Name = "TxtMaKeSach";
            this.TxtMaKeSach.Size = new System.Drawing.Size(190, 20);
            this.TxtMaKeSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Kệ Sách";
            // 
            // TxtChatLieu
            // 
            this.TxtChatLieu.Location = new System.Drawing.Point(678, 36);
            this.TxtChatLieu.Name = "TxtChatLieu";
            this.TxtChatLieu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtChatLieu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtChatLieu.Size = new System.Drawing.Size(190, 20);
            this.TxtChatLieu.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dvgKeSach);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 182);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 333);
            this.groupControl2.TabIndex = 5;
            // 
            // dvgKeSach
            // 
            this.dvgKeSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgKeSach.Location = new System.Drawing.Point(2, 21);
            this.dvgKeSach.MainView = this.dvgks;
            this.dvgKeSach.Name = "dvgKeSach";
            this.dvgKeSach.Size = new System.Drawing.Size(1278, 310);
            this.dvgKeSach.TabIndex = 0;
            this.dvgKeSach.UseEmbeddedNavigator = true;
            this.dvgKeSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvgks});
            // 
            // dvgks
            // 
            this.dvgks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKe,
            this.ChatLieu,
            this.SucChua,
            this.SL});
            this.dvgks.GridControl = this.dvgKeSach;
            this.dvgks.GroupCount = 1;
            this.dvgks.Name = "dvgks";
            this.dvgks.OptionsBehavior.Editable = false;
            this.dvgks.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dvgks.OptionsFind.AlwaysVisible = true;
            this.dvgks.OptionsFind.FindDelay = 500;
            this.dvgks.OptionsFind.FindNullPrompt = "Nhập nội dung cần tìm...";
            this.dvgks.OptionsFind.ShowFindButton = false;
            this.dvgks.OptionsSelection.MultiSelect = true;
            this.dvgks.OptionsView.ShowFooter = true;
            this.dvgks.OptionsView.ShowGroupPanel = false;
            this.dvgks.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.SL, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.dvgks.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvgks_FocusedRowChanged);
            // 
            // MaKe
            // 
            this.MaKe.Caption = "Mã Kệ Sách";
            this.MaKe.FieldName = "MaKe";
            this.MaKe.Name = "MaKe";
            this.MaKe.Visible = true;
            this.MaKe.VisibleIndex = 0;
            // 
            // ChatLieu
            // 
            this.ChatLieu.Caption = "Chất Liệu";
            this.ChatLieu.FieldName = "ChatLieu";
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.Visible = true;
            this.ChatLieu.VisibleIndex = 1;
            // 
            // SucChua
            // 
            this.SucChua.Caption = "Sức Chứa";
            this.SucChua.FieldName = "SucChua";
            this.SucChua.Name = "SucChua";
            this.SucChua.Visible = true;
            this.SucChua.VisibleIndex = 2;
            // 
            // SL
            // 
            this.SL.Caption = "Số Lượng Sách";
            this.SL.FieldName = "SL";
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 3;
            // 
            // UcKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcKeSach";
            this.Size = new System.Drawing.Size(1282, 515);
            this.Load += new System.EventHandler(this.UcKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaKeSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgKeSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBo;
        private DevExpress.XtraEditors.SimpleButton BtnLuu;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.TextEdit TxtSucChua;
        private DevExpress.XtraEditors.TextEdit TxtSoLuong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtMaKeSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtChatLieu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dvgKeSach;
        private DevExpress.XtraGrid.Views.Grid.GridView dvgks;
        private DevExpress.XtraGrid.Columns.GridColumn MaKe;
        private DevExpress.XtraGrid.Columns.GridColumn ChatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn SucChua;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
    }
}
