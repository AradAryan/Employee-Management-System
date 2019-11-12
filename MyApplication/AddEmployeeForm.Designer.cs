namespace MyApplication
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nationalCodeLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.nationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.marriedRadioButton = new System.Windows.Forms.RadioButton();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.myPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "&Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(29, 43);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "&Last Name:";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(15, 72);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(86, 13);
            this.employeeIDLabel.TabIndex = 4;
            this.employeeIDLabel.Text = "&Employee ID:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(67, 183);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(34, 13);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "&Age:";
            // 
            // nationalCodeLabel
            // 
            this.nationalCodeLabel.AutoSize = true;
            this.nationalCodeLabel.Location = new System.Drawing.Point(9, 101);
            this.nationalCodeLabel.Name = "nationalCodeLabel";
            this.nationalCodeLabel.Size = new System.Drawing.Size(92, 13);
            this.nationalCodeLabel.TabIndex = 6;
            this.nationalCodeLabel.Text = "&National Code:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(47, 128);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 13);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "&Gender:";
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoSize = true;
            this.maritalStatusLabel.Location = new System.Drawing.Point(11, 156);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(90, 13);
            this.maritalStatusLabel.TabIndex = 11;
            this.maritalStatusLabel.Text = "&Marital Status:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(110, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(132, 21);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(110, 69);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(132, 21);
            this.employeeIDTextBox.TabIndex = 5;
            // 
            // nationalCodeTextBox
            // 
            this.nationalCodeTextBox.Location = new System.Drawing.Point(110, 101);
            this.nationalCodeTextBox.Name = "nationalCodeTextBox";
            this.nationalCodeTextBox.Size = new System.Drawing.Size(132, 21);
            this.nationalCodeTextBox.TabIndex = 7;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(110, 129);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.maleRadioButton.TabIndex = 9;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "&Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(176, 129);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(66, 17);
            this.femaleRadioButton.TabIndex = 10;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "&Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Location = new System.Drawing.Point(110, 156);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(60, 17);
            this.singleRadioButton.TabIndex = 12;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "&Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // marriedRadioButton
            // 
            this.marriedRadioButton.AutoSize = true;
            this.marriedRadioButton.Location = new System.Drawing.Point(176, 156);
            this.marriedRadioButton.Name = "marriedRadioButton";
            this.marriedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.marriedRadioButton.TabIndex = 13;
            this.marriedRadioButton.TabStop = true;
            this.marriedRadioButton.Text = "&Married";
            this.marriedRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(110, 181);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(51, 21);
            this.ageNumericUpDown.TabIndex = 15;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // myPanel
            // 
            this.myPanel.Location = new System.Drawing.Point(107, 152);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(142, 23);
            this.myPanel.TabIndex = 18;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 216);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(155, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(261, 255);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.marriedRadioButton);
            this.Controls.Add(this.singleRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.nationalCodeTextBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.maritalStatusLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nationalCodeLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.myPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployeeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nationalCodeLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label maritalStatusLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox nationalCodeTextBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.RadioButton marriedRadioButton;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
