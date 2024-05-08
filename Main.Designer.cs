namespace PBL3
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.T1 = new System.Windows.Forms.ToolStripMenuItem();
            this.T2 = new System.Windows.Forms.ToolStripMenuItem();
            this.T3 = new System.Windows.Forms.ToolStripMenuItem();
            this.T4 = new System.Windows.Forms.ToolStripMenuItem();
            this.T5 = new System.Windows.Forms.ToolStripMenuItem();
            this.T6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel_Body = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel_Body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T1,
            this.T2,
            this.T3,
            this.T4,
            this.T5,
            this.T6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // T1
            // 
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(85, 24);
            this.T1.Text = "Tài khoản";
            // 
            // T2
            // 
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(78, 24);
            this.T2.Text = "Lịch làm";
            // 
            // T3
            // 
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(96, 24);
            this.T3.Text = "Đăng ký ca";
            // 
            // T4
            // 
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(112, 24);
            this.T4.Text = "Đổi mật khẩu";
            // 
            // T5
            // 
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(115, 24);
            this.T5.Text = "Tạo đơn hàng";
            // 
            // T6
            // 
            this.T6.Name = "T6";
            this.T6.Size = new System.Drawing.Size(100, 24);
            this.T6.Text = "Khách hàng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.panel1);
            this.panel_Body.Location = new System.Drawing.Point(12, 31);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(648, 395);
            this.panel_Body.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 313);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem T1;
        private System.Windows.Forms.ToolStripMenuItem T2;
        private System.Windows.Forms.ToolStripMenuItem T3;
        private System.Windows.Forms.ToolStripMenuItem T4;
        private System.Windows.Forms.ToolStripMenuItem T5;
        private System.Windows.Forms.ToolStripMenuItem T6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel panel_Body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}