using FirstPOMproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages
{
    public partial class RegistrationPageFull : BasePage
    {
        public RegistrationPageFull(IWebDriver driver)
           : base(driver)
        {
        }

        public new string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";

        public IList<IWebElement> radioButton => Wait.Until(d => d.FindElements(By.XPath(@"//div[@class=""radio""]//input")));

        public IWebElement firstNameField => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement lastNameField => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement passwordField => Driver.FindElement(By.Id("passwd"));

        public SelectElement Days
        {
            get
            {
                IWebElement dateDD = Wait.Until(d => d.FindElement(By.Id("days")));
                return new SelectElement(dateDD);
            }
        }

        public SelectElement Months
        {
            get
            {
                IWebElement monthDD = Wait.Until(d => d.FindElement(By.Id("months")));
                return new SelectElement(monthDD);

            }

        }

        public SelectElement Years
        {
            get
            {
                IWebElement yearDD = Wait.Until(d => d.FindElement(By.Id("years")));
                return new SelectElement(yearDD);
            }

        }

        public IWebElement addressFirstName => Driver.FindElement(By.Id("firstname"));

        public IWebElement addressField => Driver.FindElement(By.Id("address1"));

        public IWebElement cityField => Driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement stateDD = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(stateDD);
            }

        }

        public IWebElement postcode => Driver.FindElement(By.Id("postcode"));

        public IWebElement phoneField => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement alias => Driver.FindElement(By.Id("alias"));

        public IWebElement registerButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement errorMessage => Driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/p"));

        public IWebElement firstNameErrorMessage => Wait.Until(e1 => e1.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li[1]")));

        public IWebElement passwordErrorMessage => Wait.Until(e1 => e1.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li[1]")));
    }
}
