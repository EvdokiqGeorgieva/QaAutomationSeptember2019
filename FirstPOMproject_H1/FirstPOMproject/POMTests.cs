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

    class POMTests
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;
        private RegistrationPageFull _registrationPage;
        private Registration_User _user;
        private GoogleSearchPage _googleSearchPage;
        private GoogleSearchResults _googleSearchResults;
        private GoogleFindPage _googleFindPage;
        private SoftUniCoursePage _softUniCoursePage;
        private SoftUniPage _softUniPage;
        private LoginPage _loginPage;
        private RegistrationPageFull _registrationPageFull;

        [SetUp]

        public void ClassInitialize()
        {
            //RegistrationPages
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _loginPage = new LoginPage(_driver);
            _registrationPageFull = new RegistrationPageFull(_driver);
            _user = UserFactory.CreateRegistrationUser();

            //Google search
            _googleSearchPage = new GoogleSearchPage(_driver);
            _googleSearchResults = new GoogleSearchResults(_driver);
            _googleFindPage = new GoogleFindPage(_driver);

            //SoftUniCoursePage check
            _softUniCoursePage = new SoftUniCoursePage(_driver);
            _softUniPage = new SoftUniPage(_driver);
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

        [Test]

        public void SeleniumPageGoogle()
        {
            _googleFindPage.Navigate(_googleSearchPage);
            _googleFindPage.Navigate1(_googleSearchResults);
            _googleFindPage.AssertTitle("Selenium - Web Browser Automation", _googleFindPage);
        }

        [Test]

        public void SoftUniPageCheck()
        {
            _softUniCoursePage.Navigate(_softUniPage);
            _softUniCoursePage.AssertTag("h1", _softUniCoursePage);
            _softUniCoursePage.AssertTagText("QA Automation - септември 2019", _softUniCoursePage);
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
