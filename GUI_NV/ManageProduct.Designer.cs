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
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 73;
            // 
            // colGia
            // 
            this.colGia.FieldName = "Gia";
            this.colGia.MinWidth = 25;
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
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
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}