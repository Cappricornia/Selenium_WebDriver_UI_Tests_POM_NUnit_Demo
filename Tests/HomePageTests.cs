using WebDriverUITestsPOMStudentRegistryNunit.Pages;

namespace WebDriverUITestsPOMStudentRegistryNunit.Tests
{
    public class HomePageTests: BaseTest
    {
        [Test]
        public void Test_HomePage_Check_Content()
        {
            var page = new HomePage(driver);
            page.Open();

            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeadingText, Is.EqualTo("Students Registry"));
            Assert.That(page.GetStudentsCount(), Is.EqualTo(page.NumberOfStudentsElement.Text));
       
        }
        
        [Test]
        public void Test_HomePage_HomePageLink()
        {
            var page = new HomePage(driver);
            page.Open();
            page.HomePageLink.Click();
            Assert.IsTrue(new HomePage(driver).IsPageOpen());

            page.ViewStudentsPageLink.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsPageOpen());

            page.AddStudentPageLink.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsPageOpen());
        }

    }

}


