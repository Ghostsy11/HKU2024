namespace Intermediate1_OOP
{

    internal partial class Program
    {
        public class Dbmigrator
        {
            private readonly Logger _logger;

            public Dbmigrator(Logger logger)
            {
                this._logger = logger;
            }

            public void Migrate()
            {
                _logger.log("We are migrating");
            }
        }

    }
}
