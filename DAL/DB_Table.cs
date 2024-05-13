using PBL_qnv.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    internal class DB_Table
    {
        string query = "";
        private static DB_Table instance;

        public static DB_Table Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB_Table();
                }
                return instance;
            }
            private set { }
        }
        public List<Product> Get_ProductList(string table)
        {
            List<Product> list = new List<Product>();
            query = "select * from " + table;
            DataTable dt = DBcontrol.Instance.getRecord(query);
            foreach (DataRow dr in dt.Rows)
            {
                Product p = new Product();
                list.Add(p);
            }
            return list;
        }
    }
}
