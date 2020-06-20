using System.Data;
using System.Data.SqlClient;

namespace NetPaternContinue.App.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var con = new SqlConnection("User Id = root; Password =; Server = localhost; Database = banco");
            con.Open();

            return con;
        }
    }
}
