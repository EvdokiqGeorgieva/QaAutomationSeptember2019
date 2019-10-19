using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public virtual string Url { get; set; }

        public virtual void Navigate (string url)
        {
            Driver.Url = url;
        }
    }
}
