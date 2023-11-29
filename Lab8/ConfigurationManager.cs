using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private string loggingMode;
        private string databaseConnection;

        private ConfigurationManager()
        {
            loggingMode = "DefaultLogging";
            databaseConnection = "DefaultConnection";
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine($"Logging Mode: {loggingMode}");
            }
        }

        public string DatabaseConnection
        {
            get { return databaseConnection; }
            set
            {
                databaseConnection = value;
                Console.WriteLine($"Database Connection: {databaseConnection}");
            }
        }

        public void SaveConfiguration()
        {
            Console.WriteLine("Configuration saved.");
        }
    }
}
