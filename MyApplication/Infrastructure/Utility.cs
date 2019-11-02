namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        {
        }

        public static Models.User AuthenticatedUser { get; set; }

        private static MyApplication.LoginForm loginForm;

        //<summery>
        // Lazy Loading = Lazy Initialization
        //<summery>
        public static MyApplication.LoginForm LoginForm
        {
            get
            {
                if ((loginForm == null) 
                    || (loginForm.IsDisposed))
                {
                    loginForm =
                        new MyApplication.LoginForm();
                }

                return loginForm;

            }
        }

        private static MyApplication.RegisterForm registerForm;

        //<summery>
        // Lazy Loading = Lazy Initialization
        //<summery>
        public static MyApplication.RegisterForm RegisterForm
        {
            get
            {
                if ((registerForm == null)
                    || (registerForm.IsDisposed))
                {
                    registerForm =
                        new MyApplication.RegisterForm();
                }

                return registerForm;
            }
        }

        private static MyApplication.MainForm mainForm;

        //<summery>
        // Lazy Loading = Lazy Initialization
        //<summery>
        public static MyApplication.MainForm MainForm
        {
            get
            {
                if ((mainForm == null) 
                    || (mainForm.IsDisposed))
                {
                    mainForm =
                        new MyApplication.MainForm();
                }

                return mainForm;

            }
        }

        private static MyApplication.SplashScreenForm splashScreenForm;

        //<summery>
        // Lazy Loading = Lazy Initialization
        //<summery>
        public static MyApplication.SplashScreenForm SplashScreenForm
        {
            get
            {
                if ((splashScreenForm == null
                    || splashScreenForm.IsDisposed))
                {
                    splashScreenForm =
                        new MyApplication.SplashScreenForm();
                }

                return splashScreenForm;

            }
        }
    }
}
