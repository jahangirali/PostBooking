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
        
        [FindsBy(How = How.CssSelector, Using = "span[class='checkbox-label-text']")] private IWebElement OneWayCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[class='ej-input origin ui-autocomplete-input']")] private IWebElement OriginAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "input[class='ej-input destination ui-autocomplete-input']")] private IWebElement DestinationAirportTextField;
        [FindsBy(How = How.CssSelector, Using = "div[class='route-date-picker-control']")] private IWebElement DepartingCalendar;
        [FindsBy(How = How.CssSelector, Using = "input[name='Adults']")] private IWebElement NoOfAdults;
        [FindsBy(How = How.CssSelector, Using = "input[name='Children']")] private IWebElement NoOfChildren;
        [FindsBy(How = How.CssSelector, Using = "input[id^='Infants']")] private IWebElement NoOfInfants;
        [FindsBy(How = How.CssSelector, Using = "button[class='quantity-button-add']")] private IWebElement PlusAdultButton;
        [FindsBy(How = How.CssSelector, Using = "button[ej-click-event='SubmitFlightSearch()']")] private IWebElement ShowFlightsButton;
        [FindsBy(How = How.CssSelector, Using = "button[class='special-assistance button-link arrow-button']")] private IWebElement SpecialAssistanceLink;
        
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

        public void EnterNoOfAdults()
        {
            NoOfAdults.SendKeys("");
        }

        public void EnterNoOfChildren()
        {
            NoOfChildren.SendKeys("1");
        }

        public void EnterNoOfInfant()
        {
            NoOfInfants.SendKeys("1");
        }

        public void ClickAddAdultButton()
        {
            PlusAdultButton.Click();
        }

        public void ClickShowFlightsButton()
        {
            ShowFlightsButton.Click();
        }

        public void ClickSpecialAssistanceLink()
        {
            SpecialAssistanceLink.Click();
        }

        public bool IsTrueCheckBoxDisplayed()
        {
            return OneWayCheckBox.Displayed;
        }

        public bool IsOriginAirportDisplayed()
        {
            return OriginAirportTextField.Displayed;
        }

        public bool IsDestinationAirportDisplayed()
        {
            return DestinationAirportTextField.Displayed;
        }

        public bool IsNoOfAdultsDisplayed()
        {
            return NoOfAdults.Displayed;
        }
        public bool IsNoOfChildrenDisplayed()
        {
            return NoOfAdults.Displayed;
        }
        public bool IsNoOfInfantsDisplayed()
        {
            return NoOfInfants.Displayed;
        }
        public bool IsShowFlightsButtonDisplayed()
        {
            return ShowFlightsButton.Displayed;
        }
    }
}
