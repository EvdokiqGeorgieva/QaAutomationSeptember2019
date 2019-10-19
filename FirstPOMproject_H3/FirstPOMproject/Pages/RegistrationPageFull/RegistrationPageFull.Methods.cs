using FirstPOMproject.Page;
using FirstPOMproject.Pages.RegistrationPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages
{
    public partial class RegistrationPageFull
    {

        public void FillForm(Registration_User user)
        {
            radioButton[0].Click();
            firstNameField.SendKeys(user.firstNameField);
            lastNameField.SendKeys(user.lastNameField);
            passwordField.SendKeys(user.passwordField);
            Days.SelectByValue(user.dateDD);
            Months.SelectByValue(user.monthDD);
            Years.SelectByValue(user.yearDD);
            addressFirstName.SendKeys(user.addressFirstName);
            addressField.SendKeys(user.addressField);
            cityField.SendKeys(user.cityField);
            State.SelectByValue(user.stateDD);
            postcode.SendKeys(user.postcode);
            phoneField.SendKeys(user.phoneField);
            alias.SendKeys(user.alias);
            registerButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");
            loginPage.Email.SendKeys("somenNewEmail@abv.bg");
            loginPage.Submit.Click();
        }

        public void FindRegisterButton(string expected, RegistrationPageFull button)
        {
            Assert.AreEqual(expected, button.registerButton.Text, "Not the registration page");
        }

        public void ErrorAssert(string expected, RegistrationPageFull error)
        {
            bool errorExists = error.firstNameErrorMessage.Text.Contains(expected);
            Assert.IsTrue(errorExists, "Not correct error message");
        }
    }
}
