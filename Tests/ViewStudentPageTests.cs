using WebDriverUITestsPOMStudentRegistryNunit.Pages;

namespace WebDriverUITestsPOMStudentRegistryNunit.Tests
{
    public class ViewStudentPageTests: BaseTest
    {

        
        [Test]

        public void Test_ViewStudentsPage_Check_Content()
        {
            var page = new ViewStudentPage(driver);
            page.Open();

            Assert.That(page.GetPageTitle(), Is.EqualTo("Students"));
            Assert.That(page.GetPageHeadingText, Is.EqualTo("Registered Students"));

            var students = page.GetStudentsList();

            foreach (string s in students)
            {
                Assert.IsTrue(s.IndexOf("(") > 0);
                Assert.IsTrue(s.LastIndexOf(")") == s.Length-1);

            }
        }

        [Test]
        public void Test_ViewStudentsPage_Links()
        {
            var page = new ViewStudentPage(driver);
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


