using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Pages
{
    public class SearchPodPage: TestBase
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='ej-checkbox one-way-checkbox']");

        public SearchPodPage(IWebDriver driver) : base()
        {
            Driver = driver;
            return;
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='ej-checkbox one-way-checkbox']")] private IWebElement OneWayCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[name='origin']")] private IWebElement OriginAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "input[name='destination']")] private IWebElement DestinationAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "button[ej-click-event='SubmitFlightSearch()']")] private IWebElement ShowFlightsButton;
        
        public void EnterOriginAirport()
        {
            OriginAirportTextField.SendKeys("LTN"+ Keys.Enter);
        }

        public void EnterDestinationAirportTextField()
        {
            DestinationAirportTextField.SendKeys("AMS" +Keys.Enter);
        }


    }
}
