using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_qnv.BLL;
using PBL3.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PBL3.BLL
{
    internal class Controller_MI
    {
        private static Controller_MI instance;
        string query = "";
        public static Controller_MI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller_MI();
                }
                return instance;
            }
            private set { }
        }
        private void Get_Add()
        {

        }
        public DataTable View_DG(string table)
        {
            DataTable dt = new DataTable();
            dt = DB_MI.Instance.Get_DG(table);
            return dt;
        }


        public void Save_DG(DataGridViewRow row, int flag)
        {
            //List<InGoing> li = new List<InGoing>();

            //foreach (DataGridViewRow row in dg.Rows) {

            InGoing ig = new InGoing()
            {

                ID = Convert.ToInt32(row.Cells["ID_Lohang"].Value),

                ID_NCC = Convert.ToInt32(row.Cells["ID_NCC"].Value),

                SL = Convert.ToInt32(row.Cells["SL"].Value),

                Total_price = Convert.ToDouble(row.Cells["Tong_gia"].Value)
            };
            bool isexit = DB_MI.Instance.IsIDExists(ig.ID);
            if (isexit)
            {
                flag = 3;
            }
            else if(!isexit) flag = 1;


            switch (flag)
            {
                case 0:
                    View_DG("Nhaphang");
                    break;
                case 1:
                    query = "INSERT INTO Nhaphang (ID_Lohang, ID_NCC, SL, Tong_gia) VALUES (@ID_Lohang, @ID_NCC, @SL, @TongGia)";
                    break;
                case 2:
                    query = "DELETE FROM Nhaphang WHERE ID_Lohang = @ID_Lohang";
                    break;
                case 3:
                    query = "UPDATE Nhaphang SET ID_NCC = @ID_NCC, SL = @SL, Tong_gia = @TongGia WHERE ID_Lohang = @ID_Lohang";
                    break;


            }


            DB_MI.Instance.Save_ig(ig, query);

        }
        public List<string> Set_CBB()
        {
            query = "SELECT * FROM Nhaphang";
            List<string> s = new List<string>();

            foreach (DataColumn i in DBcontrol.Instance.getRecord(query).Columns)
            {
                s.Add(i.ColumnName);
            }
            s.Distinct();
            return s;

        }

        public DataTable Sort(string columnName)
        {
            string query = "SELECT * FROM Nhaphang ORDER BY "+ columnName +" ASC";
            //DBcontrol.Instance.ExcuteQuery(query, null);
            DataTable dt = new DataTable();
            dt = DBcontrol.Instance.getRecord(query);
            return dt;

          //  View_DG("Nhaphang");
        }

        public static void SortIg(List<InGoing> ingoing, Compare compare)
        {
            ingoing.Sort(new Comparison<InGoing>(compare));
        }
        public delegate int Compare(InGoing x, InGoing y);
        public static int CompareByID(InGoing x, InGoing y)
        {
            return x.ID.CompareTo(y.ID);
        }
        public static int CompareByID_NCC(InGoing x, InGoing y)
        {
            return x.ID_NCC.CompareTo(y.ID_NCC);
        }
        public static int CompareBySL(InGoing x, InGoing y)
        {
            return x.SL.CompareTo(y.SL);
        }
        public static float CompareByTong_gia(InGoing x, InGoing y)
        {
            return x.Total_price.CompareTo(y.Total_price);
        }

        public List<InGoing> GetAllRow(DataGridView dg)
        {
            List<InGoing > li = new List<InGoing>();
            foreach (DataGridViewRow row in dg.Rows)
            {

                InGoing ig = new InGoing()
                {

                    ID = Convert.ToInt32(row.Cells["ID_Lohang"].Value),

                    ID_NCC = Convert.ToInt32(row.Cells["ID_NCC"].Value),

                    SL = Convert.ToInt32(row.Cells["SL"].Value),

                    Total_price = Convert.ToDouble(row.Cells["Tong_gia"].Value)
                };
                li.Add(ig);
                //Controller_MI.Instance.Save_DG(row, 3);

            }
            return li;
        }

        


    }
}
