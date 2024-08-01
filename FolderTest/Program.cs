namespace FolderTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //var averagePrice = context.Products
            //                          .Where(p => p.DateAdded >= startDate && p.DateAdded <= endDate)
            //                          .Average(p => p.Price);

        }
    }
}