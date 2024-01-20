using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationtesting.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickabele(IWebDriver driver, string locatorType, string locatorValue, int seconds); 

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
    }
}
