using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Telephone_Directory
{
    public class UsernameValidator : PhoneDirectory
    {
        public bool ValidateName(string userName)
        {
            if (Regex.Match(userName, @"^[a-zA-Z '-]+$").Success)
            {
                return false;
            }
            else
                return true;
        }
    }
}
