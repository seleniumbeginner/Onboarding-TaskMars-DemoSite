using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Onboarding_TaskMars_DemoSite.pages
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
         }
       


        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtemail;


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtpassword;


        [FindsBy(How = How.TagName, Using = "button")]
        public IWebElement btnlogin;
    
        public void Login(string Email, string Password)
        {
            txtemail.SendKeys("Email");
            txtpassword.SendKeys("Password");
             }

        public ProfilePage ClickLogin()
        {
            btnlogin.Click();
            return new ProfilePage();
        }
    }

}

