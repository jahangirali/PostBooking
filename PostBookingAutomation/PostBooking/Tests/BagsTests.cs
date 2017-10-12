using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using PostBooking.Draws;
using PostBooking.Pages;

namespace PostBooking
{
    [TestFixture]
    public class BagsTests : TestBase
    {
        [Test]
        public void GoToBagsPage()
        {

            var cookiePolicyDraw = new CookiePolicyDraw(driver);

            cookiePolicyDraw.ClickAcceptButton();

            var searchPodPage = new SearchPodPage(driver);
            searchPodPage.SelectOneWayCheckBox();
            searchPodPage.EnterOriginAirport();
            searchPodPage.EnterDestinationAirportTextField();
            searchPodPage.SelectDepartingCalendar();


        }

    }
}
