using System;
using System.Threading;
using Intermediate1_OOP;
namespace Intermediate1_OOP
{
    internal partial class Program
    {
        public abstract class DbConnection
        {


            private readonly string _connectionString;
            private TimeSpan _timeout;

            public string ConncettionString
            {
                get
                {
                    return _connectionString;
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Connection string cannot be null or empty.", nameof(ConncettionString));
                    }
                }
            }

            public TimeSpan Timeout
            {
                get { return _timeout; }
                set { _timeout = value; }

            }

            private DbConnection(string CONNECTINGstring)
            {
                ConncettionString = CONNECTINGstring;
            }

            public void open()
            {
                VaildateConnection();
                Console.WriteLine($"Opening connection with connection string: {ConncettionString}");
            }

            public void close()
            {
                VaildateConnection();
                Console.WriteLine("Closing connection");

            }

            private void VaildateConnection()
            {
                if (string.IsNullOrEmpty("It should not be null"))
                {
                    throw new ArgumentNullException("Connection string is not set.");
                }

                if (Timeout < TimeSpan.Zero)
                {
                    throw new InvalidOperationException("Timeout cannot be negative.");
                }
            }

            public class SqlConnection : DbConnection
            {

                public SqlConnection(string CONNECTINGstring) : base(CONNECTINGstring)
                {
                    Console.WriteLine("LOGIC0");
                }
            }

            public class OracleConnection : DbConnection
            {
                public OracleConnection(string CONNECTINGstring) : base(CONNECTINGstring)
                {
                    Console.WriteLine("Logic1");
                }
            }
        }
    }
}
