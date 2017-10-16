﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PostBooking.Draws;
using PostBooking.Pages;

namespace PostBooking.Tests
{
    [TestFixture]
    public class SearchPodPageTests: TestBase
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
            
            var calendarDraw = new CalendarDraw(driver);
            //calendarDraw.SelectCalendarDate();
            searchPodPage.ClickAddAdultButton();
            searchPodPage.ClickSpecialAssistanceLink();

            var specialAssistancePage = new SpecialAssistanceDraw(driver);
            //specialAssistancePage.ClickGotItThanksButton();
            specialAssistancePage.ClickCloseDrawButton();
        }

    }
}