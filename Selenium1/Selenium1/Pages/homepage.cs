using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.Pages
{
    public class homepage
    { 
        public void GotoTmPage(IWebDriver driver)
        {
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            Thread.Sleep(1000);
            //click on Time and material
            IWebElement TimeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterial.Click();
            Thread.Sleep(1000);
        }
    }
}
