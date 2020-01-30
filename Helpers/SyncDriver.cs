using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project20.Helpers
{
    class SyncDriver
    {
        //generic method to wait for a visibility of web element
        public static void WaitForElement(IWebDriver driver, string locator, string locatorvalue)
        {
            if (locator == "Id")
            {

                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));

            }
            {
                if (locator == "XPath")
                {

                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));

                }

                {
                    if (locator == "CSSSelector")
                    {

                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorvalue)));

                    }






                }

            }
        }
    }
}
