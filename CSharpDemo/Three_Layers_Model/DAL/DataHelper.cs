using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Three_Layers_Model
{
    public class DataHelper
    {
        public SqlConnection Cnt { get; set; }

        public DataHelper(string cntString)
        {
            Cnt = new SqlConnection(cntString);
            //Cnt.ConnectionString = cntString;
        }


        public int ExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Cnt);
            Cnt.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            Cnt.Close();
            return result;
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Cnt);
            Cnt.Open();
            int result = cmd.ExecuteNonQuery();
            Cnt.Close();

        }

        public DataTable ExecuteDataSet(string query)
        {
            //SqlCommand cmd = new SqlCommand(query, Cnt);
            SqlDataAdapter da = new SqlDataAdapter(query, this.Cnt);
            //da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
