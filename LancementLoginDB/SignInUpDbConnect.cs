using Npgsql;

namespace LancementLoginDB
{
  public class DBSignUpSignIn
  {


    /* 
     
    Table 1 UserList (
    serial id PK NOT NULL
    username varachar(255) NOT NULL
    email varchar(255) NOT NULL
    )
     
    Table 2 PasswordList (
    username varchar(255) NOT NULL PK
    hashedpassword varchar(255) NOT NULL
    salt varchar(255) NOT NULL
    )
     */

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
      string SignInQuery = "SELECT @UIE FROM public.usersList JOIN public.passwordlist ON public.userlist.username = public.passwordlist.username;";
      using NpgsqlCommand cmd = new(SignInQuery, ConnectToDb());
      {
        cmd.Parameters.AddWithValue("@UID", UID);
      }
      //TODO EXTRAPOLATE DATA FROM THE SELECT TO COMPARE HASHED PASSWORD WITH INPUT PASSWORD
      //TODO LINK TO  FCT THAT HASH PASSWORD
    }
  }
}
