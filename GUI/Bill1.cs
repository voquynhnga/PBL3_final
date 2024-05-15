using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class Bill1 : Form
    {
        public Bill1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hủy", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                Mainform mf = Application.OpenForms["MainForm"] as Mainform;
                mf.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainform mf = Application.OpenForms["MainForm"] as Mainform;
            mf.Show();
        }
    }
}
