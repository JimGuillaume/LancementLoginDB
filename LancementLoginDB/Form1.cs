namespace LancementLoginDB
{
  public partial class UserAccountForm : Form
  {

    private List<UserSignUp> SendUserAccount = [];
    public UserAccountForm()
    {
      InitializeComponent();
    }

    private void LogInButton_Click(object sender, EventArgs e)
    {
      this.LogGroupBox.Visible = false;
      this.UserConnectGroupbox.Visible = true;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
      this.LogGroupBox.Visible = false;
      this.UserRegisterGroupBox.Visible = true;

    }

    private void UserIdTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void UserPsswTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void LogGroupBox_Enter(object sender, EventArgs e)
    {

    }

    private void UserRegisterButton_Click(object sender, EventArgs e)
    {
      try
      {
        UserSignUp inter_user = new UserSignUp();

        inter_user.Set_UID(this.UserIdRegisterTextBox.Text);
        inter_user.Set_UPSWD(this.UserPswdRegisterTextBox.Text);
        inter_user.Set_UMail(this.UserEmailRegisterTextBox.Text);

        this.SendUserAccount.Add(inter_user);
      }
      catch (UserSignUpException exc)
      {
        MessageBox.Show(exc.message, "ERREUR ENCODAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        switch(exc.errorCode)
        {
          case 1:
          case 2:
          case 3:
            this.UserIdRegisterTextBox.Focus();
            this.UserIdRegisterTextBox.SelectAll();
            break;

          case 4:
          case 5:
          case 6:
            this.UserPswdRegisterTextBox.Focus();
            this.UserPswdRegisterTextBox.SelectAll();
            break;

        }
      }

    }
  }
}
