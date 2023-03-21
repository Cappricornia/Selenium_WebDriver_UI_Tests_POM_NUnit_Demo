using OpenQA.Selenium;

namespace WebDriverUITestsPOMStudentRegistryNunit.Pages
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/add-student";

        public IWebElement FieldStudentName => driver.FindElement(By.CssSelector("#name"));
        public IWebElement FieldStudentEmail => driver.FindElement(By.CssSelector("#email"));
        public IWebElement ErrorMsgElement => driver.FindElement(By.XPath("//div[contains(.,'Cannot add student. Name and email fields are required!')]"));
        public IWebElement ButtonAdd => driver.FindElement(By.CssSelector("body > form > button"));

        public void AddStudent(string name, string email)
        {
            this.FieldStudentName.SendKeys(name);
            this.FieldStudentEmail.SendKeys(email);
            this.ButtonAdd.Click();
        }


        public string GetErrorMsg()
        { 
            return ErrorMsgElement.Text;  

        }
    }

 }


