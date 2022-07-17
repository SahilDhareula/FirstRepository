using NUnit.Framework;
using Selenium1.Utilities;

namespace Selenium1.Tests
{
    [TestFixture]
    [Parallelizable]
    public class tmTests : CommonDriver
    {
        //page objects initialisation
        homepage homepageObj = new homepage();
        tmpage tmObject = new tmpage();

        [Test, Order(1)]
        public void CreateTmTest()
        {
            homepageObj.GotoTmPage(driver);
            tmObject.CreateTm(driver);
        }

        [Test,Order(2)]
        public void EditTmTest()
        {
            homepageObj.GotoTmPage(driver);
            tmObject.EditTm(driver);
        }

        [Test,Order(3)]
        public void DeleteTmTest()
        {
            homepageObj.GotoTmPage(driver);
            tmObject.DeleteTm(driver);
        }    
    }
}

