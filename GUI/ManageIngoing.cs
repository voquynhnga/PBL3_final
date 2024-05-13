//using PBL3.BLL;
//using Syncfusion.Windows.Forms;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Deployment.Internal;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;


//namespace PBL3.GUI
//{
//    public partial class ManageIngoing : Form
//    {
//        bool add = false;
//        bool delete = false;
//        bool edit = false;

//        public ManageIngoing()
//        {
//            InitializeComponent();
//            View_DG();

//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void bAdd_Click(object sender, EventArgs e)
//        {
//            //ManageIngoing_detail md = new ManageIngoing_detail();
//            ////SỬA
//            //md.d += new ManageIngoing_detail.MyDel(Add(int id));
//            //md.Show();
//        }
//        private void View_DG()
//        {
//            DataTable d = Controller_MI.Instance.View_DG();
//            dataGridView1.DataSource = d;

//        }

//        private void gridControl1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
//        {

//        }

//        private void bSave_Click(object sender, EventArgs e)
//        {

//            //foreach (DataGridViewRow row in dataGridView1.Rows)
//            //{
//            //    if (row.Cells["ID_Lohang"].Value != null && !string.IsNullOrEmpty(row.Cells["ID_Lohang"].Value.ToString()) && Convert.ToInt32(row.Cells["ID_Lohang"].Value) != 0)
//            //    {
//            //        Controller_MI.Instance.Save_DG(row);
//            //    }
//            int f = flag();
//            foreach (DataGridViewRow row in dataGridView1.Rows)
//            {
//                if(row.IsNewRow && f == 3){
//                    if (row.Cells["ID_Lohang"].Value != null && !string.IsNullOrEmpty(row.Cells["ID_Lohang"].Value.ToString()) && Convert.ToInt32(row.Cells["ID_Lohang"].Value) != 0)
//                    {
//                        Controller_MI.Instance.Save_DG(row[-1], f);
//                    }
//                }
//            }




//            MessageBox.Show("Lưu thành công");

//            View_DG();

//           // edit = true;

//        }
//        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
//        {
//            // Đặt cờ thành true khi hàng mới được thêm vào
//            //add = true;
//        }
//        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
//        {
//            // Xác định khi một ô trong DataGridView đã được thay đổi
//            edit = true;
//        }

//        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
//        {
//            // Xác định khi người dùng chuẩn bị xóa một hàng từ DataGridView
//            delete = true;
//        }
//        private int flag()
//        {
//            if (add) return 1;
//            if (delete) return 2;
//            if(edit) return 3;
//            else return 0;
//        }



//    }
//}

using PBL_qnv.BLL;
using PBL3.BLL;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ManageIngoing : Form
    {
        bool edit = false; // Chỉ cần theo dõi trạng thái chỉnh sửa

        public ManageIngoing()
        {
            InitializeComponent();
            View_DG("Nhaphang");
            SetCBB();
        }

        private void View_DG(string table)
        {
            DataTable d = Controller_MI.Instance.View_DG(table);
            dataGridView1.DataSource = d;
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            // Thêm mới một hàng vào DataGridView
            dataGridView1.Rows.Add();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            // Lưu dữ liệu chỉ khi có sự thay đổi
            int f = flag();
            if (edit)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow )
                    {
                        Controller_MI.Instance.Save_DG(row, f);
                    }
                    //if()
                }

                // Hiển thị thông báo lưu thành công
                MessageBox.Show("Lưu thành công");
            }
                View_DG("Nhaphang");

                edit = false;
            
        }

        private bool ValidateRow(DataGridViewRow row)
        {

            //if (row.Cells["ID_Lohang"].Value == null || string.IsNullOrEmpty(row.Cells["ID_Lohang"].Value.ToString()))
            //{
            //    MessageBox.Show("Vui lòng nhập ID_Lohang");
            //    return false;
            //}
            int idLohang;
            if (!int.TryParse(row.Cells["ID_Lohang"].Value.ToString(), out idLohang) || idLohang <= 0)
            {
                MessageBox.Show("ID_Lohang phải là số nguyên dương");
                return false;
            }

            return true; 
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xác định khi một ô trong DataGridView đã được thay đổi
            edit = true;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Xác định khi người dùng chuẩn bị xóa một hàng từ DataGridView
            edit = true; // Đánh dấu là có sự thay đổi
        }
        private int flag()
        {

            if (edit) return 3;
            else return 0;
        }
        private void SetCBB()
        {
            List<string> list = new List<string>();
            list = Controller_MI.Instance.Set_CBB();
            comboBox1.Items.AddRange(list.Distinct().ToArray());

        }

        private void bSort_Click(object sender, EventArgs e)
        {
            string item = (string)comboBox1.SelectedItem;
            DataTable dt = new DataTable();
            
            if(comboBox1.SelectedItem != null)
            {
                dt = Controller_MI.Instance.Sort(item);
                dataGridView1.DataSource = dt;
                List<InGoing> list = Controller_MI.Instance.GetAllRow(dataGridView1);
                //if(item == "ID_Lohang")
                //{
                //    Controller_MI.SortIg(list, Controller_MI.CompareByID);
                //    dataGridView1.DataSource = list;
                //}


                // Controller_MI.Instance.Save_DG(row, 0);
                //View_DG("Nhaphang");
                //bSave_Click(sender, e );
            }
            else
            {
                dt = Controller_MI.Instance.Sort("ID_Lohang");
                dataGridView1.DataSource = dt;
            }

        }
    }
}

