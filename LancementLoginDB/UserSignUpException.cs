using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancementLoginDB
{
  internal class UserSignUpException(int t_errorCode, string t_message = "Error User Sector 1A") : Exception
  {
    public string message = t_message;
    
    //1 ID==null, 2 id<3, 3 idContainSpecial
    //4 15>pswd<5, 
    public int errorCode = t_errorCode;
  }
}
