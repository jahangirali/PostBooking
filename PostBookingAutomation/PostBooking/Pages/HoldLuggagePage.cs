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

        [FindsBy(How = How.CssSelector, Using = "input[ng-click='AddBagIfLimitNotReached(bagOption.Bag)']")] private IWebElement Add15kgBagButton;
        [FindsBy(How = How.CssSelector, Using = "div[aria-label='Remove bag']")] private IWebElement Remove15kgBagButton;
        [FindsBy(How = How.CssSelector, Using = "input[ng-click='AddBagIfLimitNotReached(bagOption.Bag)']")] private IWebElement Add23kgBagButton;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement Remove23kgBagButton;
        [FindsBy(How = How.CssSelector, Using = "input[ng-click='OnDifferentWeightButtonClick()']")] private IWebElement AddSportsEquipmentButton;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement SelectCabinBagOnlyDraw;
        //

        public void ClickAdd15kgBagButton()
        {
            Add15kgBagButton.Click();    
        }

        public void ClickRemove15kgBagButton()
        {
            Remove15kgBagButton.Click();

        }

        public void ClickAddSportsEquipmentButton()
        {
            AddSportsEquipmentButton.Click();
        }


    }
}
