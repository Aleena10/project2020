using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using project20.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project20
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
            //add reference to Selenium
            // add reference to Chrome driver
            //open chrome driver


        }

        [SetUp]
        public void LoginSuccess()
        {
            //DEFINE DRIVER
            GlobalDriver.driver = new ChromeDriver();
            //open url
            GlobalDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            Loginpage login = new Loginpage();
            login.LoginSuccess(GlobalDriver.driver);
        }
        [Test]
        public void ClickCreateNewTest()
        {
            HomePage home = new HomePage();
            //verify that username is //a[@href='#'][contains(.,'Hello hari!')]
            home.VerifyUsername(GlobalDriver.driver);
            //Click on Administration button
            home.ClickAdministration(GlobalDriver.driver);
            //Click on Time & Materials button
            home.ClickTimeMaterials(GlobalDriver.driver);

            // click create new
            TimeMaterialsPage timeMaterial = new TimeMaterialsPage();
            timeMaterial.ClickCreateNew(GlobalDriver.driver);

            // enter valid information and click save
            timeMaterial.EnterValidDetails(GlobalDriver.driver);

        }
        [Test]
        public void EditTMTest()
        {
            HomePage home = new HomePage();
            //verify that username is //a[@href='#'][contains(.,'Hello hari!')]
            home.VerifyUsername(GlobalDriver.driver);
            //Click on Administration button
            home.ClickAdministration(GlobalDriver.driver);
            //Click on Time & Materials button
            home.ClickTimeMaterials(GlobalDriver.driver);

            TimeMaterialsPage tm = new TimeMaterialsPage();
            tm.EditTMRecord(GlobalDriver.driver);
        }
        [TearDown]
        public void FlushTests()
        {
            GlobalDriver.driver.Close();

        }
    }
}