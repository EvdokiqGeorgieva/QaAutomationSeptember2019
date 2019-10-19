using OpenQA.Selenium;

namespace FirstPOMproject.Pages
{
    public partial class SoftUniCoursePage : BasePage
    {
        public SoftUniCoursePage(IWebDriver driver)
            : base (driver)
        {
        }

        public new string Url => "http://www.google.com";

        public IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
        
    }

}
