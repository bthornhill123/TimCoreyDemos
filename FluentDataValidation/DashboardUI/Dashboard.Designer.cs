namespace DashboardUI
{
  partial class Dashboard
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
      this.headerLabel = new System.Windows.Forms.Label();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.firstNameText = new System.Windows.Forms.TextBox();
      this.lastNameText = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.accountBalanceText = new System.Windows.Forms.TextBox();
      this.accountBalanceLabel = new System.Windows.Forms.Label();
      this.dateOfBirthLabel = new System.Windows.Forms.Label();
      this.createButton = new System.Windows.Forms.Button();
      this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
      this.errorListBox = new System.Windows.Forms.ListBox();
      this.errorListLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Open Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.Location = new System.Drawing.Point(38, 44);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(212, 47);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Create User";
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Location = new System.Drawing.Point(78, 135);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(134, 33);
      this.firstNameLabel.TabIndex = 1;
      this.firstNameLabel.Text = "First Name";
      // 
      // firstNameText
      // 
      this.firstNameText.Location = new System.Drawing.Point(282, 132);
      this.firstNameText.Name = "firstNameText";
      this.firstNameText.Size = new System.Drawing.Size(214, 40);
      this.firstNameText.TabIndex = 2;
      // 
      // lastNameText
      // 
      this.lastNameText.Location = new System.Drawing.Point(283, 178);
      this.lastNameText.Name = "lastNameText";
      this.lastNameText.Size = new System.Drawing.Size(214, 40);
      this.lastNameText.TabIndex = 4;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Location = new System.Drawing.Point(79, 181);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(131, 33);
      this.lastNameLabel.TabIndex = 3;
      this.lastNameLabel.Text = "Last Name";
      // 
      // accountBalanceText
      // 
      this.accountBalanceText.Location = new System.Drawing.Point(282, 224);
      this.accountBalanceText.Name = "accountBalanceText";
      this.accountBalanceText.Size = new System.Drawing.Size(214, 40);
      this.accountBalanceText.TabIndex = 6;
      // 
      // accountBalanceLabel
      // 
      this.accountBalanceLabel.AutoSize = true;
      this.accountBalanceLabel.Location = new System.Drawing.Point(79, 227);
      this.accountBalanceLabel.Name = "accountBalanceLabel";
      this.accountBalanceLabel.Size = new System.Drawing.Size(197, 33);
      this.accountBalanceLabel.TabIndex = 5;
      this.accountBalanceLabel.Text = "Account Balance";
      // 
      // dateOfBirthLabel
      // 
      this.dateOfBirthLabel.AutoSize = true;
      this.dateOfBirthLabel.Location = new System.Drawing.Point(79, 276);
      this.dateOfBirthLabel.Name = "dateOfBirthLabel";
      this.dateOfBirthLabel.Size = new System.Drawing.Size(155, 33);
      this.dateOfBirthLabel.TabIndex = 7;
      this.dateOfBirthLabel.Text = "Date of Birth";
      // 
      // createButton
      // 
      this.createButton.Location = new System.Drawing.Point(185, 333);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(214, 72);
      this.createButton.TabIndex = 9;
      this.createButton.Text = "Create";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // dateOfBirthPicker
      // 
      this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateOfBirthPicker.Location = new System.Drawing.Point(283, 270);
      this.dateOfBirthPicker.Name = "dateOfBirthPicker";
      this.dateOfBirthPicker.Size = new System.Drawing.Size(214, 40);
      this.dateOfBirthPicker.TabIndex = 10;
      // 
      // errorListBox
      // 
      this.errorListBox.FormattingEnabled = true;
      this.errorListBox.ItemHeight = 33;
      this.errorListBox.Location = new System.Drawing.Point(551, 132);
      this.errorListBox.Name = "errorListBox";
      this.errorListBox.Size = new System.Drawing.Size(542, 235);
      this.errorListBox.TabIndex = 11;
      // 
      // errorListLabel
      // 
      this.errorListLabel.AutoSize = true;
      this.errorListLabel.Location = new System.Drawing.Point(545, 96);
      this.errorListLabel.Name = "errorListLabel";
      this.errorListLabel.Size = new System.Drawing.Size(115, 33);
      this.errorListLabel.TabIndex = 1;
      this.errorListLabel.Text = "Error List";
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1105, 464);
      this.Controls.Add(this.errorListBox);
      this.Controls.Add(this.dateOfBirthPicker);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.dateOfBirthLabel);
      this.Controls.Add(this.accountBalanceText);
      this.Controls.Add(this.accountBalanceLabel);
      this.Controls.Add(this.lastNameText);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.firstNameText);
      this.Controls.Add(this.errorListLabel);
      this.Controls.Add(this.firstNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.Name = "Dashboard";
      this.Text = "Fluent Validation Demo by Tim Corey";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.TextBox firstNameText;
    private System.Windows.Forms.TextBox lastNameText;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox accountBalanceText;
    private System.Windows.Forms.Label accountBalanceLabel;
    private System.Windows.Forms.Label dateOfBirthLabel;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
    private System.Windows.Forms.ListBox errorListBox;
    private System.Windows.Forms.Label errorListLabel;
  }
}

