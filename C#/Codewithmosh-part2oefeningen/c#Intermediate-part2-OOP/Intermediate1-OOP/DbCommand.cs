using System;

namespace Intermediate1_OOP
{
    internal partial class Program
    {
        public class DbCommand
        {
            private readonly DbConnection _connection;
            private readonly string _Instruction;

            public DbCommand(DbConnection connection, string instruction)
            {
                _connection = connection ?? throw new ArgumentException(nameof(connection));
                _Instruction = !string.IsNullOrEmpty(instruction) ? instruction : throw new ArgumentException(nameof(instruction));
            }

            public void Execute()
            {
                _connection.open();
                Console.WriteLine($"Executing instarction: {_Instruction}");
            }
        }

    }
}
