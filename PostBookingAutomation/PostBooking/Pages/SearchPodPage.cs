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
    public class SearchPodPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='ej-checkbox one-way-checkbox']");

        public SearchPodPage(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='ej-checkbox one-way-checkbox']")] private IWebElement OneWayCheckBox;
       //[FindsBy(How = How.CssSelector, Using = "input[id='one-way']")] private IWebElement OneWayCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[class='ej-input origin ui-autocomplete-input']")] private IWebElement OriginAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "input[class='ej-input destination ui-autocomplete-input']")] private IWebElement DestinationAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "div[class='route-date-picker-control']")] private IWebElement DepartingCalendar;
        //
        [FindsBy(How = How.CssSelector, Using = "button[ej-click-event='SubmitFlightSearch()']")] private IWebElement ShowFlightsButton;



        public void SelectOneWayCheckBox()
        {
            OneWayCheckBox.Click();
        }

        public void EnterOriginAirport()
        {
            OriginAirportTextField.Clear();
            OriginAirportTextField.SendKeys("LTN"+ Keys.Enter);
        }

        public void EnterDestinationAirportTextField()
        {
            DestinationAirportTextField.SendKeys("BCN" + Keys.Enter);
        }

        public void SelectDepartingCalendar()
        {
            DepartingCalendar.Click();
        }

    }
}
