using OpenQA.Selenium;

namespace IndustryConnect.Pages
{
    public class HomePage
    {

        public void GoToTMPage(IWebDriver driver)
        {
            // Navigate to Time & Material

            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        }

    
    }
}
