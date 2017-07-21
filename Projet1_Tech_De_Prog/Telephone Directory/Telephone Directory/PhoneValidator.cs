using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Telephone_Directory
{
    public class PhoneValidator : PhoneDirectory
    {
        public bool ValidatePhone(string phoneNumber)
        {
            if (Regex.Match(phoneNumber, @"^\d{3}-\d{4}$").Success)
            {
                return false;
            }
            else
                return true;
        }
    }
}
