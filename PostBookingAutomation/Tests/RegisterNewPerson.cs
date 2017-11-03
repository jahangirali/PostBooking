﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using PostBooking.Actions;
using PostBooking.Common;
using PostBooking.Draws;
using PostBooking.Pages;
using PostBookingPages.Pages;

namespace PostBooking.Tests
{
    public class RegisterNewPerson : TestBase
    {
        [Test]
        public void RegisterANewPerson()
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);
            cookiePolicyDraw.ClickAcceptButton();
            
            var mainHeaderPage = new MainHeaderPage(driver);
            mainHeaderPage.ClickManageBookingsLink();

            var loginPage = new LoginPage(driver);
            Thread.Sleep(2000);

            loginPage.ClickRegisterButton();

           // loginPage.LoggedIn();
           //var editAccountPage = new EditAccountPage(driver);
           // editAccountPage.ClickMyBookingsLink();

            //var searchPodPage = new SearchPodPage(driver);
            //searchPodPage.ClickSignIn();

            //var signInDraw = new SignInDraw(driver);
            //signInDraw.ClickRegisterHereLink();
        }
    }
}
