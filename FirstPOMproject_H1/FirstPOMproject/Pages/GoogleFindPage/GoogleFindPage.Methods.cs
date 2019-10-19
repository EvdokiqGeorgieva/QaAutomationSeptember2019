using FirstPOMproject.Page;
using FirstPOMproject.Pages.RegistrationPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages
{
    public partial class GoogleFindPage
    {
        public void Navigate(GoogleSearchPage searchPage)
        {
            searchPage.Navigate("http://www.google.com");
            searchPage.googleSearchInput.SendKeys("Selenium");
            searchPage.googleSearchInput.SendKeys(Keys.Enter);
        }

        public void Navigate1(GoogleSearchResults searchResult)
        {
            searchResult.googleResult.Click();
        }

        public void AssertTitle(string expected, GoogleFindPage seleniumPage)
        {
            Assert.AreEqual(expected, seleniumPage.title.GetAttribute("text"), "Title is not correct");
        }
    }
}
