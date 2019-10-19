using FirstPOMproject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Page
{
    public class Registration_User
    {
        public string firstNameField { get; set; }

        public string lastNameField { get; set; }

        public string passwordField { get; set; }

        public string dateDD { get; set; }

        public string monthDD { get; set; }

        public string yearDD { get; set; }

        public string addressFirstName { get; set; }

        public string addressField { get; set; }

        public string cityField { get; set; }

        public string stateDD { get; set; }

        public string postcode { get; set; }

        public string phoneField { get; set; }

        public string alias { get; set; }
    }

    public class GoogleSearch
        {
        public string seleniumText { get; set; }
        }
}
