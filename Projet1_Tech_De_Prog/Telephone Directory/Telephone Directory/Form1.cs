using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Directory
{
    public partial class Form1 : Form
    {
        public PhoneDirectory list;

        public Form1()
        {
            InitializeComponent();
            list = new PhoneDirectory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneDirectory.ErrorType message = list.validate(userBox.Text, phoneBox.Text);

            if (message == PhoneDirectory.ErrorType.USER_EXIST)
                messBox.Text = "Sorry, this user already exist";
            else if (message == PhoneDirectory.ErrorType.USERNAME_INVALID)
                messBox.Text = "This username is invalid, you can only use letters without accent and numbers";
            else if (message == PhoneDirectory.ErrorType.PHONE_INVALID)
            {
                messBox.Text = "This phone number is invalid, you must write your phone number like this : ***-****, where the * represent numbers";
            }
            else if (message == PhoneDirectory.ErrorType.NONE)
            {
                list.addUser(userBox.Text, phoneBox.Text);
                messBox.Text = "User successfuly added!! ";
            }
        }
    }
}
