﻿using System;
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
    public class SignInTests :TestBase
    {
        [Test]
        public void LoginToPostBooking()
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);
            var signInPage = new SignInPage(driver);

            cookiePolicyDraw.ClickCloseButton();
            signInPage.ClickSignIn();

        }

    }
}
