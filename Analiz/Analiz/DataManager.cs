using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analiz
{
    class DataManager
    {
        SqlConnection conn;

        public void Connect()
        {
            conn = new SqlConnection();
            string ConnectionString = string.Empty;
            ConnectionString = "Server=MAU-MÜHENDIS23;Database=MacOranlari;Trusted_Connection=yes;";


            conn.ConnectionString = ConnectionString;
        }
        public DataTable ExecuteDataTable(string query, SqlParameter[] prmQuery)
        {

            Connect();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;

            addParameter(cmd, prmQuery);


            adp.SelectCommand = cmd;
            conn.Open();
            adp.Fill(dt);
            conn.Close();

            return dt;

        }
        public DataTable ExecuteDataTable(string query)
        {

            Connect();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            adp.SelectCommand = cmd;
            conn.Open();
            adp.Fill(dt);
            conn.Close();

            return dt;

        }
        private void addParameter(SqlCommand command, SqlParameter[] prmList)
        {
            for (int i = 0; i < prmList.Length; i++)
            {
                if (prmList[i] == null)
                {
                    prmList[i].Value = DBNull.Value;
                }
                command.Parameters.Add(prmList[i]);

            }
        }
        public int executeSql(string query, SqlParameter[] prmQuery)
        {
            Connect();
            conn.Open();
            int effectedRows = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            addParameter(cmd, prmQuery);
            effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
            
        }
    }
}
