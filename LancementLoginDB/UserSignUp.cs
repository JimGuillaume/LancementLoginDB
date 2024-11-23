using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancementLoginDB
{
  public class UserSignUp
  {
    private string UserId;
    private string UserPswd;
    private string UserEmail;

    void DefaultUser()
    {
      this.UserId = "";
      this.UserPswd = "";
      this.UserEmail = "";

    }

    //CONSTRUCTOR  & DESTRUCTOR
    public UserSignUp()
    {
      DefaultUser();
    }

    ~UserSignUp()
    {

    }


    // ALL THE SET
    public void Set_UID(string t_UID)
    {
      //Pas "null"
      //Longeur 3 - 25
      //Pas de caractères spéciaux
      //A-Z ; a-z ; 0-9

      if (t_UID == "")
      {
        throw new UserSignUpException(1, "Le Nom d'utilisateur ne peut pas être vide");
      }
      else if (t_UID.Length < 3 || t_UID.Length > 25)
      {
        throw new UserSignUpException(2, "Le Nom d'utilisateur doit être d'une longeur 3 - 25");
      }
      else if (t_UID.Any(ch => !char.IsLetterOrDigit(ch)))
      {
        throw new UserSignUpException(3, "Le Nom d'utilisateur ne doit pas contenir de caractères spéciaux");
      } else this.UserId = t_UID;
    }

    public void Set_UPSWD(string t_UPSWD)
    {
      if (t_UPSWD == "null")
      {
        throw new UserSignUpException(4, "Le Mot de passe ne peut pas être vide");
      }
      else if (t_UPSWD.Length < 5 || t_UPSWD.Length > 25)
      {
        throw new UserSignUpException(5, "Le mot de passe doit être entre 5 & 25 caractères");
      } else this.UserPswd = t_UPSWD;
    }

    public void Set_UMail(string t_UMail)
    {
      this.UserEmail = t_UMail;
    }


    //ALL THE GET

    public string Get_UID()
    {
      return this.UserId;
    }

    public string Get_UPSWD()
    {
      return this.UserPswd;
    }

    public string Get_UMail()
    {
      return this.UserEmail;
    }


  }
}
