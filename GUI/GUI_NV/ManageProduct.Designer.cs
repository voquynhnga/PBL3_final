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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.chiTietSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_ChiTietSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_NCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_LoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Lohang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 541);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(98, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.DataSource = this.chiTietSanPhamBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(99, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(906, 408);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chiTietSanPhamBindingSource
            // 
            this.chiTietSanPhamBindingSource.DataSource = typeof(PBL3.DAL.ChiTietSanPham);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_ChiTietSanPham,
            this.colTenHang,
            this.colID_NCC,
            this.colID_LoaiHang,
            this.colSoLuong,
            this.colGia,
            this.colID_Lohang,
            this.colColor,
            this.colSize});
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
            this.colID_ChiTietSanPham.Caption = "ID";
            this.colID_ChiTietSanPham.FieldName = "ID_CTSP";
            this.colID_ChiTietSanPham.MinWidth = 25;
            this.colID_ChiTietSanPham.Name = "colID_ChiTietSanPham";
            this.colID_ChiTietSanPham.Visible = true;
            this.colID_ChiTietSanPham.VisibleIndex = 0;
            this.colID_ChiTietSanPham.Width = 50;
            // 
            // colTenHang
            // 
            this.colTenHang.Caption = "Sản phẩm";
            this.colTenHang.FieldName = "SanPham.product_name";
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
            this.colID_LoaiHang.Caption = "Phân loại";
            this.colID_LoaiHang.FieldName = "LoaiHang.Ten_LoaiHang";
            this.colID_LoaiHang.MinWidth = 25;
            this.colID_LoaiHang.Name = "colID_LoaiHang";
            this.colID_LoaiHang.Visible = true;
            this.colID_LoaiHang.VisibleIndex = 2;
            this.colID_LoaiHang.Width = 103;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 73;
            // 
            // colGia
            // 
            this.colGia.Caption = "Giá";
            this.colGia.FieldName = "Gia";
            this.colGia.MinWidth = 25;
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
            this.colGia.VisibleIndex = 6;
            this.colGia.Width = 94;
            // 
            // colID_Lohang
            // 
            this.colID_Lohang.FieldName = "ID_Lohang";
            this.colID_Lohang.MinWidth = 25;
            this.colID_Lohang.Name = "colID_Lohang";
            this.colID_Lohang.Width = 76;
            // 
            // colColor
            // 
            this.colColor.Caption = "Màu sắc";
            this.colColor.FieldName = "Color.color_name";
            this.colColor.MinWidth = 25;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 4;
            this.colColor.Width = 94;
            // 
            // colSize
            // 
            this.colSize.Caption = "Size";
            this.colSize.FieldName = "Size.size_value";
            this.colSize.MinWidth = 25;
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 5;
            this.colSize.Width = 94;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 541);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ChiTietSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colID_LoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Lohang;
        private System.Windows.Forms.BindingSource chiTietSanPhamBindingSource;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
    }
}