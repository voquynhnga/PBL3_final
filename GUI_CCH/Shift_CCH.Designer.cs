namespace PBL3.GUI_CCH
{
    partial class Shift_CCH
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
            this.components = new System.ComponentModel.Container();
            this.lichLamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit3 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaLam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lichLamBindingSource
            // 
            this.lichLamBindingSource.DataSource = typeof(PBL3.DAL.LichLam);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(PBL3.DAL.NhanVien);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Location = new System.Drawing.Point(-6, 51);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 421, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1387, 696);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1387, 696);
            this.Root.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lichLamBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(12, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1363, 615);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_NV,
            this.colCaLam,
            this.colNgayLam,
            this.colLuong,
            this.colNhanVien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 57);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1367, 619);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(728, 12);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(647, 22);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(627, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(740, 26);
            this.layoutControlItem2.Text = "Thưởng ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 16);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(101, 12);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(534, 22);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(627, 26);
            this.layoutControlItem3.Text = "Lương cơ bản";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit3;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(627, 31);
            this.layoutControlItem4.Text = "Áp dụng cho";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 16);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1238, 38);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(1226, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(141, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "";
            this.textEdit3.Location = new System.Drawing.Point(101, 38);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.AllowMultiSelect = true;
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Properties.DataSource = this.nhanVienBindingSource;
            this.textEdit3.Properties.DisplayMember = "NameNV";
            this.textEdit3.Properties.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.textEdit3.Properties.ValueMember = "ID_NV";
            this.textEdit3.Size = new System.Drawing.Size(534, 22);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 7;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(627, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(599, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colID_NV
            // 
            this.colID_NV.Caption = "ID Nhân viên";
            this.colID_NV.FieldName = "ID_NV";
            this.colID_NV.MinWidth = 25;
            this.colID_NV.Name = "colID_NV";
            this.colID_NV.Visible = true;
            this.colID_NV.VisibleIndex = 0;
            this.colID_NV.Width = 94;
            // 
            // colCaLam
            // 
            this.colCaLam.Caption = "Ca làm";
            this.colCaLam.FieldName = "CaLam";
            this.colCaLam.MinWidth = 25;
            this.colCaLam.Name = "colCaLam";
            this.colCaLam.Visible = true;
            this.colCaLam.VisibleIndex = 3;
            this.colCaLam.Width = 94;
            // 
            // colNgayLam
            // 
            this.colNgayLam.Caption = "Ngày";
            this.colNgayLam.FieldName = "NgayLam";
            this.colNgayLam.MinWidth = 25;
            this.colNgayLam.Name = "colNgayLam";
            this.colNgayLam.Visible = true;
            this.colNgayLam.VisibleIndex = 2;
            this.colNgayLam.Width = 94;
            // 
            // colLuong
            // 
            this.colLuong.Caption = "Lương";
            this.colLuong.FieldName = "Luong";
            this.colLuong.MinWidth = 25;
            this.colLuong.Name = "colLuong";
            this.colLuong.Visible = true;
            this.colLuong.VisibleIndex = 4;
            this.colLuong.Width = 94;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "Nhân viên";
            this.colNhanVien.FieldName = "NhanVien.NameNV";
            this.colNhanVien.MinWidth = 25;
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 1;
            this.colNhanVien.Width = 94;
            // 
            // Shift_CCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 741);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Shift_CCH";
            this.Text = "Shift_CCH";
            this.Load += new System.EventHandler(this.Shift_CCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lichLamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lichLamBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit textEdit3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colCaLam;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLam;
        private DevExpress.XtraGrid.Columns.GridColumn colLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
    }
}