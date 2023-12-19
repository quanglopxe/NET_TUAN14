using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ConnectionData
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=A209PC38;Initial Catalog=BAI14;Integrated Security=True");
            return conn;
        }
    }
    public class DataAccess
    {
        public static DataTable Get_HOTEN_GV(string MADV)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SHOW_GV_WITH_HOTEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MADV", MADV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable GetDonVi(string MACS)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SHOW_DV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACS", MACS);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable Get_Info_GV(string MAGV)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SHOW_GV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAGV", MAGV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
