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
        private static readonly By PageSelector = By.CssSelector("div[class='main-header']");

        public MainHeaderPage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("div[class='main-header']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".main-navigation-group a[href$='SignIn']")] private IWebElement ManageBookingsLink;


        public void ClickManageBookingsLink()
        {
            Waits.WaitForElement(Driver, ManageBookingsLink);

            OpenQA.Selenium.Interactions.Actions act = new OpenQA.Selenium.Interactions.Actions(Driver);
            act.MoveToElement(ManageBookingsLink);
            act.Perform();

            ManageBookingsLink.Click();
            

        }
    }
}
