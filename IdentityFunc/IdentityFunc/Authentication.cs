using System;
using System.Collections.Generic;
using System.Text;
using static IdentityFunc.DataTypes;

namespace IdentityFunc
{
    class Authentication
    {
        public IEnumerable<string> GetSecurityProfile(string name)
        {
            return (GetLoginRoleType(name) == LoginRoleType.Member)
                ? new List<string>{ "MyProfile"}
                : new List<string> { "Customer" };
        }

        private LoginRoleType GetLoginRoleType(string name)
        {
            return name.Length % 2 != 0
                ? LoginRoleType.Member
                : LoginRoleType.Admin;
        }
    }
}
