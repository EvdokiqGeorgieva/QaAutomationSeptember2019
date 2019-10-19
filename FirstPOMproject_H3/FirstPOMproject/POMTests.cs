using FirstPOMproject.Page;
using FirstPOMproject.Pages;
using FirstPOMproject.Pages.RegistrationPage;
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
        private RegistrationPageFull _registrationPage;
        private Registration_User _user;
        private LoginPage _loginPage;
        private RegistrationPageFull _registrationPageFull;

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
            _loginPage = new LoginPage(Driver);
            _registrationPageFull = new RegistrationPageFull(Driver);
            _user = UserFactory.CreateRegistrationUser();
        }

        [Test]

        public void RegistrationSite_1()
        {
            _registrationPageFull.Navigate(_loginPage);
            _registrationPageFull.FindRegisterButton("Register", _registrationPageFull);
        }

        [Test]

        public void FillRegistrationForm_t1()
        {
            _registrationPageFull.Navigate(_loginPage);

            _user.firstNameField = "";

            _registrationPageFull.FillForm(_user);

            _registrationPageFull.ErrorAssert("firstname is required", _registrationPageFull);
        }

        [Test]

        public void FillRegistrationForm_t2()
        {
            _registrationPageFull.Navigate(_loginPage);

            _user.passwordField = "";

            _registrationPageFull.FillForm(_user);

            _registrationPageFull.ErrorAssert("passwd is required", _registrationPageFull);
        }

        [Test]

        public void FillRegistrationForm_t3()
        {
            _registrationPageFull.Navigate(_loginPage);

            _user.lastNameField = "";

            _registrationPageFull.FillForm(_user);

            _registrationPageFull.ErrorAssert("lastname is required", _registrationPageFull);
        }

        [Test]

        public void FillRegistrationForm_t4()
        {
            _registrationPageFull.Navigate(_loginPage);

            _user.stateDD = "";

            _registrationPageFull.FillForm(_user);

            _registrationPageFull.ErrorAssert("This country requires you to choose a State", _registrationPageFull);
        }


        [Test]

        public void FillRegistrationForm_t5()
        {
            _registrationPageFull.Navigate(_loginPage);

            _user.phoneField = "";

            _registrationPageFull.FillForm(_user);

            _registrationPageFull.ErrorAssert("You must register at least one phone number", _registrationPageFull);
        }
    }
}
