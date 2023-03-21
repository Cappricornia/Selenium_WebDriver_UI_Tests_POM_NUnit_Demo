using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverUITestsPOMStudentRegistryNunit.Tests
{
    public class BaseTest
    {
       
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
