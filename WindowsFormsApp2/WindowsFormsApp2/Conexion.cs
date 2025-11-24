using System.Configuration;
using System.Data.SqlClient;

public static class Conexion
{
    public static SqlConnection GetConnection()
    {
        string cnx = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        return new SqlConnection(cnx);
    }
}