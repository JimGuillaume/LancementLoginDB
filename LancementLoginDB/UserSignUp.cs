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
    public UserSignUp() => DefaultUser();

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

      SyntaxCheck UIDCheck = new();

      this.UserId = UIDCheck.UIDCheck(t_UID, 1);
    }

    public void Set_UPSWD(string t_UPSWD)
    {
      SyntaxCheck PasswordCheck = new();

      this.UserPswd = PasswordCheck.PasswordCheck(t_UPSWD, 1);
    }

    public void Set_UMail(string t_UMail)
    {
      SyntaxCheck eMailCheck = new();

      this.UserEmail = eMailCheck.EmailCheck(t_UMail, 1);
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



    //MISC


  }
}
