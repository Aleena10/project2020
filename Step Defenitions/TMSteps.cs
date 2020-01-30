using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project20.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project20.Step_Defenitions
{

    [Binding]
    public class TMSteps
    {

        

        [Given(@"I have logged into turnup portal")]
        public void GivenIHaveLoggedIntoTurnupPortal()
        {
            //DEFINE DRIVER
            GlobalDriver.driver = new ChromeDriver();
            //open url
            GlobalDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            Loginpage login = new Loginpage();
            login.LoginSuccess(GlobalDriver.driver);
        }
        
        [Given(@"I have navigated to time and materials page")]
        public void GivenIHaveNavigatedToTimeAndMaterialsPage()
        {
            HomePage home = new HomePage();
            //verify that username is //a[@href='#'][contains(.,'Hello hari!')]
            home.VerifyUsername(GlobalDriver.driver);
            //Click on Administration button
            home.ClickAdministration(GlobalDriver.driver);
            //Click on Time & Materials button
            home.ClickTimeMaterials(GlobalDriver.driver);
        }
        
        [Then(@"I should be able to add time and materials succesfully")]
        public void ThenIShouldBeAbleToAddTimeAndMaterialsSuccesfully()
        {
            // click create new
            TimeMaterialsPage timeMaterial = new TimeMaterialsPage();
            timeMaterial.ClickCreateNew(GlobalDriver.driver);
            
        }
    }
}
