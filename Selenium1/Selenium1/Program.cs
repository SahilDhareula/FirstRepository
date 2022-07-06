﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Navigate chrome browser
IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
//Identify and Enter Username
IWebElement username = driver.FindElement(By.Id("UserName"));
username    .SendKeys("hari");
//Identify and Enter Password
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");
//Identify and Click on login
IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
login.Click();
// Check Successful login
IWebElement validUsername = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if (validUsername.Text == "Hello hari!")
{
    Console.WriteLine("LOGIN PASS");
}
else
{
    Console.WriteLine("LOGIN FAIL");
}