using PBL3.BLL;
using PBL3.DTO;
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
    public partial class ManageCustomer : Form
    {
        string GT = "";


        public ManageCustomer()
        {
            InitializeComponent();
            Show_DG();
            KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);

        }
        private void Show_DG()
        {
            DataTable dt = new DataTable();
            dt =Controller.Instance.View_DG("KhachHang");
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {

                dataGridView1.DataSource = Controller_Customer.Instance.GetKH_Search(textBox1.Text);
            }

            else Show_DG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Controller_Customer.Instance.Add(dataGridView1);
            Customer cus = new Customer()
            {
                ID = dataGridView1.Rows.Count + 1,
                Name = textBox2.Text,
                SDT = textBox3.Text,
                GT = GT,
                DTL = 0,

            };
            Controller_Customer.Instance.Add(cus);
            Show_DG();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];
            Controller_Customer.Instance.Edit(editedRow);
            Show_DG();


        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)

            {

                radioButton1.Checked = false;

                GT = "Nữ";

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)

            {

                radioButton2.Checked = false;

                GT = "Nam";

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                Controller_Customer.Instance.Delete(dataGridView1.SelectedRows[0]);
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) //Enter
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Controller_Customer.Instance.Delete(dataGridView1.SelectedRows[0]);
                }
            }
            Show_DG();
        }
    }
}
