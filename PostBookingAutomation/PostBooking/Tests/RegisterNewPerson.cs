using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PostBooking.Actions;
using PostBooking.Draws;
using PostBooking.Pages;

namespace PostBooking.Tests
{
    public class RegisterNewPerson : TestBase
    {
        [Test]
        public void RegisterANewPerson()
        {
            var cookiePolicyDraw = new CookiePolicyDraw(driver);
            cookiePolicyDraw.ClickAcceptButton();
            
            var searchPodPage = new SearchPodPage(driver);
            searchPodPage.ClickSignIn();

            var signInDraw = new SignInDraw(driver);
            signInDraw.ClickRegisterHereLink();
        }
    }
}
