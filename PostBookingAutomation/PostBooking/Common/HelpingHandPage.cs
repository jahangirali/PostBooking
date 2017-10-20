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
    public class HelpingHandPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='title-content']");

        public HelpingHandPage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("button[class='ej-button rounded-corners']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement TitleLabel;
        [FindsBy(How = How.CssSelector, Using = "button[class='ej-button rounded-corners']")] private IWebElement ContinueButton;
        [FindsBy(How = How.CssSelector, Using = "button[class='button-link arrow-button']")] private IWebElement SkipButton;

        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }

        public void ClickSkipButton()
        {
            SkipButton.Click();
        }
    }
}
