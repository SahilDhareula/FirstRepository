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
            codeTextbox.SendKeys("Tango");
            Thread.Sleep(1000);

            //enter description
            IWebElement descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys("Charlie");

            //making price interactable
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.Click();

            //input price
            IWebElement priceTag = driver.FindElement(By.Id("Price"));
            priceTag.SendKeys("20");

            //click on save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            Thread.Sleep(1500);
            saveButton.Click();

            Thread.Sleep(1000);
            //go to the last page
            IWebElement lastPageIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(1500);
            lastPageIcon.Click();
            Thread.Sleep(1500);

            //check successful record creation
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "Tango", "Material Record has not been created");
        }
        public void EditTm(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement lastPageClickIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastPageClickIcon.Click();

            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findCodeRecordCreated.Text == "Tango")
            {
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Assert.Fail("Record to be edited not Found");
            }

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
            IWebElement editPriceNew = driver.FindElement(By.Id("Price"));
            PriceNew.Click();
            editPriceNew.Clear();
            PriceNew.Click();
            editPriceNew.SendKeys("30");
            Thread.Sleep(2000);

            //click on save

            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(2000);

            //go to last page to see the changes

            IWebElement gotoLastPageEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageEdit.Click();
            Thread.Sleep(2000);

            //to check the edited record

            IWebElement codeEdited = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement typeCodeEdited = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement descEdited = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(codeEdited.Text == "Tango1", "Code has not been edited");
            Assert.That(typeCodeEdited.Text == "M", "Actual Typecode and expected typecode do not match");
            Assert.That(descEdited.Text == "Charlie1", "Actual description and expected description do not match");
            Assert.That(editedPrice.Text == "$30.00", "Actual price and expected price do not match");
        }
        public void DeleteTm(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement lastPageClickIcon = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastPageClickIcon.Click();

            IWebElement recordToBeDeleted = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (recordToBeDeleted.Text == "Tango1")
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(1000);

                //Click on OK
                Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();

            }
            else
            {
                Assert.Fail("Record to be deleted not found");
            }

            ////to check deleted record

            //IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement deletedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assert.That(deletedCode.Text != "Tango1", "Actual code and expected code do not match");
            //Assert.That(deletedTypeCode.Text != "M", "Actual Typecode and expected typecode do not match");
            //Assert.That(deletedDescription.Text != "Charlie1", "Actual description and expected description do not match");
            //Assert.That(deletedPrice.Text != "$30.00", "Actual price and expected price do not match");
        }
    }
}

