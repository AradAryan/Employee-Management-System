using System;
using System.Windows.Forms;
namespace MyApplication
{
    public partial class SplashScreenForm : Infrastructure.BaseForm
    {
        public SplashScreenForm()
        {
            InitializeComponent();

        }

        bool check = true;
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1 && check == true)
            {
                Opacity += 0.1;
                if (Opacity >= 0.9)
                {
                    check = false;
                }
            }

            if (check == false)
            {
                Opacity -= 0.1;
                if (Opacity < 0.1)
                { 
                    Hide();
                    Infrastructure.Utility.LoginForm.Show();
                    splashTimer.Enabled = false;
                }
            }
        }
    }
}
