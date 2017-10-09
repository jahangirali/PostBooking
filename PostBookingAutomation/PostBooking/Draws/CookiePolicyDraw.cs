﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Draws
{
    public class CookiePolicyDraw
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section cookie-policy-drawer']");

        public CookiePolicyDraw(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement AcceptButton;
        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement CloseButton;

        public void ClickCloseButton()
        {
           CloseButton.Click();
           //Driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(5);
        }

        public void ClickAcceptButton()
        {
            SwitchWindow(Driver);
            AcceptButton.Click();
            WaitUntilDrawerIsClosed();
        }

        private void SwitchWindow(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        private void WaitUntilDrawerIsClosed()
        {
            throw new NotImplementedException();
        }
    }
}
