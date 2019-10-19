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
    public partial class GoogleFindPage : BasePage
    {
        public GoogleFindPage(IWebDriver driver)
           : base(driver)
        {
        }

        public new string Url => "http://www.google.com";

        public IWebElement title => Driver.FindElement(By.XPath(@"/html/head/title"));
        
    }
}
