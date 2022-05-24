using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class HomePageTests : BaseTests
    {

        [Test]
        public void Test_HomePage_Url_Heading_Title()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));
            Assert.That("Students Registry", Is.EqualTo(home_page.GetPageHeading()));
            Assert.That(home_page.GetPageTitle, Is.EqualTo("MVC Example"));
        }

        [Test]
        public void Test_HomePage_Url_HomeLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle, Is.EqualTo("MVC Example"));
        }


        [Test]
        public void Test_HomePage_Url_ViewStudents()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle, Is.EqualTo("MVC Example"));
        }

        [Test]
        public void Test_HomePage_Url_StudentCount()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.Greater(home_page.GetStudentCount(), 1);
        }

        [Test]
        public void Test_HomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.ViewStudentsLink.Click();
            var view_student = new ViewStudentsPage(driver);
            Assert.That(view_student.GetPageTitle, Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(view_student.GetPageUrl()));
        }

        [Test]
        public void Test_HomePage_AddStudentLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.AddStudentLink.Click();
            var add_student = new AddStudentPage(driver);
            Assert.That(add_student.GetPageTitle, Is.EqualTo("Add Student"));
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));
        }
    }
}