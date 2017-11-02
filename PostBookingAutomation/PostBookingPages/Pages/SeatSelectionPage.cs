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
    public class SeatSelectionPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='info-icon']");

        public SeatSelectionPage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("button[class='ej-button rounded-corners']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement TitleLabel;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement SpecialAssistanceRequestLink;
        [FindsBy(How = How.CssSelector, Using = "div[class='title-content']")] private IWebElement EasyJetPlusMembersLink;
        [FindsBy(How = How.CssSelector, Using = "button[class='SetFocussedElement($event);OpenTravellingWithChildrenDrawer()']")] private IWebElement TravellingWithChildrenLink;



    }
}
