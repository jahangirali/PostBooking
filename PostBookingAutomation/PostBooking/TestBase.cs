using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PostBooking
{
    public class TestBase
    {
        IWebDriver driver = new ChromeDriver();
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver.Navigate().GoToUrl("http://www.easyjet.com");           
        }

        [OneTimeTearDown]
        public void TearDown()
        {
           // driver.Quit();
        }


    }
}
