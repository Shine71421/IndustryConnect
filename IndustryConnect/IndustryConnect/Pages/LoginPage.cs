
using OpenQA.Selenium;


namespace IndustryConnect.Pages
{
    public class LoginPage
    { 
    public void LoginActions(IWebDriver driver)
    {
           
            driver.Manage().Window.Maximize();

            // launch turnup portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");


            // identify password textbox and enter valid password

            Thread.Sleep(1000);

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click login button

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }

    }
}