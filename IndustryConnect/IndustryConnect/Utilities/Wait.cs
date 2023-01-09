using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnect.Utilities
{
    public class Wait

    {
      public void WaitforWebElement(IWebDriver driver,string locator, string locatorvalue,int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            if(locator == "xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            
            }

            if(locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }

            if(locator == "CssSelector")
                {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));

            }


        }
    }   
}
