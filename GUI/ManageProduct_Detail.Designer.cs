namespace PBL3
{
    partial class ManageProduct_Detail
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
            this.bUpload = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.lSize = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.listSize = new System.Windows.Forms.ListBox();
            this.listColor = new System.Windows.Forms.ListBox();
            this.lQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lDetail = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // bUpload
            // 
            this.bUpload.Location = new System.Drawing.Point(192, 278);
            this.bUpload.Name = "bUpload";
            this.bUpload.Size = new System.Drawing.Size(111, 32);
            this.bUpload.TabIndex = 0;
            this.bUpload.Text = "Tải ảnh lên";
            this.bUpload.UseVisualStyleBackColor = true;
            this.bUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.p1.Location = new System.Drawing.Point(60, 75);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(183, 183);
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(351, 26);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(50, 16);
            this.lSize.TabIndex = 3;
            this.lSize.Text = "Kích cỡ";
            this.lSize.Click += new System.EventHandler(this.lSize_Click);
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(576, 31);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(58, 16);
            this.lColor.TabIndex = 4;
            this.lColor.Text = "Màu sắc";
            // 
            // listSize
            // 
            this.listSize.FormattingEnabled = true;
            this.listSize.ItemHeight = 16;
            this.listSize.Items.AddRange(new object[] {
            "size 36",
            "size 37",
            "size 38",
            "size 39",
            "size 40",
            "size 41",
            "size 42",
            "size 43",
            "size 44",
            "size 45"});
            this.listSize.Location = new System.Drawing.Point(426, 26);
            this.listSize.Name = "listSize";
            this.listSize.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listSize.Size = new System.Drawing.Size(120, 84);
            this.listSize.TabIndex = 5;
            // 
            // listColor
            // 
            this.listColor.FormattingEnabled = true;
            this.listColor.ItemHeight = 16;
            this.listColor.Items.AddRange(new object[] {
            "trắng",
            "đỏ ",
            "đen",
            "hồng",
            "vàng",
            "xanh lá",
            "cam",
            "xanh biển",
            "tím"});
            this.listColor.Location = new System.Drawing.Point(674, 31);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(120, 84);
            this.listColor.TabIndex = 6;
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(351, 157);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(60, 16);
            this.lQuantity.TabIndex = 7;
            this.lQuantity.Text = "Số lượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(674, 397);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(60, 397);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lDetail
            // 
            this.lDetail.AutoSize = true;
            this.lDetail.Location = new System.Drawing.Point(351, 242);
            this.lDetail.Name = "lDetail";
            this.lDetail.Size = new System.Drawing.Size(40, 16);
            this.lDetail.TabIndex = 11;
            this.lDetail.Text = "Mô tả";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(446, 230);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(594, 154);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(28, 16);
            this.lPrice.TabIndex = 14;
            this.lPrice.Text = "Giá";
            // 
            // tPrice
            // 
            this.tPrice.Location = new System.Drawing.Point(674, 150);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(100, 22);
            this.tPrice.TabIndex = 15;
            // 
            // ManageProduct_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lDetail);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.listSize);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.bUpload);
            this.Name = "ManageProduct_Detail";
            this.Text = "ManageProduct_Detail";
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUpload;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.ListBox listSize;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lDetail;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tPrice;
    }
}