using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelDatabaseManger.Data;

namespace Tel_DatabaseManger.Data
{
    public class TelSqlHelper
    {
        IDbConnection cn;
        TelDatabaseConfigCL db = new TelDatabaseConfigCL();
        public TelSqlHelper(string servertype,string connectionString)
        {
            cn = db.TestconnectDatabase(servertype,connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
