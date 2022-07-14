using NUnit.Framework;
using OpenQA.Selenium;
namespace Selenium1.Pages
{
    public class tmpage
    {
        public void CreateTm(IWebDriver driver)
        {
            IWebElement CreateButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Thread.Sleep(1000);
            CreateButton.Click();
            
            //enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Tango");
            Thread.Sleep(1000);
            
            //enter description
            IWebElement descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys("Charlie");
            Thread.Sleep(1000);
            
            //making price interactable
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.Click();
            
            //input price
            IWebElement priceTag = driver.FindElement(By.Id("Price"));
            priceTag.SendKeys("20");
            Thread.Sleep(1000);
            
            //click on save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            Thread.Sleep(1500);
            saveButton.Click();
            
            Thread.Sleep(1000);
            //go to the last page
            IWebElement lastPageIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(1500);
            lastPageIcon.Click();
            Thread.Sleep(2000);
            
            //check successful record creation
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "Tango", "Actual code and Expected code do not match");
        }
        public void EditTm(IWebDriver driver)
        {
          IWebElement lastPageEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
          Thread.Sleep(1000);
          lastPageEdit.Click();
          
          //click ,delete existing value and input code
          IWebElement editCodeButton = driver.FindElement(By.Id("Code"));
          editCodeButton.Click();
          editCodeButton.Clear();
          editCodeButton.SendKeys("Tango1");
          Thread.Sleep(2000);
          
          //Edit and input description
          IWebElement editDescriptionButton = driver.FindElement(By.Id("Description"));
          editDescriptionButton.Click();
          editDescriptionButton.Clear();
          editDescriptionButton.SendKeys("Charlie1");
          Thread.Sleep(2000);
         
          //To make price interactable
          IWebElement PriceNew = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
          IWebElement editPrice = driver.FindElement(By.Id("Price")); 
          PriceNew.Click();
          editPrice.Clear();
          PriceNew.Click();
          editPrice.SendKeys("30");
          Thread.Sleep(2000);
          //click on save
          IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
          editSaveButton.Click();
          Thread.Sleep(1000);
          //go to last page to see changes
          IWebElement gotoLastPageEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
          gotoLastPageEdit.Click();
          Thread.Sleep(3000);
          //to check edited record
          IWebElement codeEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
          Assert.That(codeEdit.Text == "Tango1", "Code has not been Edited");
          
          IWebElement descEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
          Assert.That(descEdit.Text == "Charlie1", "Description has not been edited");
          
          IWebElement editPricey = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
          Assert.That(editPricey.Text == "$30.00", "Price has been successfully Edited");
        }
    public void DeleteTm(IWebDriver driver)
        { 
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            Thread.Sleep(1500);
            DeleteButton.Click();
            Thread.Sleep(1500);
            //Click on OK
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }
    }
}
