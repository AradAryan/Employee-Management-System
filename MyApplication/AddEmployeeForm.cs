using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class AddEmployeeForm : Infrastructure.BaseForm
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
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
                Infrastructure.Utility.AddEmployeeForm.ResetText();
                Infrastructure.Utility.AddEmployeeForm.Hide();
            }

        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
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
                Infrastructure.Utility.AddEmployeeForm.ResetText();
                Infrastructure.Utility.AddEmployeeForm.Hide();
            }
            else
                e.Cancel = true;

        }
    }
}
