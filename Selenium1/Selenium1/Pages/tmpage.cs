using NUnit.Framework;
using OpenQA.Selenium;
using Selenium1.Utilities;

namespace Selenium1.Pages
{
    public class tmpage
    {
        public void CreateTm(IWebDriver driver)
        {
            IWebElement CreateButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Thread.Sleep(2000);
            CreateButton.Click();

            //enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Spark");
            Thread.Sleep(1000);

            //enter description
            IWebElement descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys("Calls");

            //making price interactable
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.Click();

            //input price
            IWebElement priceTag = driver.FindElement(By.Id("Price"));
            priceTag.SendKeys("$20.00");

            //click on save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            Thread.Sleep(1500);
            saveButton.Click();
            Thread.Sleep(1000);

            //go to the last page
            IWebElement lastPageIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageIcon.Click();
            Thread.Sleep(2500);
        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void TmEdit(IWebDriver driver, string code,string description, string price)
        {
            Thread.Sleep(3500);
            IWebElement lastPageClickIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageClickIcon.Click();

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(2000);
            EditButton.Click();

            //click ,delete existing value and input code

            Thread.Sleep(2000);
            IWebElement editCodeButton = driver.FindElement(By.Id("Code"));
            editCodeButton.Click();
            editCodeButton.Clear();
            editCodeButton.SendKeys(code);
            Thread.Sleep(2000);

            //Edit and input description

            IWebElement editDescriptionButton = driver.FindElement(By.Id("Description"));
            editDescriptionButton.Click();
            editDescriptionButton.Clear();
            editDescriptionButton.SendKeys(description);
            Thread.Sleep(2000);

            //To make price interactable

            IWebElement PriceNew = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceNew = driver.FindElement(By.Id("Price"));
            PriceNew.Click();
            editPriceNew.Clear();
            PriceNew.Click();
            editPriceNew.SendKeys(price);
            Thread.Sleep(2000);

            //click on save

            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(2000);

            //go to last page to see the changes

            Thread.Sleep(3000);
            IWebElement gotoLastPageEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageEdit.Click();
        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement EditedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return EditedCode.Text;
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return EditedDescription.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement EditedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return EditedPrice.Text;
        }


        public void DeleteTm(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement lastPageClickIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastPageClickIcon.Click();

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();

            //Click on OK
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            WaitHelpers.WaitToBeClickable(driver, 5, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPATH");
        }
        public string GetDeletedCode(IWebDriver driver) 
        {
            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return deletedCode.Text;
        }
    }
}

