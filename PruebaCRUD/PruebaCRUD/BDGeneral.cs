using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PruebaCRUD
{
    public class BDGeneral
    {
        public static SqlConnection BDConectar()
        {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-HP-ANGEL\\SQLEXPRESS; DataBase= PracticaCRUD; Integrated Security= true");
           conn.Open();
        return conn;

        }
    }
}
