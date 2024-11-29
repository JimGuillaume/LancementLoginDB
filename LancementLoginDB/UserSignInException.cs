using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancementLoginDB
{
  internal class UserSignInException(int t_errorCode, string t_message = "Error User Sector 1B") : Exception
  {
    public string message = t_message;

    public int errorCode = t_errorCode; // 1 Mauvais MDP // 2 USER EXISTE PAS
  }
}
