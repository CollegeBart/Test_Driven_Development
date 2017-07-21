using System;
using Telephone_Directory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Telephonetest
{
    [TestClass]
    public class PhoneDirectoryTest
    {
        [TestMethod]
        [TestCategory("validate")]
        public void validateTest()
        {
            PhoneDirectory phonedir = new PhoneDirectory();
            PhoneDirectory.ErrorType user = phonedir.validate("Anthony Robert", "418-9945");
            Assert.AreEqual(PhoneDirectory.ErrorType.NONE, user);
        }
        [TestMethod]
        [TestCategory("validate")]
        public void validateTest1()
        {
            PhoneDirectory phonedir = new PhoneDirectory();
            PhoneDirectory.ErrorType user1 = phonedir.validate("Anthroniôôôô Rôtôtrê", "417-4582");
            Assert.AreEqual(PhoneDirectory.ErrorType.USERNAME_INVALID, user1);
        }
        [TestMethod]
        [TestCategory("validate")]
        public void validateTest2()
        {
            PhoneDirectory phonedir = new PhoneDirectory();
            PhoneDirectory.ErrorType user2 = phonedir.validate("Anthony Robert", "417454582");
            Assert.AreEqual(PhoneDirectory.ErrorType.PHONE_INVALID, user2);
        }
        [TestMethod]
        [TestCategory("validate")]
        public void validateTest3()
        {
            PhoneDirectory phonedir = new PhoneDirectory();
            phonedir.addUser("Anthony Robert", "418-9456");
            PhoneDirectory.ErrorType veriff = phonedir.validate("Anthony Robert", "418-9456");
            Assert.AreEqual(PhoneDirectory.ErrorType.USER_EXIST, veriff);
        }
        [TestMethod]
        [TestCategory("usernameValid")]
        public void validateUsername()
        {
            UsernameValidator userNamValid = new UsernameValidator();
            userNamValid.ValidateName("Anthoniéòô Roberteé123");
            bool validname = userNamValid.ValidateName("Anthoniéòô Roberteé123");
            Assert.IsTrue(validname);
        }
        [TestMethod]
        [TestCategory("usernameValid")]
        public void validateUsername1()
        {
            UsernameValidator userNamValid = new UsernameValidator();
            userNamValid.ValidateName("Anthony Robert");
            bool validname1 = userNamValid.ValidateName("Anthony Robert");
            Assert.IsFalse(validname1);
        }
        [TestMethod]
        [TestCategory("usernameValid")]
        public void validateUsername2()
        {
            UsernameValidator userNamValid = new UsernameValidator();
            userNamValid.ValidateName("MathieuSavard");
            bool validname2 = userNamValid.ValidateName("MathieuSavard");
            Assert.IsFalse(validname2);
        }
        [TestMethod]
        [TestCategory("usernameValid")]
        public void validateUsername3()
        {
            UsernameValidator userNamValid = new UsernameValidator();
            userNamValid.ValidateName("1562354 65484");
            bool validname3 = userNamValid.ValidateName("1562354 65484");
            Assert.IsTrue(validname3);
        }
        [TestMethod]
        [TestCategory("phonenumValid")]
        public void validatePhonenum()
        {
            PhoneValidator phoneValid = new PhoneValidator();
            phoneValid.ValidatePhone("418-4465");
            bool validphone = phoneValid.ValidatePhone("418-4465");
            Assert.IsFalse(validphone);
        }
        [TestMethod]
        [TestCategory("phonenumValid")]
        public void validatePhonenum1()
        {
            PhoneValidator phoneValid = new PhoneValidator();
            phoneValid.ValidatePhone("4184465");
            bool validphone = phoneValid.ValidatePhone("4184465");
            Assert.IsTrue(validphone);
        }
        [TestMethod]
        [TestCategory("phonenumValid")]
        public void validatePhonenum2()
        {
            PhoneValidator phoneValid = new PhoneValidator();
            phoneValid.ValidatePhone("ABC-DEFG");
            bool validphone = phoneValid.ValidatePhone("ABC-DEFG");
            Assert.IsTrue(validphone);
        }
        [TestMethod]
        [TestCategory("phonenumValid")]
        public void validatePhonenum3()
        {
            PhoneValidator phoneValid = new PhoneValidator();
            phoneValid.ValidatePhone("418-4465987654");
            bool validphone = phoneValid.ValidatePhone("418-4465987654");
            Assert.IsTrue(validphone);
        }
    }
}
