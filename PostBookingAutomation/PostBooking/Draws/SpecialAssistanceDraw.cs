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
        [FindsBy(How = How.CssSelector, Using = "button[id='close-drawer-link']")] private IWebElement CloseDrawButton;
        //close-drawer-link
        public void ClickGotItThanksButton()
        {
            GotItThanksButton.Click();
        }

        public void ClickCloseDrawButton()
        {
            CloseDrawButton.Click();
        }


    }
}
