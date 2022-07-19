using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver; // creating webdriver and use this everywhere else 

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            loginpage loginObject = new loginpage();
            loginpage.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            //driver.Quit();
        }
    }
}