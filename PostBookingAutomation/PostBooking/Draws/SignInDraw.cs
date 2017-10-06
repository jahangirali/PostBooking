using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Pages
{
    public class SignInDraw : TestBase
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section sign-in']");

        public SignInDraw(IWebDriver driver) : base( )
        {
            Driver = driver;
            return;
        }
        
        [FindsBy(How = How.Id, Using = "signin-username")] private IWebElement EmailAddress;
        [FindsBy(How = How.Id, Using = "signin-password")] private IWebElement Password;
        [FindsBy(How = How.Id, Using = "signin-login")] private IWebElement SignIn;


        public void ClickSignIn()
        {
            SignIn.Click();
        }


    }
}
