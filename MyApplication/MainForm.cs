using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timeToolStripMenuLable.Text 
                = DateTime.Now.ToString();

            if (String.IsNullOrEmpty(Infrastructure
                .Utility.AuthenticatedUser.FullName))
                usernameWelcomeToolStripLable.Text 
                    = Infrastructure.Utility.AuthenticatedUser.FullName;

            else usernameWelcomeToolStripLable.Text
                    = Infrastructure.Utility.AuthenticatedUser.Username;
        }
    }
}
