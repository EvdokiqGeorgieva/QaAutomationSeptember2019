using OpenQA.Selenium;

namespace FirstPOMproject.Pages
{
    public class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver)
            : base (driver)
        {
        }

        public new string Url => "https://softuni.bg/";

        //works with full x-path
        public IWebElement allCourseButton => Driver.FindElement(By.XPath(@"/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a"));
        
        public IWebElement courseButton => Driver.FindElement(By.XPath(@"/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));

    }

}
