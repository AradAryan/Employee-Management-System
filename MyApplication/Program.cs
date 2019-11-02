using System.Linq;

namespace MyApplication
{
    internal static class Program
    {
        static Program()
        {
        }

        [System.STAThread]
        internal static void Main()
        {

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            #region Database Context
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                bool hasAnyUser =
                    databaseContext.Users
                    .Any();

                if (hasAnyUser == false)
                {
                    Models.User adminUser = new Models.User
                    {
                        IsAdmin = true,
                        IsActive = true,

                        Username = "crazyleader",
                        Password = "1711502019",
                        FullName = "Arad Aryan",
                    };

                    databaseContext.Users.Add(adminUser);

                    databaseContext.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                return;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
            #endregion Database Context

            System.Windows.Forms.Application.Run(Infrastructure.Utility.SplashScreenForm);

        }
    }
}
