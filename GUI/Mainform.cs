using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI;

namespace PBL3
{
    public partial class Mainform : Form
    {
        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
        {
            //if (currentFormChild != null)

            //{

            //    if (!currentFormChild.IsDisposed)

            //    {

            //        currentFormChild.Close();

            //    }

            //}

            currentFormChild = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(childForm);

            panel1.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();

        }
        public Mainform()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginform lg = new Loginform();
            this.Hide();
            lg.Show();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Account a = new Account();
            //a.ShowDialog();
            OpenChildForm(new Account());

        }

        private void T4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePass());
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
           OpenChildForm(new ManageProduct());
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Body_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void T5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderForm());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void T1_Click(object sender, EventArgs e)
        {

        }

        private void bTT_Click(object sender, EventArgs e)
        {

        }

        private void T6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageCustomer());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void T2_Click(object sender, EventArgs e)
        {

        }

        private void T3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
