using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAO
{
    public class XuLyKetNoi
    {
        public static string svName = "";
        public static string pass = "";

        public static string con = @"Data Source = " + svName 
            + "Initial Catalog = QLTourDuLich; User ID = sa; Password = " + pass;

        //public static string con = @"Data Source = LAPTOP-PEPM7OTH; " +
        //    "Initial Catalog = QLTourDuLich; User ID = sa; Password = giabao04";


        // Lớp kết nối ----------------------------------------------------------------------
        public static SqlConnection getConnection()
        {
            return new SqlConnection(con);
        }
    }
}