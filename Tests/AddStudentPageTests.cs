using NUnit.Framework.Constraints;
using WebDriverUITestsPOMStudentRegistryNunit.Pages;

namespace WebDriverUITestsPOMStudentRegistryNunit.Tests
{
    public class AddStudentPageTests : BaseTest
    {


        [Test]
        public void Test_AddStudentPage_Check_Content()
        {
            var page = new AddStudentPage(driver);
            page.Open();

            Assert.That(page.GetPageTitle(), Is.EqualTo("Add Student"));
            Assert.That(page.GetPageHeadingText, Is.EqualTo("Register New Student"));
            Assert.IsEmpty(page.FieldStudentName.Text);
            Assert.IsEmpty(page.FieldStudentEmail.Text);
            Assert.That(page.ButtonAdd.Text, Is.EqualTo("Add"));

        }
        
        [Test]
        public void Test_AddStudentPage_Links()
        {
            var page = new AddStudentPage(driver);
            page.Open();

            page.HomePageLink.Click();
            Assert.IsTrue(new HomePage(driver).IsPageOpen());

            page.ViewStudentsPageLink.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsPageOpen());

            page.AddStudentPageLink.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsPageOpen());
        }  


        [Test]
        public void Test_AddStudentPage_Add_Valid_Student()
        {
            var page = new AddStudentPage(driver);
            page.Open();

            string name = "New student" + DateTime.Now.Ticks;
            string email = "email" + DateTime.Now.Ticks + "@ymail.com";

            page.AddStudent(name, email);

            var viewpage = new ViewStudentPage(driver);
            viewpage.Open();
            var students = viewpage.GetStudentsList();

            foreach (string s in students)
            {
                Assert.That(students, Contains.Item(name + " " + "(" + email + ")"));

            }

        }

        [Test]

         public void Test_AddStudentPage_Add_Invalid_Student()
         {
            var page = new AddStudentPage(driver);

            page.Open();

            string name = "";
            string email = "email" + DateTime.Now.Ticks + "@ymail.com"; ;

            page.AddStudent(name, email);

            Assert.IsTrue(page.IsPageOpen());
            
            var errMsg = "Cannot add student";

            StringAssert.Contains(errMsg, page.GetErrorMsg());

         }


    }


}
