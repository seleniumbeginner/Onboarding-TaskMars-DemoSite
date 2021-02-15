using Onboarding_TaskMars_DemoSite.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Onboarding_TaskMars_DemoSite.feature
{
    [Binding]
    public class MarsDemoWebsiteFeaturesSteps
    {

        IWebDriver driver;
        LoginPage Mars;

        [Given(@"User is at Home Page(.*)")]
        public void GivenUserIsAtHomePage(int p0)
        {
            driver = new ChromeDriver();
            Mars = new LoginPage(driver);
        }
        
        [Given(@"Navigate to Login Page")]
        public void GivenNavigateToLoginPage()
        {
            driver.Url = "http://localhost:5000/Home";

        }


     
        [When(@"I click login button I navigate to login page")]
        public void WhenIClickLoginButtonINavigateToLoginPage()
        {
            driver.FindElement(By.LinkText ("Sign In")).Click();
        }

        //  

        //[Given(@"User types enter '(.*)' and '(.*)'")]
        //public void GivenUserTypesEnterAnd(string email, string password)
        //{
        //    
        //}
        //  ||dds|
        [Given(@"User types enter")]
        public void GivenUserTypesEnter()
        {
            Mars.Login("limpdon@hotmail.com", "12345");
        }



        [Given(@"I click Login button")]
        public void GivenIClickLoginButton()
        {
            driver.FindElement(By.TagName("button")).Click();
            //currentDriver.FindElement(By.TagName("button")).Click();
        }

        //[Then(@"I am  on profile Page")]
        //public void ThenIAmOnProfilePage()
        //{
        //    IWebElement element = currentDriver.FindElement(By.TagName("a"));
        //    Console.WriteLine(element.Displayed);
        //    Console.ReadLine();
        //}

        //[Given(@"User Click language Add New teal button enter following details")]
        //public void GivenUserClickLanguageAddNewTealButtonEnterFollowingDetails(Table table)
        //{
        //    currentDriver.FindElement(By.TagName("div")).Click();

        //}

        //[Then(@"Add New teal button should disappear")]
        //public void ThenAddNewTealButtonShouldDisappear()
        //{
        //    IWebElement element = currentDriver.FindElement(By.TagName("div"));
        //    Console.WriteLine(element.Displayed);
        //    Console.ReadLine();
        //}

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            driver = new ChromeDriver();
            Mars = new LoginPage(driver);
        }

        [When(@"i navigate to login page")]
        public void WhenINavigateToLoginPage()
        {
            driver.Url = "http://www.googl.com";
        }

        [When(@"enter user credentials '(.*)','(.*)'  and click login")]
        public void WhenEnterUserCredentialsAndClickLogin(string user,string password)
        {
            Mars.Login(user, password);
        }

        [Then(@"user is able to login")]
        public void ThenUserIsAbleToLogin()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
