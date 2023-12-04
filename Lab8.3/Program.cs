namespace Lab8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of tech product:");
            int choice = Convert.ToInt32(Console.ReadLine());

            IComponentFactory componentFactory;

            switch (choice)
            {
                case 1:
                    componentFactory = new ComponentFactory();
                    break;
                default:
                    throw new InvalidOperationException("Error");
            }

            TechProduct techProduct = new TechProduct(componentFactory);
            techProduct.Assemble();
        }
    }
}