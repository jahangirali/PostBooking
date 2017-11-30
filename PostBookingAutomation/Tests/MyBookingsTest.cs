using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using PostBooking;
using PostBooking.Pages;

namespace Tests
{
    [TestFixture]
    public class MyBookingsTest:TestBase
    {
        [Test]
        public void LoginToManageBookings()
        {
            var loginPage = new LoginPage(driver);
            Thread.Sleep(2000);

            loginPage.LoggedIn();
            driver.Navigate().GoToUrl("https://www.132.test/EN/secure/MyEasyJet.mvc/AllBookings");
            var test = driver.FindElement(By.ClassName("allBookingItems")).GetAttribute("ET56GX");
            Console.WriteLine(test);
            
        }

    }
}
