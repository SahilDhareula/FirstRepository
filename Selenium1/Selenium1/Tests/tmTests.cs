using NUnit.Framework;
using Selenium1.Utilities;

namespace Selenium1.Tests
{
    [TestFixture]
    public class tmTests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            loginpage loginObject = new loginpage();
            loginpage.LoginActions(driver);

            homepage homepageObj = new homepage();
            homepageObj.GotoTmPage(driver);
        }

        [Test]
        public void CreateTmTest()
        {
            tmpage tmObject = new tmpage();
            tmObject.CreateTm(driver);


        }

        [Test]
        public void EditTmTest()
        {
            tmpage tmObject = new tmpage();
            tmObject.EditTm(driver);

        }

        [Test]
        public void DeleteTmTest()
        {
            tmpage tmObject = new tmpage();
            tmObject.DeleteTm(driver);

        }    

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }

}

