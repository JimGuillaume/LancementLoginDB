using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancementLoginDB
{
  public class DBSignUpSignIn
  {
    private NpgsqlConnection ConnectToDb()
    {
      //Set TempUser + Password to DB
      var connectionString = "Host=pg-309a4596-jimguillaume99-appcreationcompte.b.aivencloud.com;Username=avnadmin;Password=AVNS_KdDnmlQQIDbFzQR8iPA;Database=defaultdb";
      NpgsqlConnection conn = new NpgsqlConnection(connectionString);

      //Open the Db Connection

      //TODO ERROR TIMEOUT
      conn.Open();
      return conn;
    }

    private void DisconnectFromDb()
    {
      //Set TempUser + Password to DB
      var connectionString = "Host=pg-309a4596-jimguillaume99-appcreationcompte.b.aivencloud.com;Username=temporaryUser;Password=AVNS_S8h-B3s6-s70FZUPUEx;Database=defaultdb";
      NpgsqlConnection conn = new NpgsqlConnection(connectionString);

      //Close the Db Connection
      conn.Close();

    }

    public void UserSignUp(string UID, string Password, string eMail)
    {
      string SignUpQuery = "INSERT INTO user(username, password, email) VALUES(@UID, @Password, @eMail)";
      using (NpgsqlCommand cmd = new NpgsqlCommand(SignUpQuery, ConnectToDb()))
      {
        cmd.Parameters.AddWithValue("@UID", UID);
        cmd.Parameters.AddWithValue("@Password", Password);
        cmd.Parameters.AddWithValue("@eMail", eMail);
        cmd.ExecuteNonQuery();
      }
    }

    public void UserLogIn(string UID, string Password)
    {
      string SignInQuery = "SELECT * FROM user(username, password) WHERE username = '@UID' AND password = '@Password'";
      using (NpgsqlCommand cmd = new NpgsqlCommand(SignInQuery, ConnectToDb()))
      {
        cmd.Parameters.AddWithValue("@UID", UID);
        cmd.Parameters.AddWithValue("@Password", Password);
      }
    }

  }
}
