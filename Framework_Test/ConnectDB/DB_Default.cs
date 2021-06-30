using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Test.ConnectDB
{
    class Dbconnection
    {
        public static readonly string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["DBConnectionString"];
    }

    class DB_Default
    {

    }
}
