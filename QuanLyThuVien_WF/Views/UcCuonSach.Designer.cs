namespace QuanLyThuVien_WF.Views
{
    partial class UcCuonSach
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCuonSach));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CbbTuaSach = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMaCuonSach = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgCuonSach = new DevExpress.XtraGrid.GridControl();
            this.dvgcs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaCuonSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.dvgCuonSach);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1282, 515);
            this.groupControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CbbTuaSach);
            this.groupControl1.Controls.Add(this.BtnXoa);
            this.groupControl1.Controls.Add(this.BtnThem);
            this.groupControl1.Controls.Add(this.BtnHuyBo);
            this.groupControl1.Controls.Add(this.BtnLuu);
            this.groupControl1.Controls.Add(this.TxtMaCuonSach);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1278, 133);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Cần Điền";
            // 
            // CbbTuaSach
            // 
            this.CbbTuaSach.AutoFilter = true;
            this.CbbTuaSach.AutoSize = true;
            this.CbbTuaSach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.CbbTuaSach.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CbbTuaSach.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CbbTuaSach.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbbTuaSach.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CbbTuaSach.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbbTuaSach.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CbbTuaSach.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CbbTuaSach.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CbbTuaSach.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CbbTuaSach.EditorControl.MasterTemplate.EnableFiltering = true;
            this.CbbTuaSach.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CbbTuaSach.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CbbTuaSach.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.CbbTuaSach.EditorControl.Name = "NestedRadGridView";
            this.CbbTuaSach.EditorControl.ReadOnly = true;
            this.CbbTuaSach.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.CbbTuaSach.EditorControl.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.CbbTuaSach.EditorControl.ShowGroupPanel = false;
            this.CbbTuaSach.EditorControl.TabIndex = 0;
            this.CbbTuaSach.Location = new System.Drawing.Point(672, 34);
            this.CbbTuaSach.Name = "CbbTuaSach";
            // 
            // 
            // 
            this.CbbTuaSach.RootElement.ControlBounds = new System.Drawing.Rectangle(672, 34, 100, 20);
            this.CbbTuaSach.Size = new System.Drawing.Size(190, 20);
            this.CbbTuaSach.TabIndex = 50;
            this.CbbTuaSach.TabStop = false;
            // 
            // BtnXoa
            // 
            this.BtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.ImageOptions.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(455, 72);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(113, 35);
            this.BtnXoa.TabIndex = 46;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnThem.ImageOptions.Image")));
            this.BtnThem.Location = new System.Drawing.Point(314, 72);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(113, 35);
            this.BtnThem.TabIndex = 44;
            this.BtnThem.Text = "Thêm Mới";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyBo.ImageOptions.Image")));
            this.BtnHuyBo.Location = new System.Drawing.Point(737, 72);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(113, 35);
            this.BtnHuyBo.TabIndex = 48;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.ImageOptions.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(596, 72);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(113, 35);
            this.BtnLuu.TabIndex = 47;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // TxtMaCuonSach
            // 
            this.TxtMaCuonSach.EditValue = "";
            this.TxtMaCuonSach.Location = new System.Drawing.Point(378, 34);
            this.TxtMaCuonSach.Name = "TxtMaCuonSach";
            this.TxtMaCuonSach.Properties.NullText = "Mã TS";
            this.TxtMaCuonSach.Size = new System.Drawing.Size(190, 20);
            this.TxtMaCuonSach.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tên Tựa Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Cuốn Sách";
            // 
            // dvgCuonSach
            // 
            this.dvgCuonSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgCuonSach.Location = new System.Drawing.Point(2, 158);
            this.dvgCuonSach.MainView = this.dvgcs;
            this.dvgCuonSach.Name = "dvgCuonSach";
            this.dvgCuonSach.Size = new System.Drawing.Size(1278, 355);
            this.dvgCuonSach.TabIndex = 0;
            this.dvgCuonSach.UseEmbeddedNavigator = true;
            this.dvgCuonSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvgcs});
            this.dvgCuonSach.Load += new System.EventHandler(this.dvgCuonSach_Load);
            // 
            // dvgcs
            // 
            this.dvgcs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenTS,
            this.MaCS});
            this.dvgcs.GridControl = this.dvgCuonSach;
            this.dvgcs.GroupCount = 1;
            this.dvgcs.Name = "dvgcs";
            this.dvgcs.OptionsFind.AlwaysVisible = true;
            this.dvgcs.OptionsFind.FindDelay = 500;
            this.dvgcs.OptionsFind.FindNullPrompt = "Nhập nội dung cần tìm...";
            this.dvgcs.OptionsFind.ShowFindButton = false;
            this.dvgcs.OptionsSelection.MultiSelect = true;
            this.dvgcs.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TenTS, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.dvgcs.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvgts_FocusedRowChanged);
            // 
            // TenTS
            // 
            this.TenTS.Caption = "Tên Tựa Sách";
            this.TenTS.FieldName = "TenTS";
            this.TenTS.Name = "TenTS";
            this.TenTS.Visible = true;
            this.TenTS.VisibleIndex = 0;
            // 
            // MaCS
            // 
            this.MaCS.Caption = "Mã Cuốn Sách";
            this.MaCS.FieldName = "MaCS";
            this.MaCS.Name = "MaCS";
            this.MaCS.Visible = true;
            this.MaCS.VisibleIndex = 0;
            // 
            // UcCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "UcCuonSach";
            this.Size = new System.Drawing.Size(1282, 515);
            this.Load += new System.EventHandler(this.UcCuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaCuonSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dvgCuonSach;
        private DevExpress.XtraGrid.Views.Grid.GridView dvgcs;
        private DevExpress.XtraGrid.Columns.GridColumn TenTS;
        private DevExpress.XtraGrid.Columns.GridColumn MaCS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CbbTuaSach;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton BtnHuyBo;
        private DevExpress.XtraEditors.SimpleButton BtnLuu;
        private DevExpress.XtraEditors.TextEdit TxtMaCuonSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
