namespace E_Commerce.Presentation
{
    internal static class Program
    {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		public static bool userAuthentication = false;
		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}