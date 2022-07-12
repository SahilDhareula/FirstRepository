using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium1.Pages;
//Initiate browser
IWebDriver driver = new ChromeDriver();
//Login Page Object initialisation and definition
loginpage loginObject = new loginpage();
loginObject.LoginActions(driver);
//Home Page Object initialisation and definition
homepage homeObject = new homepage();
homeObject.GotoTmPage(driver);
//Tm Page Object initialisation and definition
tmpage tmObject = new tmpage(); 
tmObject.CreateTm(driver);
tmObject.EditTm(driver);    
tmObject.DeleteTm(driver);


