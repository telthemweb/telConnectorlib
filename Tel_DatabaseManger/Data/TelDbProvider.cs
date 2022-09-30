using System.Data;
using Tel_DatabaseManger.providers;

namespace Tel_DatabaseManger.Data
{
    /// <summary>
    ///  Designed by Innocent Tauzeni
    ///  Harare,Zimbabwe 
    ///  Company : Telthemweb 
    ///  www.innotauzeni.co.zw
    ///  Date: 28/09/2022
    ///  
    /// Note: Dependency Injection Using Constructor Injection, the interface ITelIDbProvider is injected to the TelDbProvider.
    ///       All the implementation is using Injected instance to complete the implementation
    /// </summary>
    class TelDbProvider : ITelIDbProvider
    {
        private ITelIDbProvider _dbprovider;
        public TelDbProvider(ITelIDbProvider operations)
        {
            _dbprovider = operations;
        }
        public IDbConnection Connection(string connectionString)
        {
            return _dbprovider.Connection(connectionString);
        }

        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
           return  _dbprovider.Command(cmdText, conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return _dbprovider.DataAdapter(command);
        }
    }
}
