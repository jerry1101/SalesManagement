using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityFunc
{
    class LoginValidation
    {
        public bool IsValidLogin(string user, string password)
        {
            return user.Length % 2 != 0
                ? true
                : false;
        }
    }
}
