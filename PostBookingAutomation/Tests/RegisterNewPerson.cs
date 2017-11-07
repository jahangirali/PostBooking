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
using PostBookingPages.Data;
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
            var customer = new Customer();
            registerPage.EnterCustomerDetails(customer);
            

        }
    }
}
