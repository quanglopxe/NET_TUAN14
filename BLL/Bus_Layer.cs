using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Bus_Layer
    {
        public static SqlConnection ConnectData()
        {
            return ConnectionData.Connect();
        }
        public static DataTable GetGV(string MADV)
        {
            return DataAccess.Get_HOTEN_GV(MADV);
        }
        public static DataTable GetDonVi(string MACS)
        {
            return DataAccess.GetDonVi(MACS);
        }
        public static DataTable GetInfoGV(string MAGV)
        {
            return DataAccess.Get_Info_GV(MAGV);
        }
    }
}
