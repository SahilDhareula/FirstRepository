using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement createEmpButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createEmpButton.Click();
            Thread.Sleep(1000);

            //Input Name
            IWebElement nameTexbox = driver.FindElement(By.Id("Name"));
            nameTexbox.SendKeys("Saahil");
            Thread.Sleep(1000);

            //Input Username
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("Saahil");
            Thread.Sleep(1000);

            //Input Contact
            IWebElement contactTextbox = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
            contactTextbox.SendKeys("0218786765");

            //Input Password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("P@ssw0rd123456");
            Thread.Sleep(1000);

            //Re-type Password
            IWebElement reTypePassword = driver.FindElement(By.Id("RetypePassword"));
            reTypePassword.SendKeys("P@ssw0rd123456");
            Thread.Sleep(1000);

            //Select Checkbox
            IWebElement isAdmincheckbox = driver.FindElement(By.Id("IsAdmin"));
            isAdmincheckbox.Click();
            Thread.Sleep(1000);

            //Input Vehicle
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("car");
            Thread.Sleep(1000);

            //Select Groups from Dropdown
            IWebElement groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();

            //Click on Save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //click on back to list
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();

            //Go to last page to check the created employee
            Thread.Sleep(2000);
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //Check if employee has been created
            IWebElement validUsername = driver.FindElement(By.Id("Username"));
            Assert.That(validUsername.Text == "Saahil", "Unable to create Employee please try again");
        }
        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GoToLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToLastPage.Click();

            IWebElement EditEmpButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            EditEmpButton.Click();
            Thread.Sleep(1000);

            IWebElement EditUsername = driver.FindElement(By.Id("Username"));
            EditUsername.Click();
            EditUsername.Clear();
            EditUsername.SendKeys("Username");

            IWebElement EditContactButton = driver.FindElement(By.Id("EditContactButton"));
            EditContactButton.Click();
            Thread.Sleep(1000);

            IWebElement FirstNameTextbox = driver.FindElement(By.Id("FirstName"));
            FirstNameTextbox.Click();
            FirstNameTextbox.SendKeys("FirstName");

            IWebElement LastNameTextbox = driver.FindElement(By.Id("FirstName"));
            LastNameTextbox.Click();
            LastNameTextbox.SendKeys("LastName");

            IWebElement PhoneTextbox = driver.FindElement(By.Id("Phone"));
            PhoneTextbox.Click();
            PhoneTextbox.SendKeys("0217654567");
            
            IWebElement SaveContact = driver.FindElement(By.Id("submitButton"));
            SaveContact.Click();

            //Click on Save Button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //Go back to list
            IWebElement GoToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            GoToList.Click();

            //Go to the last Page
            Thread.Sleep(1500);
            IWebElement GoToTheLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToTheLastPage.Click();

            //Check the created edited Employee
            IWebElement UsernameEdited = driver.FindElement(By.Id("Username"));
            Assert.That(UsernameEdited.Text == "Username", "Username has not been edited");
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement GoToLast_Page = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToLast_Page.Click();

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid'000]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            DeleteButton.Click();

            //Click on OK
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            //Check deleted Employee

            IWebElement deletedUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(deletedUsername.Text == "Username", "Actual username and expected username do not match");
        }
    }    
}
