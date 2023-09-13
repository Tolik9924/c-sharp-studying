using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SqlConnection : Dbconnection
    {

        public SqlConnection(string connection, string typeDb) 
            : base(connection, typeDb)
        {

        }
        public override void Openning()
        {
            Console.WriteLine("Openning SqlConnection.");
            isExecuted = true;
        }

        public override void Closenning()
        {
            Console.WriteLine($"Closenning SqlConnection. {_timeout}");
            isExecuted = false;
        }

        public override void Execute()
        {
            if (!isExecuted)
                throw new InvalidOperationException("Program is not executed");

            Console.WriteLine("Sql database is executing");
        }
    }

    public class OracleConnection : Dbconnection
    {
        public OracleConnection(string connection, string typeDb) 
            : base(connection, typeDb)
        {

        }

        public override void Openning()
        {
            Console.WriteLine("Openning OracleConnection.");
            isExecuted = true;
        }

        public override void Closenning()
        {
            Console.WriteLine($"Closenning OracleConnection. {_timeout}");
            isExecuted = false;
        }

        public override void Execute()
        {
            if (!isExecuted)
                throw new InvalidOperationException("Program is not executed");

            Console.WriteLine("Oracle database is executing");
        }
    }
    public abstract class Dbconnection
    {
        private string ConnectionString;
        protected TimeSpan _timeout;
        protected bool isExecuted = false;
        private string _connection;
        private string _typeDb;



        public Dbconnection(string connection, string typeDb)
        {
            if (String.IsNullOrEmpty(connection))
            {
                throw new InvalidOperationException("Connection must not be Null or Empty.");
            }
            _connection = connection;
            _typeDb = typeDb;
        }

        public abstract void Openning();
        public abstract void Closenning();
        public abstract void Execute();
    }
}
