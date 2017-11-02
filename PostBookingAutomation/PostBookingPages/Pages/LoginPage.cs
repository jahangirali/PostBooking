using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBooking.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("input[id='emailaddress']");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[id='emailaddress']")] private IWebElement EmailAddressField;
        [FindsBy(How = How.CssSelector, Using = "input[id='password']")] private IWebElement PasswordField;
        [FindsBy(How = How.CssSelector, Using = "input[id='memberbookingreference']")] private IWebElement BookingReferenceField;
        [FindsBy(How = How.CssSelector, Using = "a[id='register-button']")] private IWebElement RegisterButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='sign-in-button']")] private IWebElement SignInButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='memberbookingreference']")] private IWebElement ForgottenPasswordLink;



    }
}
