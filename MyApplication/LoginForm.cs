using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Text =
                usernameTextBox.Text.Replace(" ", string.Empty);

            passwordTextBox.Text =
                passwordTextBox.Text.Replace(" ", string.Empty);

            if(string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Username And Password is Required");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                Models.User foundedUser =
                    databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox
                        .Show("Wrong Username And/Or Password");

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(passwordTextBox.
                    Text, foundedUser.Password, false) != 0)
                {
                    System.Windows.Forms.MessageBox
                        .Show("Wrong Username And/Or Password");

                    usernameTextBox.Focus();

                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("Your Account is not ACTIVE Please Contact Suport For more Help");

                    usernameTextBox.Focus();

                    return;
                }

                System.Windows.Forms.MessageBox.Show("خوش آمدید");

                Infrastructure.Utility.AuthenticatedUser = foundedUser;

                Hide();

                Infrastructure.Utility.MainForm.ResetText();

                Infrastructure.Utility.MainForm.Show();

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
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Infrastructure.Utility.RegisterForm.ResetForm();
            Infrastructure.Utility.RegisterForm.Show();
        }

        public void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            usernameTextBox.Focus();
        }
        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
