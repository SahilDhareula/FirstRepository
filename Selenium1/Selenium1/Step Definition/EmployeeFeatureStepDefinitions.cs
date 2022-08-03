using Selenium1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Selenium1
{
    [Binding]
    public class EmployeeFeatureStepDefinitions: CommonDriver
    {
        loginpage loginObj = new loginpage();
        homepage homepageObj = new homepage();
        EmployeePage EmpObject = new EmployeePage();

        [AfterTestRun]
        public static void AfterWebFeature(IWebDriver driver)
        {
            driver.Quit();
        }

        [Given(@"Log in successfully into Turnup Portal")]
        public void GivenLogInSuccessfullyIntoTurnupPortal()
        {
            driver = new ChromeDriver();
            loginpage.LoginActions(driver);
        }

        [When(@"I go To Employee Page")]
        public void WhenIGoToEmployeePage()
        {
            homepageObj.
        }

        [When(@"I create a new employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            
        }

        [Then(@"New Employee Record Should be created successfully")]
        public void ThenNewEmployeeRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' of an existing employee record")]
        public void WhenIUpdateAndOfAnExistingEmployeeRecord(string asus, string ben, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"Employee Record should have '([^']*)','([^']*)' and '([^']*)' updated")]
        public void ThenEmployeeRecordShouldHaveAndUpdated(string asus, string ben, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"I delete an existing Employee Record and click on OK to confirm")]
        public void WhenIDeleteAnExistingEmployeeRecordAndClickOnOKToConfirm()
        {
            throw new PendingStepException();
        }

        [Then(@"Employee record should be deleted sucessfully")]
        public void ThenEmployeeRecordShouldBeDeletedSucessfully()
        {
            throw new PendingStepException();
        }
    }
}
