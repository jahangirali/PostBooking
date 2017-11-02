using System;
using NUnit.Framework;
using PostBooking.Common;
using PostBooking.Draws;
using PostBooking.Pages;

namespace PostBooking.Tests
{
    [TestFixture]
    public class SearchPodPageTests : TestBase
    {
        [Test]
        public void SpecialAssistanceDrawOpens()
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
            holdLuggagePage.ClickAdd15kgBagButton();
            holdLuggagePage.ClickAdd15kgBagButton();
            holdLuggagePage.ClickAdd15kgBagButton();
            holdLuggagePage.ClickRemove15kgBagButton();
            holdLuggagePage.ClickAddSportsEquipmentButton();
            
        }

        [Test]
        public void DefaultValuesSearchPodPage()
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);
            cookiePolicyDraw.ClickAcceptButton();

            var searchPodPage = new SearchPodPage(driver);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(searchPodPage.IsTrueCheckBoxDisplayed());
                Assert.IsTrue(searchPodPage.IsOriginAirportDisplayed());
                Assert.IsTrue(searchPodPage.IsDestinationAirportDisplayed());
                Assert.IsTrue(searchPodPage.IsNoOfAdultsDisplayed());
                Assert.IsTrue(searchPodPage.IsNoOfChildrenDisplayed());
                Assert.IsTrue(searchPodPage.IsNoOfInfantsDisplayed());
                Assert.IsTrue(searchPodPage.IsShowFlightsButtonDisplayed());
            });
        }

    }
}
