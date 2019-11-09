using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SpecflowDemo.Steps
{
    [Binding]
    public class LoginFeatureDatastepSteps
    {
        public IWebDriver driver;
        [Given(@"User is at the home page")]
        public void GivenUserIsAtTheHomePage()
        {

            //ChromeOptions options = new ChromeOptions();
            //options.BinaryLocation = "C:/Users/Sravan Ramanchi/Documents/Visual Studio 2015/Projects/SpecflowDemo/SpecflowDemo/Drivers";
            driver = new ChromeDriver(@"C:\Users\Sravan Ramanchi\Documents\Visual Studio 2015\Projects\SpecflowDemo\SpecflowDemo\Drivers");
            driver.Navigate().GoToUrl("https://se-aus-staging.azurewebsites.net");
        }
        
        [Given(@"Navigate to appropriate login page")]
        public void GivenNavigateToAppropriateLoginPage()
        {
            driver.FindElement(By.Id("lnkOrgPortal")).Click();
        }
        
        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            driver.FindElement(By.Id("txt_username")).SendKeys("Organisation");
            driver.FindElement(By.Id("txt_password")).SendKeys("x!M7D!xj3D9k");
            driver.FindElement(By.Id("btn_submit")).Click();
        }
        
        [When(@"user logout from the application")]
        public void WhenUserLogoutFromTheApplication()
        {
            driver.FindElement(By.Id("lnkLogout")).Click();
        }
        
        [Then(@"Successful login message should be displayed")]
        public void ThenSuccessfulLoginMessageShouldBeDisplayed()
        {
            true.Equals(driver.FindElement(By.Id("lnkLogout")).Displayed);
        }
        
        [Then(@"user should see a successful logout message")]
        public void ThenUserShouldSeeASuccessfulLogoutMessage()
        {
            true.Equals(driver.FindElement(By.Id("btn_submit")).Displayed);
        }

        [Then(@"I verify the username on the login screen")]
        public void ThenIVerifyTheUsernameOnTheLoginScreen()
        {
            Assert.Equals(driver.FindElement(By.ClassName("UserName")).Text, "RajKumar");
        }

    }
}
