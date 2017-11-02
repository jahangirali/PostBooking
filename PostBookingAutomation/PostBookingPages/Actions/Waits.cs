using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace PostBooking.Actions
{
    public static class Waits
    {
        public static void WaitForDrawerToClose(IWebDriver driver)
        {
            //new WebDriverWait(driver, TimeSpan.FromSeconds("5"));

        }

        public static void WaitForElement(IWebDriver driver, By Selector)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(Selector));
        }
    }
}
