namespace PBL3.GUI_CCH
{
    partial class ReBox
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
            this.btnSave = new System.Windows.Forms.Button();
            this.chkEvening = new System.Windows.Forms.CheckBox();
            this.chkAfternoon = new System.Windows.Forms.CheckBox();
            this.chkMorning = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 141);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkEvening
            // 
            this.chkEvening.AutoSize = true;
            this.chkEvening.Location = new System.Drawing.Point(29, 113);
            this.chkEvening.Margin = new System.Windows.Forms.Padding(4);
            this.chkEvening.Name = "chkEvening";
            this.chkEvening.Size = new System.Drawing.Size(49, 20);
            this.chkEvening.TabIndex = 8;
            this.chkEvening.Text = "Tối";
            this.chkEvening.UseVisualStyleBackColor = true;
            // 
            // chkAfternoon
            // 
            this.chkAfternoon.AutoSize = true;
            this.chkAfternoon.Location = new System.Drawing.Point(29, 84);
            this.chkAfternoon.Margin = new System.Windows.Forms.Padding(4);
            this.chkAfternoon.Name = "chkAfternoon";
            this.chkAfternoon.Size = new System.Drawing.Size(63, 20);
            this.chkAfternoon.TabIndex = 7;
            this.chkAfternoon.Text = "Chiều";
            this.chkAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkMorning
            // 
            this.chkMorning.AutoSize = true;
            this.chkMorning.Location = new System.Drawing.Point(29, 56);
            this.chkMorning.Margin = new System.Windows.Forms.Padding(4);
            this.chkMorning.Name = "chkMorning";
            this.chkMorning.Size = new System.Drawing.Size(61, 20);
            this.chkMorning.TabIndex = 6;
            this.chkMorning.Text = "Sáng";
            this.chkMorning.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(25, 24);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Ngày: ";
            // 
            // ReBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkEvening);
            this.Controls.Add(this.chkAfternoon);
            this.Controls.Add(this.chkMorning);
            this.Controls.Add(this.lblDate);
            this.Name = "ReBox";
            this.Text = "ReBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkEvening;
        private System.Windows.Forms.CheckBox chkAfternoon;
        private System.Windows.Forms.CheckBox chkMorning;
        private System.Windows.Forms.Label lblDate;
    }
}