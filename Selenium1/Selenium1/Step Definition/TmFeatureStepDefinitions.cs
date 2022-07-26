using NUnit.Framework;
using Selenium1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Selenium1
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        loginpage loginObj = new loginpage();
        homepage homepageObj = new homepage();
        tmpage tmObject = new tmpage();

        [AfterTestRun]
        public static void AfterWebFeature(IWebDriver driver)
        {
            driver.Quit();
        }

        [Given(@"Logged in successfully into Turnup Portal")]
        public void GivenLoggedInSuccessfullyIntoTurnupPortal()
        {
            driver = new ChromeDriver();
            loginpage.LoginActions(driver);
        }

        [When(@"I go To Time and Material Page")]
        public void WhenIGoToTimeAndMaterialPage()
        {
            homepageObj.GotoTmPage(driver);

        }

        [When(@"I create a new material")]
        public void WhenICreateANewMaterial()
        {
            tmObject.CreateTm(driver);
        }
        
        [Then(@"Then Record should be created successfully")]
        public void ThenThenRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmObject.GetCode(driver);
            string newDescription = tmObject.GetDescription(driver);
            string newPrice = tmObject.GetPrice(driver);

            Assert.That(newCode == "Spark","Actual Code and Expected Code do not match");
            Assert.That(newDescription == "Calls", "Actual Description and Expected Description do not match");
            Assert.That(newPrice == "$20.00", "Actual Price and Expected Price do not match");
        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' of an existing material record")]
        public void WhenIUpdateAndOfAnExistingMaterialRecord(string p0, string p1, string p2)
        {
            tmObject.TmEdit(driver,p0,p1,p2);
        }

        [Then(@"Record should have '([^']*)','([^']*)' and '([^']*)' updated")]
        public void ThenRecordShouldHaveAndUpadated(string p0, string p1, string p2)
        {
            string EditedCode = tmObject.GetEditedCode(driver);
            string EditedDescription = tmObject.GetEditedDescription(driver);
            string EditedPrice = tmObject.GetEditedPrice(driver);

            Assert.That(EditedCode == p0, "Code not Edited");
            Assert.That(EditedDescription == p1, "Description not Edited");
            Assert.That(EditedPrice == p2, "Price not Edited");
        }


        [When(@"I delete an existing Record and click on OK to confirm")]
        public void WhenIDeleteAnExistingRecordAndClickOnOKToConfirm()
        {
            tmObject.DeleteTm(driver);
        }

        [Then(@"record should be deleted sucessfully")]
        public void ThenRecordShouldBeDeletedSucessfully()
        {
            string DeletedCode = tmObject.GetDeletedCode(driver);

            Assert.That(DeletedCode != "2 Degrees", "Code is not Deleted");
        }

    }
}
