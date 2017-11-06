using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Interfaces;
using PostBooking.Draws;

namespace PostBooking
{
    public class TestBase
    {
        public IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver.Navigate().GoToUrl("http://www.easyjet.com");
            //driver.Navigate().GoToUrl("https://uat2.tc-nonprod.easyjet.com/en/");
            //driver.Navigate().GoToUrl("http://www.119.test/TestPages/HomePage.html?lang=EN");
            driver.Navigate().GoToUrl("http://www.109.test/TestPages/HomePage.html?lang=EN");

        }

        [TearDown]
        public void TearDown()
        {
           // driver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           //driver.Quit();
        }


    }
}
