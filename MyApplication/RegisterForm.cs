using System;
using System.Linq;

namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {

            #region Validation

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) 
                || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show("Username And Password Are Required!");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }
                return;
            }

            string errorMessages = string.Empty;

            if (usernameTextBox.Text.Length < 6)
            {
                errorMessages =
                    "Username Must be at Least 6 Characters!";
            }

            if (passwordTextBox.Text.Length < 8)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages +=
                        System.Environment.NewLine;
                }

                errorMessages +=
                    "Password Must be at Least 8 Characters!";
            }

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);

                return;
            }
            #endregion //Validation

            Models.DatabaseContext databaseContext = null;

            usernameTextBox.Text =
               usernameTextBox.Text.Replace(" ", string.Empty);

            passwordTextBox.Text =
                passwordTextBox.Text.Replace(" ", string.Empty);

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User user =
                    databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (user != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("this Username Already exist Please Choose Another one");

                    usernameTextBox.Focus();
                    
                    return;
                }

                user = new Models.User
                {
                    FullName = fullNamTextBox.Text,
                    Password = passwordTextBox.Text,
                    Username = usernameTextBox.Text,

                    IsActive = true,
                };

                databaseContext.Users.Add(user);

                databaseContext.SaveChanges();

                ResetForm();

                System.Windows.Forms.MessageBox.Show("Your Account Successfully Created!");
                }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);

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

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullNamTextBox.Text = string.Empty;
            usernameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Infrastructure.Utility.LoginForm.ResetText();
            Infrastructure.Utility.LoginForm.Show();
        }
    }
}
