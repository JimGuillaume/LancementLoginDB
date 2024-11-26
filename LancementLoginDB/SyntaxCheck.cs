namespace LancementLoginDB
{
  internal class SyntaxCheck
  {

    public SyntaxCheck()
    {

    }

    public string UIDCheck(string t_UID, int CheckType) // Non Null // Lenght 3 - 25 // LetterOrDigit //
    {
      switch (CheckType) // 1 = SignUp // 2 = SignIn
      {
        case 1:
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
          }
          else return t_UID;


        case 2:

          if (t_UID == "")
          {
            throw new UserSignInException(1, "Le Nom d'utilisateur ne peut pas être vide");
          }
          else if (t_UID.Length < 3 || t_UID.Length > 25)
          {
            throw new UserSignInException(2, "Le Nom d'utilisateur doit être d'une longeur 3 - 25");
          }
          else if (t_UID.Any(ch => !char.IsLetterOrDigit(ch)))
          {
            throw new UserSignInException(3, "Le Nom d'utilisateur ne doit pas contenir de caractères spéciaux");
          }
          else return t_UID;
        default:
          throw new Exception("SyntaxCheck : UIDCheck : CheckType not found");

      }
    }

    public string PasswordCheck(string t_Password, int CheckType) // Not Null // Length 5 - 25 // 
    {

      switch (CheckType) // 1 = SignUp // 2 = SignIn
      {
        case 1:

          if (t_Password == "")
          {
            throw new UserSignUpException(10, "Le Mot de passe ne peut pas être vide");
          }
          else if (t_Password.Length < 5 || t_Password.Length > 25)
          {
            throw new UserSignUpException(11, "Le mot de passe doit être entre 5 & 25 caractères");
          }
          else return t_Password;

        case 2:

          if (t_Password == "")
          {
            throw new UserSignInException(10, "Le Mot de passe ne peut pas être vide");
          }
          else if (t_Password.Length < 5 || t_Password.Length > 25)
          {
            throw new UserSignInException(11, "Le mot de passe doit être entre 5 & 25 caractères");
          }
          else return t_Password;
        default:
          throw new Exception("SyntaxCheck : PasswordCheck : CheckType not found");
      }
    }


    public string EmailCheck(string t_Email, int v)
    {
      if (string.IsNullOrWhiteSpace(t_Email))
      {
        throw new UserSignUpException(20, "L'adresse e-mail ne peut pas être vide");
      }

      try
      {

        var addr = new System.Net.Mail.MailAddress(t_Email);

      }
      catch (Exception)
      {
        throw new UserSignUpException(21, "L'adresse e-mail n'est pas valide");
        throw;
      }
      return t_Email;
    }

  }
}
