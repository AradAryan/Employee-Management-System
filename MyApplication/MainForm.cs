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

        private void addButton_Click(object sender, EventArgs e)
        {
            //Infrastructure.Utility.AddEmployeeForm.MdiParent = this;
            Infrastructure.Utility.AddEmployeeForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result =
               MessageBox.Show(
               caption: "Warning!",
               icon: MessageBoxIcon.Warning,
               buttons: MessageBoxButtons.YesNo,
               text: "Are you Sure Want to Cancel? ",
               defaultButton: MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
    }
}
