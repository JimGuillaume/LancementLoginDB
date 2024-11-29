using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancementLoginDB
{
  internal class UserSignIn
  {
    private string UID;
    private string Password;

    void DefaultUser()
    {
      UID = "";
      Password = "";
    }
    //Constructor & Destructor
    public UserSignIn() => DefaultUser();

    ~UserSignIn()
    {
    }

    //All the Set
    public void CheckUsername(string t_UID)
    {
      SyntaxCheck UIDCheck = new();
      this.UID = UIDCheck.UIDCheck(t_UID, 2);

     
    }

    public void CheckPassword(string t_Password)
    {
      SyntaxCheck PasswordCheck = new();
      this.Password = PasswordCheck.PasswordCheck(t_Password, 2);
    }


    //ALL THE GET

    public string getUID()
    { 
      return this.UID; 
    }

    public string getPSWD()
    {
      return this.Password;
    }

    //LOG IN FCT
    public void LogIn(string UID, string Password)
    {
      DBSignUpSignIn UserLogIn = new();
        UserLogIn.UserLogIn(this.UID, this.Password);
    }
  }
}
