using OpenQA.Selenium;
using Selenium1.Utilities;
namespace Selenium1.Pages
{ 
    public class homepage
    {
        public void GotoTmPage(IWebDriver driver)
        {
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            //select Time and material from dropdown
            IWebElement TimeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterial.Click();
        }
        public void GotoEmployeePage(IWebDriver driver)
        {
            IWebElement Employees = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employees.Click();
        }
     
    }
}
