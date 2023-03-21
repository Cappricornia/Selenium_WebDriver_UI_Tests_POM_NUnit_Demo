using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WebDriverUITestsPOMStudentRegistryNunit.Pages
{
    public class ViewStudentPage: BasePage
    {
        public ViewStudentPage(IWebDriver driver): base(driver) 
        {
        }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/students";

        public ReadOnlyCollection<IWebElement> ListItemsStudents => driver.FindElements(By.CssSelector("body > ul > li"));

        public string[] GetStudentsList()
        {
            var studentsElements = this.ListItemsStudents.Select(s => s.Text).ToArray();
            return studentsElements; 
        }

    }
}
