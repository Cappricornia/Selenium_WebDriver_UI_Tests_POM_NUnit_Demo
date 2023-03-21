using OpenQA.Selenium;


namespace WebDriverUITestsPOMStudentRegistryNunit.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public virtual string BaseUrl { get; }

        public IWebElement HomePageLink => driver.FindElement(By.XPath("//a[@href='/'][contains(.,'Home')]")); 
        public IWebElement ViewStudentsPageLink => driver.FindElement(By.XPath("//a[@href='/students'][contains(.,'View Students')]"));
        public IWebElement AddStudentPageLink => driver.FindElement(By.XPath("//a[@href='/add-student'][contains(.,'Add Student')]"));
        public IWebElement PageHeadingElement => driver.FindElement(By.CssSelector("body > h1"));


        public void Open()
        {
            driver.Navigate().GoToUrl(this.BaseUrl);
        }

        public bool IsPageOpen()
        {
            return driver.Url == this.BaseUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

       public string GetPageHeadingText()
        {
          return PageHeadingElement.Text; 
       }

    }
}
