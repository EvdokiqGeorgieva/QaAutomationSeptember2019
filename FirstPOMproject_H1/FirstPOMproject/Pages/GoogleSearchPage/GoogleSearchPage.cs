using OpenQA.Selenium;

namespace FirstPOMproject.Pages
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver)
            : base (driver)
        {
        }

        public new string Url => "http://www.google.com";

        public IWebElement googleSearchInput => Driver.FindElement(By.XPath(@"//*[@id=""tsf""]/div[2]/div[1]/div[1]/div/div[2]/input"));
    }

}
