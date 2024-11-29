using Npgsql;

namespace LancementLoginDB
{
  public class DBSignUpSignIn
  {
    public NpgsqlConnection ConnectToDb()
    {
      //Set TempUser + Password to DB
      var connectionString = "Host=pg-309a4596-jimguillaume99-appcreationcompte.b.aivencloud.com;Port=26257;Username=avnadmin;Password=AVNS_KdDnmlQQIDbFzQR8iPA;Database=defaultdb";
      NpgsqlConnection conn = new(connectionString);

      //Open the Db Connection
      conn.Open();

      return conn;
    }

    private static void DisconnectFromDb()
    {
      //Set TempUser + Password to DB
      var connectionString = "Host=pg-309a4596-jimguillaume99-appcreationcompte.b.aivencloud.com;Username=temporaryUser;Password=AVNS_S8h-B3s6-s70FZUPUEx;Database=defaultdb";
      NpgsqlConnection conn = new(connectionString);

      //Close the Db Connection
      conn.Close();

    }

    public void UserSignUp(string UID, string Password, string eMail)
    {

      //SIGNUP USER INTO USERLIST
      string SignUpQuery = "INSERT INTO public.UserList (username, email) VALUES(@UID, @eMail)";
      using NpgsqlCommand cmd = new(SignUpQuery, ConnectToDb());
      cmd.Parameters.AddWithValue("@UID", UID);
      cmd.Parameters.AddWithValue("@eMail", eMail);
      cmd.ExecuteNonQuery();
    }

    private void UserPasswordSignUp(string UID, string Password)
    {
      string UserPasswordSignUp = "INSERT INTO public.PasswordList() VALUES()";
      using (NpgsqlCommand cmd = new NpgsqlCommand(UserPasswordSignUp, ConnectToDb()))
      {
        cmd.Parameters.AddWithValue("@UID", UID);
        //TODO ADD FCT THAT HASH THE PASSWORD
        /*  cmd.Parameters.AddWithValue("@Password", HashPASSWORD);
          cmd.Parameters.AddWithValue("@Hash", GetHash ); */
      }
    }


    public void UserLogIn(string UID, string Password)
    {
      string SignInQuery = "SELECT * FROM public.usersList(username, password) WHERE username = '@UID' AND password = '@Password'";
      using NpgsqlCommand cmd = new(SignInQuery, ConnectToDb());
      cmd.Parameters.AddWithValue("@UID", UID);
      cmd.Parameters.AddWithValue("@Password", Password);
    }
  }
}
