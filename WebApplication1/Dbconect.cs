using System.Data.SqlClient;

namespace WebApplication1
{
    public class Dbconect
    {
        public SqlConnection conect()
        {
            string connectionString = "Server=localhost;Database=Test;Trusted_Connection=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
