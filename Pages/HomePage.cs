using OpenQA.Selenium;

namespace WebDriverUITestsPOMStudentRegistryNunit.Pages
{
    public class HomePage: BasePage
    {
        public HomePage(IWebDriver driver): base(driver) 
        {
        }

        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/";

        public IWebElement NumberOfStudentsElement => driver.FindElement(By.CssSelector("body > p > b")); 

        
        public string GetStudentsCount()
        {
            
            return NumberOfStudentsElement.Text;
        }
        
    }


}
