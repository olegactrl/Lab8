namespace Lab8_2_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the type of chart (line, bar, pie):");
            string chartType = Console.ReadLine();

            Console.WriteLine("Enter data for visualization:");

            try
            {
                IChart chart = new GraphFactory().CreateChart(chartType);
                chart.Draw();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}