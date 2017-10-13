using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Draws
{
    public class CalendarDraw
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[id='drawer-title']");

        public CalendarDraw(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[class='21']")] private IWebElement SelectDate;
        [FindsBy(How = How.CssSelector, Using = "div[class='close-drawer-button']")] private IWebElement CloseDepartureDateDraw;

        public void SelectCalendarDate()
        {
            //TODO: Action to select a date. 
        }

        public void CloseCalendarDateDraw()
        {
            CloseDepartureDateDraw.Click();
        }
    }
}
