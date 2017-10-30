using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;

namespace PostBooking.Pages
{
    public class RegisterPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("input[id='EmailAddress']");

        public RegisterPage(IWebDriver driver)
        {
            Driver = driver;
            Waits.WaitForElement(driver, By.CssSelector("input[id='EmailAddress']"));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[id='EmailAddress']")] private IWebElement EmailAddressField;
        [FindsBy(How = How.CssSelector, Using = "input[id='EmailAddressCheck']")] private IWebElement EmailConfirmAddressField;
        [FindsBy(How = How.CssSelector, Using = "input[id='Password']")] private IWebElement PasswordField;
        [FindsBy(How = How.CssSelector, Using = "input[id='PasswordCheck']")] private IWebElement PasswordConfirmField;
        [FindsBy(How = How.CssSelector, Using = "input[id='EmailAddressCheck']")] private IWebElement TitleList;
        [FindsBy(How = How.CssSelector, Using = "input[id='FirstName']")] private IWebElement FirstNameField;
        [FindsBy(How = How.CssSelector, Using = "input[id='LastName']")] private IWebElement SurnameField;
        [FindsBy(How = How.CssSelector, Using = "input[id='Address1']")] private IWebElement Address1Field;
        [FindsBy(How = How.CssSelector, Using = "input[id='Address2']")] private IWebElement Address2Field;
        [FindsBy(How = How.CssSelector, Using = "input[id='City']")] private IWebElement TownCityField;
        [FindsBy(How = How.CssSelector, Using = "input[id='PostalCode']")] private IWebElement PostcodeField;
        [FindsBy(How = How.CssSelector, Using = "input[id='Country']")] private IWebElement CountryField;
        [FindsBy(How = How.CssSelector, Using = "input[id='MobilePhone']")] private IWebElement MobileNumberField;
        [FindsBy(How = How.CssSelector, Using = "button[onclick='registerMember.SubmitForm()']")] private IWebElement RegisterNowButton;


        public void EnterEmailAddress()
        {
            EmailAddressField.SendKeys("jahangir.ali@easyjet.com");
        }

        public void EnterEmailConfirmAddress()
        {
            EmailConfirmAddressField.SendKeys("jahangir.ali@easyjet.com");
        }

        public void EnterPassword()
        {
            PasswordField.SendKeys("password");
        }

        public void EnterPasswordConfirm()
        {
            PasswordConfirmField.SendKeys("password");
        }

        public void EnterFirstName()
        {
            FirstNameField.SendKeys("Homer");
        }

        public void EnterSurname()
        {
            SurnameField.SendKeys("Simpson");
        }

        public void EnterAddress1()
        {
            Address1Field.SendKeys("123 High Street");
        }

        public void EnterAddress2()
        {
            Address2Field.SendKeys("");
        }

        public void EnterTown()
        {
            TownCityField.SendKeys("Luton");
        }

        public void EnterPostcode()
        {
            PostcodeField.SendKeys("LU1 1XP");
        }

        public void EnterMobileNumber()
        {
            MobileNumberField.SendKeys("0123456789");   
        }

        public void ClickRegisterNowButton()
        {
            RegisterNowButton.Click();
        }
    }
}
