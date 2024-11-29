using Npgsql;
using System.Data;

namespace LancementLoginDB
{
  public partial class UserAccountForm : Form
  {

    public UserAccountForm()
    {
      InitializeComponent();
    }

    private void LogInButton_Click(object sender, EventArgs e)
    {
      this.LogGroupBox.Visible = false;
      this.UserConnectGroupbox.Visible = true;
      AfficherDataGrid(UserLogInDataGridView);
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
      this.LogGroupBox.Visible = false;
      this.UserRegisterGroupBox.Visible = true;
      AfficherDataGrid(UserSignUpDataGridView);

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
        UserSignUp inter_user = new();


        //  GESTION TEMPORAIRE DE  LUTILISATEUR
        inter_user.Set_UID(this.UserIdRegisterTextBox.Text);
        inter_user.Set_UPSWD(this.UserPswdRegisterTextBox.Text);
        inter_user.Set_UMail(this.UserEmailRegisterTextBox.Text);


        //CREATION DE L UTILISATEUR SUR LA DB
        DBSignUpSignIn dBSignUpSignIn = new();
        dBSignUpSignIn.UserSignUp(inter_user.Get_UID(), inter_user.Get_UPSWD(), inter_user.Get_UMail());

        //CLEAR DES CHAMPS TEXTUELS
        this.UserIdRegisterTextBox.Clear();
        this.UserPswdRegisterTextBox.Clear();
        this.UserEmailRegisterTextBox.Clear();
      }
      catch (UserSignUpException exc)
      {
        MessageBox.Show(exc.message, "ERREUR ENCODAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        switch (exc.errorCode)
        {
          case 1:
          case 2:
          case 3:
            this.UserIdRegisterTextBox.Focus();
            this.UserIdRegisterTextBox.SelectAll();
            this.UserIdRegisterTextBox.BackColor = Color.LightPink;
            break;

          case 10:
          case 11:
            this.UserPswdRegisterTextBox.Focus();
            this.UserPswdRegisterTextBox.SelectAll();
            this.UserPswdRegisterTextBox.BackColor = Color.LightPink;
            break;

          case 20:
          case 21:
            this.UserEmailRegisterTextBox.Focus();
            this.UserEmailRegisterTextBox.SelectAll();
            this.UserEmailRegisterTextBox.BackColor = Color.LightPink;
            break;

          default:
            MessageBox.Show("Error 1C", "ERREUR ENCODAGE INSCRIPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            break;
        }
      }
      AfficherDataGrid(UserSignUpDataGridView);

    }

    private void UserPswdRegisterTextBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void EnterTextBox(object sender, EventArgs e)
    {
      if (sender is TextBox box)
      {
        box.BackColor = Color.AliceBlue;
      }
    }
    private void LeaveTextBox(object sender, EventArgs e)
    {
      if (sender is TextBox box)
      {
        box.BackColor = Color.White;

      }
    }


    //Connexion a la DB Suivie d'une mise a jour des utilisateurs & eMail dans le DataGridView
    private void AfficherDataGrid(DataGridView DataGrid)
    {
      DBSignUpSignIn dBSignUpSignIn = new();
      DataTable DbSource = new();
      

      string SignInQuery = "SELECT username, email FROM public.UserList";
      using NpgsqlCommand cmd = new(SignInQuery, dBSignUpSignIn.ConnectToDb());

      NpgsqlDataAdapter adapter = new(cmd);
      adapter.Fill(DbSource);
      DataGrid.DataSource = DbSource;
    }

    private void RetourMenuConnexionButton(object sender, EventArgs e)
    {
      this.UserRegisterGroupBox.Visible = false;
      this.UserConnectGroupbox.Visible = false;
      this.LogGroupBox.Visible = true;
    }
  }
}
