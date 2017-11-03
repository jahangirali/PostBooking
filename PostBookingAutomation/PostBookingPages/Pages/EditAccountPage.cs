using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBookingPages.Pages
{
    public class EditAccountPage
    {

        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[id='LogOnPanel']");

        public EditAccountPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[id='YourBookingsLinkBreadcrumb']")] private IWebElement MyBookingsLink;


        public void ClickMyBookingsLink()
        {
            MyBookingsLink.Click();
        }
    }
}
