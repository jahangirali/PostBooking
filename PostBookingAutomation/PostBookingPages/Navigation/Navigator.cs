using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;
using PostBooking.Common;
using PostBooking.Draws;
using PostBooking.Pages;

namespace PostBooking
{
    public static class Navigator
    {
        
        public static PickFlightsPage GoToPickFlightsPage(IWebDriver driver)
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);

            cookiePolicyDraw.ClickAcceptButton();

            var searchPodPage = new SearchPodPage(driver);

            searchPodPage.SelectOneWayCheckBox();
            searchPodPage.EnterOriginAirport();
            searchPodPage.EnterDestinationAirportTextField();
            searchPodPage.ClickDepartingCalendar();

            return new PickFlightsPage(driver);
        }

        public static void GoToSeatSelectionPage()
        {
                

        }

        public static void GoToHoldLuggagePage(IWebDriver driver)
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);

            cookiePolicyDraw.ClickAcceptButton();

            var searchPodPage = new SearchPodPage(driver);

            searchPodPage.SelectOneWayCheckBox();
            searchPodPage.EnterOriginAirport();
            searchPodPage.EnterDestinationAirportTextField();
            searchPodPage.ClickDepartingCalendar();

            var calendarDraw = new CalendarDraw(driver);
            calendarDraw.SelectCalendarDate(DateTime.UtcNow.AddDays(3));
            searchPodPage.ClickAddAdultButton();
            searchPodPage.ClickShowFlightsButton();

            var pickFlightsPage = new PickFlightsPage(driver);
            pickFlightsPage.SelectAFlight();

            var helpingHandPage = new HelpingHandPage(driver);
            helpingHandPage.ClickContinueButton();
            helpingHandPage.ClickSkipButton();

            var holdLuggagePage = new HoldLuggagePage(driver);
        }

    }
}
