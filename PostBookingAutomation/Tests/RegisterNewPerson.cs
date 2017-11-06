using System;
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

            var registerPage = new RegisterPage(driver);
            registerPage.EnterEmailAddress();
            registerPage.EnterEmailConfirmAddress();
            registerPage.EnterPassword();
            registerPage.EnterPasswordConfirm();
            registerPage.EnterFirstName();
            registerPage.EnterSurname();
            registerPage.EnterAddress1();
            registerPage.EnterAddress2();
            registerPage.EnterTownCity();
            registerPage.EnterPostcode();
            registerPage.EnterMobileNumber();
            registerPage.ClickRegisterNowButton();

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
