using OpenQA.Selenium;

namespace FirstPOMproject.Pages
{
    public class GoogleSearchResults : BasePage
    {
        public GoogleSearchResults(IWebDriver driver)
            : base (driver)
        {
        }

        public new string Url => "http://www.google.com";

        public IWebElement googleResult => Driver.FindElement(By.XPath(@"//*[@id=""rso""]/div[1]/div/div/div/div[1]/a/h3"));
    }

}
