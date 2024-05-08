using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_qnv
{
    internal class DBcontrol
    {
        private SqlConnection cnn;
        private static DBcontrol instance;

        public static DBcontrol Instance
        {
            get
            {
                if (instance == null)
                {
                    string s = "Data Source=NGANGUNGO;Initial Catalog=DATA_PBL3;Integrated Security=True";
                    instance = new DBcontrol(s);
                }
                return instance;
            }
            private set { }
        }
        private DBcontrol(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable getRecord(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void ExcuteDB(string sql, SqlParameter[] parameters)
        {
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    sql = sql.Replace(parameter.ParameterName, $"'{parameter.Value}'");
                }
            }
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)

        {

            DataTable result = new DataTable();



            using (cnn)

            {

                using (SqlCommand command = new SqlCommand(query, cnn))

                {

                    //command.Parameters.AddRange(parameters);

                    if (parameters != null)
                    {
                        //foreach (var parameter in parameters)
                        //{
                        //    query = query.Replace(parameter.ParameterName, $"'{parameter.Value}'");
                        //}
                        command.Parameters.AddRange(parameters);

                    }

                    cnn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))

                    {

                        adapter.Fill(result);

                    }

                }

            }

            return result;

        }

    }

    //public DataTable ExcuteDB(string query, SqlParameter[] parameters)
    //{
    //    DataTable dt = new DataTable();
    //    using (SqlConnection connection = new SqlConnection())
    //    {
    //        using (SqlCommand command = new SqlCommand(query, connection))
    //        {
    //            if (parameters != null)
    //            {
    //                command.Parameters.AddRange(parameters);
    //            }
    //            SqlDataAdapter adapter = new SqlDataAdapter(command);
    //            adapter.Fill(dt);
    //        }
    //    }
    //    return dt;
    //}


}






    

