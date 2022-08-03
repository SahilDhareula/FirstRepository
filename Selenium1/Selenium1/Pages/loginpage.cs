using NUnit.Framework;
namespace Selenium1.Pages
{
    public class loginpage
    {
        public static void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);
            try
            {
                //Identify and Enter Username
                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");

                //Identify and Enter Password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                //Identify and Click on login
                IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                login.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Turn Up Portal did not launch", ex.Message);
            }
            
            // Check Successful login
            IWebElement validUsername = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(validUsername.Text == "Hello hari!", "Login Fail");
        }
    }
}
