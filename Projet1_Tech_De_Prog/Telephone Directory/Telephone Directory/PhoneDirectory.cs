using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Directory
{
    public class PhoneDirectory
    {
        private List<User> userPhoneList;
        public enum ErrorType
        {
            NONE,
            USER_EXIST,
            USERNAME_INVALID,
            PHONE_INVALID
        }

        public PhoneDirectory()
        {
            userPhoneList = new List<User>();
        }

        public ErrorType validate(string username, string phone)
        {
            PhoneValidator phonevalid = new PhoneValidator();

            UsernameValidator uservalid = new UsernameValidator();

            if (VerifierList(username))
                return ErrorType.USER_EXIST;
            else if (uservalid.ValidateName(username))
                return ErrorType.USERNAME_INVALID;
            else if (phonevalid.ValidatePhone(phone))
                return ErrorType.PHONE_INVALID;
            else
                return ErrorType.NONE;
        }

        public bool VerifierList(string username)
        {
            for (int i = 0; i < userPhoneList.Count; i++)
            {
                User user = userPhoneList[i];

                if (user.userName == username)
                {
                    return true;
                }

            }
            return false;
        }

        public void addUser(string username, string phone)
        {
            User user = new User(username, phone);
            userPhoneList.Add(user);
        }
    }
}
