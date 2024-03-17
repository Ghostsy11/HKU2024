namespace Intermediate1_OOP
{

    internal partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;

            public Installer(Logger logger)
            {
                this._logger = logger;
            }

            public void Install()
            {
                _logger.log("We are Intalling the appliaction");
            }
        }

    }
}
