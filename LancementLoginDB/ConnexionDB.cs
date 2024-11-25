using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace LancementLoginDB
{
  internal class ConnexionDB
  {
    static void ConnexionDb()
    {
      // Identifiants PGSQL
      string connectionString = "Host=pg-309a4596-jimguillaume99-appcreationcompte.b.aivencloud.com;Username=avnadmin;Password=AVNS_KdDnmlQQIDbFzQR8iPA;Database=defaultdb";

      // Etablir une connexion
      using var connection = new NpgsqlConnection(connectionString);
      try
      {
        connection.Open();
        Console.WriteLine("Connection to database established successfully.");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"An error occurred: {ex.Message}");
      }
    }

    static void InscriptionDB(UserSignUp NewUser)
    {
      string UID = NewUser.Get_UID();
      string Password = NewUser.Get_UPSWD();
      string Email = NewUser.Get_UMail();

    }
  }
}
