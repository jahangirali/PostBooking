using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PostBooking.Pages
{
    public class SearchPodPage: TestBase
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='drawer-section sign-in']");

        public SearchPodPage(IWebDriver driver) : base()
        {
            Driver = driver;
            return;
        }

    }
}
