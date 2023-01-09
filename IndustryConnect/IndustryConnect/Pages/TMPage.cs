using OpenQA.Selenium;


namespace IndustryConnect.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // click on create new button

            Thread.Sleep(1500);
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
            createNewButton.Click();
            Thread.Sleep(500);


            // select time in the typecode dropdown

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            Thread.Sleep(1500);

            //enter code in the code textbox

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Nov2022");

            //enter description in the description text box

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Nov");

            //enter price in the price per unit textbox

            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlappingTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("10");

            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //check if new time record has been created

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "Nov2022")
            {
                Console.WriteLine("new record has been created successfully.");
            }
            else
            {
                Console.WriteLine(" time record hasn't been created successfully.");
            }


        }

        public void EditTM()
        {

        }

        public void DeleteTM()
        {

        }
       
    }
}
