using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;

namespace PostBooking.Pages
{
    public class SignInDraw //: TestBase
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section sign-in']");

        public SignInDraw(IWebDriver driver) : base( )
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "div[class='field-row ej-text ej-text-dark']")] private IWebElement RegisterHereLink;
        [FindsBy(How = How.Id, Using = "signin-username")] private IWebElement EmailAddress;
        [FindsBy(How = How.Id, Using = "signin-password")] private IWebElement Password;
        [FindsBy(How = How.Id, Using = "signin-login")] private IWebElement SignIn;


        public void ClickSignIn()
        {
            SignIn.Click();
        }

        public void ClickRegisterHereLink()
        {
            Waits.WaitForElement(Driver, PageSelector);
            RegisterHereLink.Click();
        }


    }
}
