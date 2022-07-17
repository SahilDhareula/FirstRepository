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

            //Input Name
            IWebElement nameTexbox = driver.FindElement(By.Id("Name"));
            nameTexbox.SendKeys("Saahil");

            //Input Username
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("Saahil");

            //Input Contact
            IWebElement contactTextbox = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
            contactTextbox.SendKeys("0218786765");

            //Input Password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("P@ssw0rd123456");

            //Re-type Password
            IWebElement reTypePassword = driver.FindElement(By.Id("RetypePassword"));
            reTypePassword.SendKeys("P@ssw0rd123456");

            //Select Checkbox
            IWebElement isAdmincheckbox = driver.FindElement(By.Id("IsAdmin"));
            isAdmincheckbox.Click();

            //Input Vehicle
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("car");

            //Select Groups from Dropdown
            IWebElement groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();
            groupDropdown.Click();

            //Click on Save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //click on back to list
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();

            //Go to last page to check the created employee
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //Check if employee has been created
            IWebElement validUsername = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(validUsername.Text == "Saahil!", "Unable to create Employee please try again");

        }
        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement EditEmpButton = driver.FindElement(By.XPath(""));

        }
        public void DeleteEmployee(IWebDriver driver)
        {

        }



    }    
    
}
