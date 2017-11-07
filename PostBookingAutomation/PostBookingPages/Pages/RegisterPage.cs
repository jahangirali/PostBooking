using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PostBooking.Actions;
using PostBookingPages.Data;

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
        [FindsBy(How = How.Id, Using = "TitleTypeCode")] private IWebElement TitleList;
        [FindsBy(How = How.CssSelector, Using = "input[id='FirstName']")] private IWebElement FirstNameField;
        [FindsBy(How = How.CssSelector, Using = "input[id='LastName']")] private IWebElement SurnameField;
        [FindsBy(How = How.CssSelector, Using = "input[id='Address1']")] private IWebElement Address1Field;
        [FindsBy(How = How.CssSelector, Using = "input[id='Address2']")] private IWebElement Address2Field;
        [FindsBy(How = How.CssSelector, Using = "input[id='City']")] private IWebElement TownCityField;
        [FindsBy(How = How.CssSelector, Using = "input[id='PostalCode']")] private IWebElement PostcodeField;
        [FindsBy(How = How.Id, Using = "Country")] private IWebElement CountryList;
        [FindsBy(How = How.CssSelector, Using = "input[id='MobilePhone']")] private IWebElement MobileNumberField;
        [FindsBy(How = How.CssSelector, Using = "div [id='btnRegister']")] private IWebElement RegisterNowButton;

        public void EnterCustomerDetails(Customer customer)
        {
            EnterEmailAddress(customer.EmailAddress);
            EnterEmailConfirmAddress(customer.EmailConfirmAddress);
            EnterPassword(customer.Password);
            EnterPasswordConfirm(customer.PasswordConfirm);
            ClickTitleList(customer.Title);
            EnterFirstName(customer.FirstName);
            EnterSurname(customer.Surname);
            EnterAddress1(customer.Address1);
            EnterAddress2(customer.Address2);
            EnterTownCity(customer.City);
            EnterPostcode(customer.Postcode);
            ClickCountryList(customer.Country);
            EnterMobileNumber(customer.MobileNumber);

            ClickRegisterNowButton();
        }

        private void EnterEmailAddress(string EmailAddress)
        {
            EmailAddressField.SendKeys(EmailAddress);
        }

        private void EnterEmailConfirmAddress(string EmailConfirmAddress)
        {
            EmailConfirmAddressField.SendKeys(EmailConfirmAddress);
        }

        private void EnterPassword(string Password)
        {
            PasswordField.SendKeys(Password);
        }

        private void EnterPasswordConfirm(string PasswordConfirm)
        {
            PasswordConfirmField.SendKeys(PasswordConfirm);
        }

        private void ClickTitleList(string Title)
        {
            TitleList.Click();
            SelectElement Titles = new SelectElement(TitleList);
            Titles.SelectByText(Title);
        }

        private void EnterFirstName(string FirstName)
        {
            FirstNameField.SendKeys(FirstName);
        }

        private void EnterSurname(string Surname)
        {
            SurnameField.SendKeys(Surname);
        }

        private void EnterAddress1(string Address1)
        {
            Address1Field.SendKeys(Address1);
        }

        private void EnterAddress2(string Address2)
        {
            Address2Field.SendKeys(Address2);
        }

        private void EnterTownCity(string City)
        {
            TownCityField.SendKeys(City);
        }

        private void EnterPostcode(string Postcode)
        {
            PostcodeField.SendKeys(Postcode);
        }

        private void ClickCountryList(string Country)
        {
            CountryList.Click();
            SelectElement Countries = new SelectElement(CountryList);
            Countries.SelectByText(Country);
        }

        private void EnterMobileNumber(string MobileNumber)
        {
            MobileNumberField.SendKeys(MobileNumber);   
        }

        private void ClickRegisterNowButton()
        {
            RegisterNowButton.Click();
        }
    }
}
