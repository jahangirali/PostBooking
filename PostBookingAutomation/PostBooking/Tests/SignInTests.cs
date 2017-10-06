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
    public class SignInTests : TestBase
    {
        [Test]
        public void GoToBagsPage()
        {

            var cookiePolicyDraw = new CookiePolicyDraw(driver);

            cookiePolicyDraw.ClickCloseButton();
            var searchPodPage = new SearchPodPage(driver);

            searchPodPage.EnterOriginAirport();
            searchPodPage.EnterDestinationAirportTextField();

            //var signInPage = new SignInDraw(driver);
            //signInPage.ClickSignIn();

        }

    }
}
