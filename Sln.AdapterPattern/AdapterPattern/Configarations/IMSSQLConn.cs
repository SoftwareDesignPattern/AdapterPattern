using System.Data.SqlClient;

namespace AdapterPattern.Configarations
{
    public interface IMSSQLConn
    {
        SqlConnection connMSSQLDB { get; }
    }
}
