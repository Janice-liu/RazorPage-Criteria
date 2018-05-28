using RazorPage.Data.Store;

namespace RazorPage.Data
{
    public interface IConnection
    {
         string GetString();
    }

    public class Connection : IConnection
    {
        public static string _connection = "";

        public Connection(string connection)
        {
            _connection = connection;
        }
        public string GetString() => _connection;
    }

    public sealed class DataContextFactory: IDataContextFactory<Zebra_DBDataContext>
    {
        private readonly IConnection _connection;
        public DataContextFactory(IConnection connection)
        {
            _connection = connection;
        }

        public Zebra_DBDataContext Create()
            =>new Zebra_DBDataContext(_connection.GetString());
    }
}
