namespace PBL3.GUI_CCH
{
    partial class Salary
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
            this.cbb_Ap = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Thuong = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_Bo = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_AP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Ap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Thuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
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
            // cbb_Ap
            // 
            this.cbb_Ap.EditValue = "";
            this.cbb_Ap.Location = new System.Drawing.Point(95, 38);
            this.cbb_Ap.Name = "cbb_Ap";
            this.cbb_Ap.Properties.AllowMultiSelect = true;
            this.cbb_Ap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_Ap.Properties.DataSource = this.nhanVienBindingSource;
            this.cbb_Ap.Properties.DisplayMember = "NameNV";
            this.cbb_Ap.Properties.DropDownRows = 5;
            this.cbb_Ap.Properties.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.cbb_Ap.Properties.ValueMember = "ID_NV";
            this.cbb_Ap.Size = new System.Drawing.Size(596, 22);
            this.cbb_Ap.StyleController = this.layoutControl1;
            this.cbb_Ap.TabIndex = 6;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.txt_Thuong);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.cbb_Ap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 136, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1230, 749);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lichLamBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(24, 159);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1182, 566);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_NV,
            this.colLuong,
            this.colNhanVien,
            this.colTh,
            this.colBo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colID_NV
            // 
            this.colID_NV.FieldName = "ID_NV";
            this.colID_NV.MinWidth = 25;
            this.colID_NV.Name = "colID_NV";
            this.colID_NV.Visible = true;
            this.colID_NV.VisibleIndex = 0;
            this.colID_NV.Width = 94;
            // 
            // colLuong
            // 
            this.colLuong.Caption = "Lương";
            this.colLuong.FieldName = "Luong";
            this.colLuong.MinWidth = 25;
            this.colLuong.Name = "colLuong";
            this.colLuong.Visible = true;
            this.colLuong.VisibleIndex = 3;
            this.colLuong.Width = 94;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "Nhân viên";
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.MinWidth = 25;
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 1;
            this.colNhanVien.Width = 94;
            // 
            // colTh
            // 
            this.colTh.Caption = "Tháng";
            this.colTh.FieldName = "NgayLam";
            this.colTh.MinWidth = 25;
            this.colTh.Name = "colTh";
            this.colTh.Visible = true;
            this.colTh.VisibleIndex = 2;
            this.colTh.Width = 94;
            // 
            // colBo
            // 
            this.colBo.Caption = "Thưởng";
            this.colBo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBo.FieldName = "Thuong";
            this.colBo.MinWidth = 25;
            this.colBo.Name = "colBo";
            this.colBo.Visible = true;
            this.colBo.VisibleIndex = 4;
            this.colBo.Width = 94;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton1.Location = new System.Drawing.Point(1081, 90);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_Thuong
            // 
            this.txt_Thuong.Location = new System.Drawing.Point(95, 12);
            this.txt_Thuong.Name = "txt_Thuong";
            this.txt_Thuong.Size = new System.Drawing.Size(596, 22);
            this.txt_Thuong.StyleController = this.layoutControl1;
            this.txt_Thuong.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(95, 64);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(596, 22);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txt_Bo,
            this.txt_AP,
            this.layoutControlGroup1,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.layoutControlItem1,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1230, 749);
            this.Root.TextVisible = false;
            // 
            // txt_Bo
            // 
            this.txt_Bo.Control = this.txt_Thuong;
            this.txt_Bo.Location = new System.Drawing.Point(0, 0);
            this.txt_Bo.Name = "txt_Bo";
            this.txt_Bo.Size = new System.Drawing.Size(683, 26);
            this.txt_Bo.Text = "Thưởng";
            this.txt_Bo.TextSize = new System.Drawing.Size(71, 16);
            // 
            // txt_AP
            // 
            this.txt_AP.Control = this.cbb_Ap;
            this.txt_AP.Location = new System.Drawing.Point(0, 26);
            this.txt_AP.Name = "txt_AP";
            this.txt_AP.Size = new System.Drawing.Size(683, 26);
            this.txt_AP.Text = "Áp dụng cho";
            this.txt_AP.TextSize = new System.Drawing.Size(71, 16);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 109);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1210, 620);
            this.layoutControlGroup1.Text = "Bảng lương";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1186, 570);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.dateEdit1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(683, 26);
            this.layoutControlItem10.Text = "Tháng";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(71, 16);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.simpleButton1;
            this.layoutControlItem11.Location = new System.Drawing.Point(1069, 78);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(141, 31);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(683, 78);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(386, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(683, 26);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(527, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(683, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(527, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(683, 52);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(527, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colThang
            // 
            this.colThang.Caption = "Tháng";
            this.colThang.FieldName = "GetMonth(NgayLam)";
            this.colThang.MinWidth = 25;
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 2;
            this.colThang.Width = 94;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(100, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 27);
            this.label1.TabIndex = 17;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(88, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(595, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 78);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(88, 31);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 749);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lichLamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Ap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Thuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lichLamBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbb_Ap;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txt_Thuong;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem txt_Bo;
        private DevExpress.XtraLayout.LayoutControlItem txt_AP;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn colTh;
        private DevExpress.XtraGrid.Columns.GridColumn colBo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}