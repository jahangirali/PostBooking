using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;

namespace PostBooking.Pages
{
    public class HoldLuggagePage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("input[ng-click='AddBagIfLimitNotReached(bagOption.Bag)']");

        public HoldLuggagePage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("input[ng-click='AddBagIfLimitNotReached(bagOption.Bag)']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[ng-click='AddBagIfLimitNotReached(bagOption.Bag)']")] private IWebElement kg15BagPlusButton;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement kg15BagMinusButton;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement kg23BagPlusPlus;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement kg23BagMinusButton;


        public void Click15BagPlusButton()
        {
            kg15BagPlusButton.Click();    
        }

        public void Click15BagMinusButton()
        {
            kg15BagMinusButton.Click();

        }


    }
}
