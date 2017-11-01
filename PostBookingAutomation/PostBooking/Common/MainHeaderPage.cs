using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;

namespace PostBooking.Common
{
    public class MainHeaderPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='inner-main-header']");

        public MainHeaderPage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("div[class='inner-main-header']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.easyjet.com/EN/secure/MyEasyJet.mvc/SignIn']")] private IWebElement ManageBookingsLink;


        public void ClickManageBookingsLink()
        {
            ManageBookingsLink.Click();
        }
    }
}
