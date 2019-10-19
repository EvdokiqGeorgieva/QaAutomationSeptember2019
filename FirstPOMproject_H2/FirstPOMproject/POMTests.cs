using FirstPOMproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject
{
    [TestFixture]
    //[Category("InstantSauceTest"), Category("NUnit"), Category("Instant")]

    class POMTests : BaseTest
    {
        //private RemoteWebDriver _driver;
        //private ChromeDriver _driver;
        //private WebDriverWait _wait;
        private SoftUniCoursePage _softUniCoursePage;
        private SoftUniPage _softUniPage;

        [SetUp]

        public void ClassInitialize()
        {
            //ChromeOptions options = new ChromeOptions();

            //options.PlatformName = "windows";
            //options.BrowserVersion = "77.0";

            //_driver = new RemoteWebDriver(new Uri("http://192.168.100.8:27617/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            //_driver.Manage().Window.Maximize();
            //_wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //_driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //_wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            //_driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //SoftUniCoursePage check
            _softUniCoursePage = new SoftUniCoursePage(Driver);
            _softUniPage = new SoftUniPage(Driver);
        }

       
        [Test]

        public void SoftUniPageCheck()
        {
            _softUniCoursePage.Navigate(_softUniPage);
            _softUniCoursePage.AssertTag("h1", _softUniCoursePage);
            _softUniCoursePage.AssertTagText("QA Automation - септември 2019", _softUniCoursePage);
        }

    }
}
