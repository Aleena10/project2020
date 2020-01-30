using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project20
{

    class TimeMaterialsPage
    {
        internal void ClickCreateNew(IWebDriver driver)


        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }

        internal void EnterValidDetails(IWebDriver driver)
        {
            //enter valid details
            driver.FindElement(By.Id("Code")).SendKeys("file1993");
            driver.FindElement(By.Name("Description")).SendKeys("DEMO1");

            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("1000");
            driver.FindElement(By.Id("SaveButton")).Click();
        }

            public void VerifyRecord(IWebDriver driver)
            {
                Console.WriteLine("Do the validations here");
            }

            public void EditTMRecord(IWebDriver driver)
            {
                //Implement the lines of code to test edit funtionality



            }



        }
    }
