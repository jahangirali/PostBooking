using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using PostBooking.Draws;
using PostBooking.Pages;


namespace PostBooking.Tests
{
    public class HoldLuggagePageTests : TestBase
    {
        [Test]
        public void MaxHoldLuggae()
        {
            var pickflight = Navigator.GoToPickFlightsPage(driver);
            //var holdLuggagePage = new HoldLuggagePage();
            //var cookiePolicyDraw = new CookiePolicyDraw(driver);
        }
    }
}
