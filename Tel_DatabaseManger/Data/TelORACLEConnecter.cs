using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tel_DatabaseManger.providers;

namespace Tel_DatabaseManger.Data
{
    public class TelORACLEConnecter : ITelIDbProvider
    {
        public IDbConnection Connection(string connectionString)
        {
            return new OracleConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new OracleCommand(cmdText, (OracleConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new OracleDataAdapter((OracleCommand)command);
        }
    }
}
