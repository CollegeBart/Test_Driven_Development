using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Directory
{
    public class User : PhoneDirectory
    {
        public string userName;
        public string phonenumber;
        public User(string UserName, string PhoneNumber)
        {
            userName = UserName;
            PhoneNumber = phonenumber;
        }

    }
}
