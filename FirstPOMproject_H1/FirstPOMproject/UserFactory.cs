using FirstPOMproject.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages.RegistrationPage
{
    public static class UserFactory
    {
        public static Registration_User CreateRegistrationUser ()
        {
            return new Registration_User
            {
                firstNameField = "John",
                lastNameField = "Smith",
                yearDD = "1989",
                monthDD = "3",
                dateDD = "3",
                passwordField = "123456789",
                addressFirstName = "SomeFirstName",
                addressField = "37 Washington Str.",
                cityField = "Seattle",
                stateDD = "1",
                postcode = "98103",
                phoneField = "555 555 555",
                alias = "Address",
            };
        }
    }
}
