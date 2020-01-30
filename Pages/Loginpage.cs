using OpenQA.Selenium;
using project20.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project20
{
    class Loginpage
    {
     
            public void LoginSuccess(IWebDriver driver)
            {

            //populate in collection
            ExcelLibHelpers.PopulateInCollection(@"C:\projects\Project 2020\project20\project20\TestData.xls", "LoginPage");

            //wait for username textbox
            SyncDriver.WaitForElement(driver, "Id", "UserName");

            // identify user name
            IWebElement userName = driver.FindElement(By.Id("UserName"));
                //Give username as hari
                userName.SendKeys(ExcelLibHelpers.ReadData(2,"Username"));
                //identify password and give its as 123123
                driver.FindElement(By.Id("Password")).SendKeys(ExcelLibHelpers.ReadData(2, "Password"));
                IWebElement loginbutton = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
                loginbutton.Click();
            }
        }

        
    }

        
    
  
    