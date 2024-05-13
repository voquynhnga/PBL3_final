using PBL_qnv.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAL
{
    internal class DB_MI
    {
        string query = "";
        private static DB_MI instance;

        public static DB_MI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB_MI();
                }
                return instance;
            }
            private set { }
        }
        public DataTable Get_DG(string table)
        {
            query = "select * from " + table;
            DataTable dt = DBcontrol.Instance.getRecord(query);
            return dt;

        }
        public void Save_ig(InGoing ig, string query)
        {
            if (ig != null)
            {
                SqlParameter[] p = new SqlParameter[] {
                new SqlParameter("@ID_Lohang", ig.ID),
                new SqlParameter("@ID_NCC", ig.ID_NCC),
                new SqlParameter("@SL", ig.SL),
                new SqlParameter("@TongGia", ig.Total_price)
                };
                DBcontrol.Instance.ExcuteDB(query, p);

            }

            
        }
        public bool IsIDExists(int id)
        {
            string query = "SELECT COUNT(*) FROM Nhaphang WHERE ID_Lohang = @ID";
            SqlParameter[] parameters = new SqlParameter[] {
    new SqlParameter("@ID", id)
};

            // Thực thi truy vấn
            int count = (int)DBcontrol.Instance.ExcuteDBScalar(query, parameters);

            return count > 0;

        }



    }
}

