using System.Data.SqlClient;

namespace CarRentalSystem.Cashier
{
    internal class MysqlDataAdapter
    {
        private SqlConnection con;

        public MysqlDataAdapter(SqlConnection con)
        {
            this.con = con;
        }
    }
}