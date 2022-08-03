using NUnit.Framework;
using Selenium1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDriver
    {
        homepage HomePageObj = new homepage();
        EmployeePage EmployeePageObj = new EmployeePage();

        [Test, Order(1), Description("Check if the user is able to create new employee")]
        public void CreateEmployee()
        {
            HomePageObj.GotoEmployeePage(driver);
            EmployeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if the user is able to edit new employee")]
        public void EditEmployee()
        {  
            HomePageObj.GotoEmployeePage(driver); 
            EmployeePageObj.EditEmployee(driver,"p0","p1","p2");
        }

        [Test, Order(3), Description("Check if the user is able to delete new employee")]
        public void DeleteEmployee()
        {
            HomePageObj.GotoEmployeePage(driver);
            EmployeePageObj.DeleteEmployee(driver);
        }
    }
}
