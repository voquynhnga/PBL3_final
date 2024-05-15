using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.DTO;

namespace PBL3.BLL
{
    internal class Controller_Customer
    {
       

        private static Controller_Customer instance;
        string query = "";
        public static Controller_Customer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller_Customer();
                }
                return instance;
            }
            private set { }
        }
        public Customer GetKH(DataGridViewRow row)

        {

            Customer customer = new Customer

            {

                ID = Convert.ToInt32(row.Cells["ID_KH"].Value),

                Name = Convert.ToString(row.Cells["NameKH"].Value),

                GT = Convert.ToString(row.Cells["GT"].Value),

                SDT = Convert.ToString(row.Cells["SDT"].Value),

                DTL = row.Cells["DTL"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["DTL"].Value) : 0

            };

            return customer;

        }
        public List<Customer> GetAllKH()
        {
            List<Customer> data = new List<Customer>();
            string query = "select * from KhachHang";
            foreach (DataGridViewRow i in DBcontrol.Instance.getRecord(query).Rows)
            {
                data.Add(GetKH(i));
            }
            return data;
        }
        public DataTable GetKH_Search(string txt)
        {
            DataTable dt = new DataTable();
            string query;
            if (IsNumeric(txt))
            {
                query = "select * from KhachHang where SDT like @Name";
            }
            else query = "select * from KhachHang where NameKH like @Name";

            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@Name", "%" + txt + "%")
            };

            dt = DBcontrol.Instance.ExcuteQuery(query, pa);
            return dt;
        }
        public void Add(Customer cus)
        {

                    query = "Insert into KhachHang (ID_KH, NameKH, GT, SDT, DTL ) values (@ID, @Name, @GT, @SDT, @DTL)";
                    SqlParameter[] pa = new SqlParameter[]
                    {
                        new SqlParameter("@ID", cus.ID),
                        new SqlParameter("@Name", cus.Name),
                        new SqlParameter("@GT", cus.GT),
                        new SqlParameter("@SDT", cus.SDT),
                        new SqlParameter("@DTL", cus.DTL)
                    };
                    DBcontrol.Instance.ExcuteDB(query, pa);

                
                //else MessageBox.Show("Lỗi");
            
        }

        static bool IsNumeric(string inputString)
        {

            return int.TryParse(inputString, out _);

        }
        private DataGridViewRow GetLastRow(DataGridView dataGridView)
        {
            int lastRowIndex = dataGridView.Rows.Count - 2;
            if (lastRowIndex >= 0)
            {
                return dataGridView.Rows[lastRowIndex];
            }
            else
            {
                return null;
            }
        }


        private int LastRow(DataGridView dataGridView)
        {
            int lastRowIndex = dataGridView.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                return lastRowIndex ;
            }
            else
            {
                return 0;
            }
        }

        public void Edit(DataGridViewRow row)
        {
            if (row != null)
            {
                Customer cus = GetKH(row);
                query = "update KhachHang set NameKH= @Name, GT = @GT, SDT = @SDT, DTL = @DTL where ID_KH = @ID";
                SqlParameter[] pa = new SqlParameter[]
                {
                        new SqlParameter("@ID", cus.ID),
                        new SqlParameter("@Name", cus.Name),
                        new SqlParameter("@GT", cus.GT),
                        new SqlParameter("@SDT", cus.SDT),
                        new SqlParameter("@DTL", cus.DTL)
                };
                DBcontrol.Instance.ExcuteDB(query, pa);



            }
        }
        public void Delete(DataGridViewRow row)
        {
            Customer cus = GetKH(row);
            query = "Delete from KhachHang where ID_KH = @ID";
            SqlParameter[] pa = new SqlParameter[]
{
                        new SqlParameter("@ID", cus.ID),
                        new SqlParameter("@Name", cus.Name),
                        new SqlParameter("@GT", cus.GT),
                        new SqlParameter("@SDT", cus.SDT),
                        new SqlParameter("@DTL", cus.DTL)
};
            DBcontrol.Instance.ExcuteDB(query, pa);
        }
    }
}
