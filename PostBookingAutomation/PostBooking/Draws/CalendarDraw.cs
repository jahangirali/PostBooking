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
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section routedatepicker']");

        public CalendarDraw(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[class='drawer-tab-content-wrapper']")] private IWebElement CalendarList;
        [FindsBy(How = How.CssSelector, Using = "div[class='close-drawer-button']")] private IWebElement CloseDepartureDateDraw;

        public void SelectCalendarDate(DateTime calendarDate)
        {
            SelectDateFromList(calendarDate.ToString("yyyy-MM-dd")).Click();
        }
        private IWebElement SelectDateFromList(string dateTime)
        {
            return CalendarList.FindElement(By.CssSelector($"div[data-date='{dateTime}'] a"));
        }
    }
}
