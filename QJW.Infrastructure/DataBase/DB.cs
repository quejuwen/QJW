using Loogn.OrmLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QJW.Utils;

namespace QJW.Infrastructure.DataBase
{
    public class DB
    {
        static string connString = ConfigHelper.ConnString("dbconn");
        public static DbConnection Open()
        {
            return new SqlConnection(connString);
        }
    }
}
