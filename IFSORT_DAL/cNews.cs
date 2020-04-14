using SQLDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSORT_DAL
{
    public class cNews
    {
        public DataTable GetList()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM News_Category";
            return SQLDB.SQLDB.GetData(command);
        }
    }
}
