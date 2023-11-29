namespace Lab8
{
    class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            Console.WriteLine($"Logging Mode: {configManager.LoggingMode}");
            Console.WriteLine($"Database Connection: {configManager.DatabaseConnection}");

            Console.Write("Enter new Logging Mode: ");
            configManager.LoggingMode = Console.ReadLine();

            Console.Write("Enter new Database Connection: ");
            configManager.DatabaseConnection = Console.ReadLine();
            configManager.SaveConfiguration();

            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            Console.WriteLine($"Logging Mode in another instance: {anotherConfigManager.LoggingMode}");
            Console.WriteLine($"Database Connection in another instance: {anotherConfigManager.DatabaseConnection}");
        }
    }
}