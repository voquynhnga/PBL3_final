namespace PBL3.GUI_NV
{
    partial class ManageProduct
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
<<<<<<< HEAD
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ChiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_ChiTietSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_NCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_LoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Lohang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMo_Ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 446);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ChiTietSanPhamBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(4, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(801, 375);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
            this.gridControl1.EnabledChanged += new System.EventHandler(this.gridControl1_EnabledChanged);
            this.gridControl1.TextChanged += new System.EventHandler(this.gridControl1_TextChanged);
            this.gridControl1.Validated += new System.EventHandler(this.gridControl1_Validated);
            // 
            // ChiTietSanPhamBindingSource
            // 
            //this.ChiTietSanPhamBindingSource.DataSource = typeof(PBL3.DAL.ChiTietSanPham);
=======
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID_CTSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1189, 554);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.chiTietSanPhamBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1165, 499);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
<<<<<<< HEAD
            this.colID_ChiTietSanPham,
            this.colTenHang,
            this.colID_NCC,
            this.colID_LoaiHang,
            this.colSoLuong,
            this.colGia,
            this.colID_Lohang,
            this.colMo_Ta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_ChiTietSanPham, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID_ChiTietSanPham
            // 
            this.colID_ChiTietSanPham.FieldName = "ID_ChiTietSanPham";
            this.colID_ChiTietSanPham.MinWidth = 25;
            this.colID_ChiTietSanPham.Name = "colID_ChiTietSanPham";
            this.colID_ChiTietSanPham.Visible = true;
            this.colID_ChiTietSanPham.VisibleIndex = 0;
            this.colID_ChiTietSanPham.Width = 50;
            // 
            // colTenHang
            // 
            this.colTenHang.FieldName = "TenHang";
            this.colTenHang.MinWidth = 25;
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 1;
            this.colTenHang.Width = 85;
            // 
            // colID_NCC
            // 
            this.colID_NCC.FieldName = "ID_NCC";
            this.colID_NCC.MinWidth = 25;
            this.colID_NCC.Name = "colID_NCC";
            this.colID_NCC.Width = 71;
            // 
            // colID_LoaiHang
            // 
            this.colID_LoaiHang.FieldName = "ID_LoaiHang";
            this.colID_LoaiHang.MinWidth = 25;
            this.colID_LoaiHang.Name = "colID_LoaiHang";
            this.colID_LoaiHang.Visible = true;
            this.colID_LoaiHang.VisibleIndex = 2;
            this.colID_LoaiHang.Width = 103;
            // 
            // colSoLuong
            // 
=======
            this.colID_CTSP,
            this.colSoLuong,
            this.colGia,
            this.colColor,
            this.colLoaiHang,
            this.colSanPham,
            this.colSize});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(1165, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1189, 554);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1169, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1169, 503);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // chiTietSanPhamBindingSource
            // 
           // this.chiTietSanPhamBindingSource.DataSource = typeof(PBL3.DAL.ChiTietSanPham);
            // 
            // colID_CTSP
            // 
            this.colID_CTSP.Caption = "ID";
            this.colID_CTSP.FieldName = "ID_CTSP";
            this.colID_CTSP.MinWidth = 25;
            this.colID_CTSP.Name = "colID_CTSP";
            this.colID_CTSP.Visible = true;
            this.colID_CTSP.VisibleIndex = 0;
            this.colID_CTSP.Width = 94;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
<<<<<<< HEAD
            this.colSoLuong.Width = 73;
            // 
            // colGia
            // 
=======
            this.colSoLuong.Width = 94;
            // 
            // colGia
            // 
            this.colGia.Caption = "Giá";
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            this.colGia.FieldName = "Gia";
            this.colGia.MinWidth = 25;
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
<<<<<<< HEAD
            this.colGia.VisibleIndex = 4;
            this.colGia.Width = 94;
            // 
            // colID_Lohang
            // 
            this.colID_Lohang.FieldName = "ID_Lohang";
            this.colID_Lohang.MinWidth = 25;
            this.colID_Lohang.Name = "colID_Lohang";
            this.colID_Lohang.Width = 76;
            // 
            // colMo_Ta
            // 
            this.colMo_Ta.FieldName = "Mo_Ta";
            this.colMo_Ta.MinWidth = 25;
            this.colMo_Ta.Name = "colMo_Ta";
            this.colMo_Ta.Visible = true;
            this.colMo_Ta.VisibleIndex = 5;
            this.colMo_Ta.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            this.colGia.VisibleIndex = 6;
            this.colGia.Width = 94;
            // 
            // colColor
            // 
            this.colColor.Caption = "Màu ";
            this.colColor.FieldName = "Color.color_name";
            this.colColor.MinWidth = 25;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 4;
            this.colColor.Width = 94;
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.Caption = "Loại hàng";
            this.colLoaiHang.FieldName = "LoaiHang.Ten_LoaiHang";
            this.colLoaiHang.MinWidth = 25;
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.Visible = true;
            this.colLoaiHang.VisibleIndex = 2;
            this.colLoaiHang.Width = 94;
            // 
            // colSanPham
            // 
            this.colSanPham.Caption = "Sản phẩm";
            this.colSanPham.FieldName = "SanPham.product_name";
            this.colSanPham.MinWidth = 25;
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.Visible = true;
            this.colSanPham.VisibleIndex = 1;
            this.colSanPham.Width = 94;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size.size_value";
            this.colSize.MinWidth = 25;
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 5;
            this.colSize.Width = 94;
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(1189, 554);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).EndInit();
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ChiTietSanPhamBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ChiTietSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colID_LoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Lohang;
        private DevExpress.XtraGrid.Columns.GridColumn colMo_Ta;
=======
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CTSP;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
    }
}