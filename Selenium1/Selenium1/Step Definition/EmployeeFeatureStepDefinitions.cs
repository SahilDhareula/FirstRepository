using System;
using TechTalk.SpecFlow;

namespace Selenium1
{
    [Binding]
    public class EmployeeFeatureStepDefinitions
    {
        [When(@"I go Employees Page")]
        public void WhenIGoEmployeesPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"New Employee should be created successfully")]
        public void ThenNewEmployeeShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I edit created employee record")]
        public void WhenIEditCreatedEmployeeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"Created Employee should be edited successfully")]
        public void ThenCreatedEmployeeShouldBeEditedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I delete a new employee record")]
        public void WhenIDeleteANewEmployeeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"Employee should be deleted successfully")]
        public void ThenEmployeeShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
