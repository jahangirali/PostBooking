﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PostBooking.Actions;

namespace PostBooking.Pages
{
    public class PickFlightsPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='ej-checkbox one-way-checkbox']");

        public PickFlightsPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "span[class='checkbox-label-text']")] private IWebElement ShowFlexiCheckBox; 
        [FindsBy(How = How.CssSelector, Using = "button[class='ej-button rounded-corners']")] private IWebElement ContinueButton;

        public void SelectShowFlexiCheckBox()
        {
            ShowFlexiCheckBox.Click();
        }

        public void SelectContinueButton()
        {
            ContinueButton.Click();
        }

    }
}
