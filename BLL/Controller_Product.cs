using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3;
using PBL_qnv.BLL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;

namespace PBL3.BLL
{
    internal class Controller_Product
    {
        private static Controller_Product instance;
        string query = "";
        public static Controller_Product Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller_Product();
                }
                return instance;
            }
            private set { }
        }
        public DataTable Search_Product(int flag, Product p)
        {
            DataTable dt = new DataTable();
            if (flag == 1)
            {
                query = "select * from MatHang where TenHang like @Name";
                SqlParameter[] pa = new SqlParameter[]
{
                    new SqlParameter("@Name","%" + p.Name + "%")
};
                dt = DBcontrol.Instance.ExcuteQuery(query, pa);


            }
            else
            {
                query = "select * from MatHang";
                dt = DBcontrol.Instance.ExcuteQuery(query, null);

            }

            return dt;
        }

    }

}
