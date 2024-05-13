using PFA_Project.UI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System;
using System.Xml.Linq;

namespace PFA_Project
{

    internal static class Program
    {
    


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Subscribe to the ThreadException event
                Application.ThreadException += Application_ThreadException;
                // Subscribe to the UnhandledException event
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


            // Path to the XML file containing the connection string
            string filePath = "path_to_directory/connectionSettings.xml";

            // Read the XML file
            XDocument doc = XDocument.Load(filePath);

            // Extract the connection string
            string connectionString = doc.Root.Element("ConnectionString").Value;



            #region DBConnection
            var services = new ServiceCollection();
            services.AddDbContext<PFAdbContext>(options =>
                options.UseSqlServer(connectionString));
                //options.UseSqlServer(connectionString));
            #endregion


            // Add other services if needed
            var serviceProvider = services.BuildServiceProvider();
            //Application.Run(new frmHome(serviceProvider.GetRequiredService<PFAdbContext>()));
            Application.Run(new frmLogin(serviceProvider.GetRequiredService<PFAdbContext>()));
                //Application.Run(new frmRegister(serviceProvider.GetRequiredService<PFAdbContext>()));
                //Application.Run(new frmFundRecived(serviceProvider.GetRequiredService<PFAdbContext>()));

                // Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmExpensess(serviceProvider.GetRequiredService<PFAdbContext>()));
                //Application.Run(new frmFundRecived(serviceProvider.GetRequiredService<PFAdbContext>()));



                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                //ApplicationConfiguration.Initialize();

                // Application.Run(new frmLogin());
                //  Application.Run(new frmFundRecived()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                //throw;
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Handle the exception
            HandleException(e.Exception);
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Handle the exception
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception exception)
        {
            // Log the exception, display error message, etc.
            MessageBox.Show($"An unexpected error occurred: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, you can exit the application
            // Application.Exit();
        }

    }
}