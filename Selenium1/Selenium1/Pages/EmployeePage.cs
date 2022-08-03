using NUnit.Framework;


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
            usernameTextbox.SendKeys("Username");
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
            Thread.Sleep(2000);

            //click on back to list
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();

            //Go to last page to check the created employee
            Thread.Sleep(3000);
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //Check if employee has been created
            Thread.Sleep(3500);
            IWebElement validUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(validUsername.Text == "Saahil", "Unable to create Employee please create again");
        }
        public void EditEmployee(IWebDriver driver, string name, string username, string contact)
        {
            Thread.Sleep(2000);
            IWebElement GoToLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToLastPage.Click();

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            Thread.Sleep(2000);
            EditButton.Click();

            //Click on edit and make changes

            IWebElement NameTextbox = driver.FindElement(By.Id("Name"));
            NameTextbox.Click();
            NameTextbox.Clear();
            NameTextbox.SendKeys(name);
            Thread.Sleep(2000);

            IWebElement EditUsername = driver.FindElement(By.Id("Username"));
            EditUsername.Click();
            EditUsername.Clear();
            EditUsername.SendKeys(username);

            IWebElement EditContactButton = driver.FindElement(By.Id("EditContactButton"));
            EditContactButton.Click();
            driver.SwitchTo().Frame(0);



            Thread.Sleep(1000);
            IWebElement FirstNameTextbox = driver.FindElement(By.Id("FirstName"));
            FirstNameTextbox.Click();
            FirstNameTextbox.SendKeys("firstname");

            Thread.Sleep(1000);
            IWebElement LastNameTextbox = driver.FindElement(By.Id("LastName"));
            LastNameTextbox.Click();
            LastNameTextbox.SendKeys("lastname");

            Thread.Sleep(2000);
            IWebElement PhoneTextbox = driver.FindElement(By.Id("Phone"));
            PhoneTextbox.Click();
            PhoneTextbox.SendKeys("0217654567");

            Thread.Sleep(2500);
            IWebElement SaveContact = driver.FindElement(By.Id("submitButton"));
            SaveContact.Click();

            //Click on Save Button
            Thread.Sleep(2000);
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();

            //Go back to list
            Thread.Sleep(2000);
            IWebElement GoToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            GoToList.Click();

            //Go to the last Page
            Thread.Sleep(3000);
            IWebElement GoToTheLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToTheLastPage.Click();
            Thread.Sleep(2000);

            //Check the created edited Employee
            Thread.Sleep(3500);
            IWebElement UsernameEdited = driver.FindElement(By.Id("Username"));
            Assert.That(UsernameEdited.Text == "Username", "Username has not been edited");
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            Thread.Sleep(2500);
            IWebElement GoToLast_Page = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GoToLast_Page.Click();

            Thread.Sleep(2000);
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            DeleteButton.Click();

            //Click on OK
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            //Check deleted Employee

            Thread.Sleep(4000);
            IWebElement deletedUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(deletedUsername.Text != "Username", "Username could not be deleted");
        }
    }    
}
