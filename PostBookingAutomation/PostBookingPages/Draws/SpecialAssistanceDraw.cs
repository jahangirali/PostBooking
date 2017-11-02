using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Draws
{
    public class SpecialAssistanceDraw
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[id='drawer-dialog']");

        public SpecialAssistanceDraw(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);       
        }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoConfirm()']")] private IWebElement GotItThanksButton;
        [FindsBy(How = How.CssSelector, Using = "#close-drawer-link img")] private IWebElement CloseDrawButton;
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/help/preparing-to-fly/special-assistance']")] private IWebElement ReducedMobilityLink;
        [FindsBy(How = How.CssSelector, Using = "div[class='message-drawer-content'] a[href$='SignIn']")] private IWebElement ManageBookingsLink;
        
        public void ClickCloseDrawButton()
        {
            CloseDrawButton.Click();
        }

        public void ClickManageBookingsLink()
        {
            ManageBookingsLink.Click();
        }

        public void ClickReducedMobilityLink()
        {
            ReducedMobilityLink.Click();
        }

        public void ClickGotItThanksButton()
        {
            GotItThanksButton.Click();
        }

       
    }
}
