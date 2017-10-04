using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Draws
{
    public class CookiePolicyDraw: TestBase
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section cookie-policy-drawer']");

        public CookiePolicyDraw(IWebDriver driver) : base( )
        {
            Driver = driver;
            return;
        }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement AcceptButton;
        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement CloseButton;
        
        public void ClickCloseButton()
        {
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(5);
            CloseButton.Click();
        }

    }
}
