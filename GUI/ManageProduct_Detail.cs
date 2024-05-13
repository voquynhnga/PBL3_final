using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class ManageProduct_Detail : Form
    {
        public ManageProduct_Detail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())

            {

                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {

                    try

                    {
                        p1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                    }

                    catch (Exception)

                    {

                        MessageBox.Show("Không thể tải ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void lSize_Click(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Close();
            //new P
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
