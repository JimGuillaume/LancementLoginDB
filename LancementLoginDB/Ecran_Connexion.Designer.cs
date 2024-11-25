namespace LancementLoginDB
{
    partial class UserAccountForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountForm));
      LogInButton = new Button();
      RegisterButton = new Button();
      LogGroupBox = new GroupBox();
      UserConnectGroupbox = new GroupBox();
      PaswdLoginLabel = new Label();
      UIDLoginLabel = new Label();
      UserLoginButton = new Button();
      UserPsswTextBox = new TextBox();
      UserIdTextBox = new TextBox();
      UserRegisterGroupBox = new GroupBox();
      EmailRegisterLabel = new Label();
      PswRegisterdLabel = new Label();
      UIDRegisterLabel = new Label();
      UserRegisterButton = new Button();
      UserEmailRegisterTextBox = new TextBox();
      UserPswdRegisterTextBox = new TextBox();
      UserIdRegisterTextBox = new TextBox();
      LogGroupBox.SuspendLayout();
      UserConnectGroupbox.SuspendLayout();
      UserRegisterGroupBox.SuspendLayout();
      SuspendLayout();
      // 
      // LogInButton
      // 
      LogInButton.Location = new Point(69, 130);
      LogInButton.Name = "LogInButton";
      LogInButton.Size = new Size(166, 57);
      LogInButton.TabIndex = 0;
      LogInButton.Text = "Connexion";
      LogInButton.UseVisualStyleBackColor = true;
      LogInButton.Click += LogInButton_Click;
      // 
      // RegisterButton
      // 
      RegisterButton.Location = new Point(69, 32);
      RegisterButton.Name = "RegisterButton";
      RegisterButton.Size = new Size(166, 57);
      RegisterButton.TabIndex = 1;
      RegisterButton.Text = "Enregistrement";
      RegisterButton.UseVisualStyleBackColor = true;
      RegisterButton.Click += RegisterButton_Click;
      // 
      // LogGroupBox
      // 
      LogGroupBox.Controls.Add(RegisterButton);
      LogGroupBox.Controls.Add(LogInButton);
      LogGroupBox.Location = new Point(47, 61);
      LogGroupBox.Name = "LogGroupBox";
      LogGroupBox.Size = new Size(304, 213);
      LogGroupBox.TabIndex = 2;
      LogGroupBox.TabStop = false;
      // 
      // UserConnectGroupbox
      // 
      UserConnectGroupbox.Controls.Add(PaswdLoginLabel);
      UserConnectGroupbox.Controls.Add(UIDLoginLabel);
      UserConnectGroupbox.Controls.Add(UserLoginButton);
      UserConnectGroupbox.Controls.Add(UserPsswTextBox);
      UserConnectGroupbox.Controls.Add(UserIdTextBox);
      UserConnectGroupbox.Location = new Point(47, 61);
      UserConnectGroupbox.Name = "UserConnectGroupbox";
      UserConnectGroupbox.Size = new Size(304, 213);
      UserConnectGroupbox.TabIndex = 3;
      UserConnectGroupbox.TabStop = false;
      UserConnectGroupbox.Visible = false;
      // 
      // PaswdLoginLabel
      // 
      PaswdLoginLabel.AutoSize = true;
      PaswdLoginLabel.Location = new Point(114, 87);
      PaswdLoginLabel.Name = "PaswdLoginLabel";
      PaswdLoginLabel.Size = new Size(77, 15);
      PaswdLoginLabel.TabIndex = 4;
      PaswdLoginLabel.Text = "Mot de passe";
      // 
      // UIDLoginLabel
      // 
      UIDLoginLabel.AutoSize = true;
      UIDLoginLabel.Location = new Point(107, 37);
      UIDLoginLabel.Name = "UIDLoginLabel";
      UIDLoginLabel.Size = new Size(90, 15);
      UIDLoginLabel.TabIndex = 3;
      UIDLoginLabel.Text = "Nom Utilisateur";
      // 
      // UserLoginButton
      // 
      UserLoginButton.Location = new Point(59, 152);
      UserLoginButton.Name = "UserLoginButton";
      UserLoginButton.Size = new Size(186, 35);
      UserLoginButton.TabIndex = 2;
      UserLoginButton.Text = "Se connecter";
      UserLoginButton.UseVisualStyleBackColor = true;
      // 
      // UserPsswTextBox
      // 
      UserPsswTextBox.Location = new Point(59, 107);
      UserPsswTextBox.Name = "UserPsswTextBox";
      UserPsswTextBox.Size = new Size(186, 23);
      UserPsswTextBox.TabIndex = 1;
      UserPsswTextBox.TextAlign = HorizontalAlignment.Center;
      UserPsswTextBox.UseSystemPasswordChar = true;
      UserPsswTextBox.TextChanged += UserPsswTextBox_TextChanged;
      UserPsswTextBox.Enter += EnterTextBox;
      UserPsswTextBox.Leave += LeaveTextBox;
      // 
      // UserIdTextBox
      // 
      UserIdTextBox.Location = new Point(59, 53);
      UserIdTextBox.Name = "UserIdTextBox";
      UserIdTextBox.Size = new Size(186, 23);
      UserIdTextBox.TabIndex = 0;
      UserIdTextBox.TextAlign = HorizontalAlignment.Center;
      UserIdTextBox.TextChanged += UserIdTextBox_TextChanged;
      UserIdTextBox.Enter += EnterTextBox;
      UserIdTextBox.Leave += LeaveTextBox;
      // 
      // UserRegisterGroupBox
      // 
      UserRegisterGroupBox.Controls.Add(EmailRegisterLabel);
      UserRegisterGroupBox.Controls.Add(PswRegisterdLabel);
      UserRegisterGroupBox.Controls.Add(UIDRegisterLabel);
      UserRegisterGroupBox.Controls.Add(UserRegisterButton);
      UserRegisterGroupBox.Controls.Add(UserEmailRegisterTextBox);
      UserRegisterGroupBox.Controls.Add(UserPswdRegisterTextBox);
      UserRegisterGroupBox.Controls.Add(UserIdRegisterTextBox);
      UserRegisterGroupBox.Location = new Point(47, 64);
      UserRegisterGroupBox.Name = "UserRegisterGroupBox";
      UserRegisterGroupBox.Size = new Size(304, 206);
      UserRegisterGroupBox.TabIndex = 4;
      UserRegisterGroupBox.TabStop = false;
      UserRegisterGroupBox.Visible = false;
      // 
      // EmailRegisterLabel
      // 
      EmailRegisterLabel.AutoSize = true;
      EmailRegisterLabel.Location = new Point(76, 120);
      EmailRegisterLabel.Name = "EmailRegisterLabel";
      EmailRegisterLabel.Size = new Size(80, 15);
      EmailRegisterLabel.TabIndex = 6;
      EmailRegisterLabel.Text = "Adresse eMail";
      // 
      // PswRegisterdLabel
      // 
      PswRegisterdLabel.AutoSize = true;
      PswRegisterdLabel.Location = new Point(77, 73);
      PswRegisterdLabel.Name = "PswRegisterdLabel";
      PswRegisterdLabel.Size = new Size(77, 15);
      PswRegisterdLabel.TabIndex = 5;
      PswRegisterdLabel.Text = "Mot de passe";
      // 
      // UIDRegisterLabel
      // 
      UIDRegisterLabel.AutoSize = true;
      UIDRegisterLabel.Location = new Point(66, 27);
      UIDRegisterLabel.Name = "UIDRegisterLabel";
      UIDRegisterLabel.Size = new Size(99, 15);
      UIDRegisterLabel.TabIndex = 4;
      UIDRegisterLabel.Text = "Nom d'utilisateur";
      // 
      // UserRegisterButton
      // 
      UserRegisterButton.Location = new Point(214, 76);
      UserRegisterButton.Name = "UserRegisterButton";
      UserRegisterButton.Size = new Size(75, 46);
      UserRegisterButton.TabIndex = 3;
      UserRegisterButton.Text = "Créer un compte";
      UserRegisterButton.UseVisualStyleBackColor = true;
      UserRegisterButton.Click += UserRegisterButton_Click;
      // 
      // UserEmailRegisterTextBox
      // 
      UserEmailRegisterTextBox.Location = new Point(23, 137);
      UserEmailRegisterTextBox.Name = "UserEmailRegisterTextBox";
      UserEmailRegisterTextBox.Size = new Size(185, 23);
      UserEmailRegisterTextBox.TabIndex = 2;
      UserEmailRegisterTextBox.TextAlign = HorizontalAlignment.Center;
      UserEmailRegisterTextBox.Enter += EnterTextBox;
      UserEmailRegisterTextBox.Leave += LeaveTextBox;
      // 
      // UserPswdRegisterTextBox
      // 
      UserPswdRegisterTextBox.Location = new Point(22, 89);
      UserPswdRegisterTextBox.Name = "UserPswdRegisterTextBox";
      UserPswdRegisterTextBox.Size = new Size(186, 23);
      UserPswdRegisterTextBox.TabIndex = 1;
      UserPswdRegisterTextBox.TextAlign = HorizontalAlignment.Center;
      UserPswdRegisterTextBox.UseSystemPasswordChar = true;
      UserPswdRegisterTextBox.TextChanged += UserPswdRegisterTextBox_TextChanged;
      UserPswdRegisterTextBox.Enter += EnterTextBox;
      UserPswdRegisterTextBox.Leave += LeaveTextBox;
      // 
      // UserIdRegisterTextBox
      // 
      UserIdRegisterTextBox.Location = new Point(22, 45);
      UserIdRegisterTextBox.Name = "UserIdRegisterTextBox";
      UserIdRegisterTextBox.Size = new Size(186, 23);
      UserIdRegisterTextBox.TabIndex = 0;
      UserIdRegisterTextBox.TextAlign = HorizontalAlignment.Center;
      UserIdRegisterTextBox.Enter += EnterTextBox;
      UserIdRegisterTextBox.Leave += LeaveTextBox;
      // 
      // UserAccountForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(398, 334);
      Controls.Add(UserConnectGroupbox);
      Controls.Add(UserRegisterGroupBox);
      Controls.Add(LogGroupBox);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "UserAccountForm";
      Text = "Connexion";
      LogGroupBox.ResumeLayout(false);
      UserConnectGroupbox.ResumeLayout(false);
      UserConnectGroupbox.PerformLayout();
      UserRegisterGroupBox.ResumeLayout(false);
      UserRegisterGroupBox.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Button LogInButton;
    private Button RegisterButton;
    private GroupBox LogGroupBox;
    private GroupBox UserConnectGroupbox;
    private TextBox UserIdTextBox;
    private TextBox UserPsswTextBox;
    private GroupBox UserRegisterGroupBox;
    private TextBox UserIdRegisterTextBox;
    private Button UserLoginButton;
    private Button UserRegisterButton;
    private TextBox UserEmailRegisterTextBox;
    private TextBox UserPswdRegisterTextBox;
    private Label UIDRegisterLabel;
    private Label PswRegisterdLabel;
    private Label EmailRegisterLabel;
    private Label UIDLoginLabel;
    private Label PaswdLoginLabel;
  }
}
