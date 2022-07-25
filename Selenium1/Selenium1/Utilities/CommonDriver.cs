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
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            loginpage loginObj = new loginpage();
            loginpage.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            // driver.Quit();
        }
    }
}