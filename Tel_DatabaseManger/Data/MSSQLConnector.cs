using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tel_DatabaseManger.providers;
using System.Data.SqlClient;

namespace Tel_DatabaseManger.Data
{
    public class TelMSSQLConnector : ITelIDbProvider
    {
        public IDbConnection Connection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new SqlCommand(cmdText, (SqlConnection)conn);
        }


        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }
    }
}
