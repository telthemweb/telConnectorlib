
//using System.Data;

using System.Data;

namespace Tel_DatabaseManger.providers
{
    /// <summary>
    ///  Designed by Innocent Tauzeni
    ///  Harare,Zimbabwe 
    ///  Company : Telthemweb 
    ///  www.innotauzeni.co.zw
    ///  Date: 28/09/2022
    ///  
    /// Note: defining the Interface is a core part to provide all options to the Data Access Layer.
    /// </summary>
    public interface ITelIDbProvider
    {
        IDbConnection Connection(string connectionString);

        IDbCommand Command(string cmdText, IDbConnection conn);

        IDbDataAdapter DataAdapter(IDbCommand command);

        

        
    }
}
