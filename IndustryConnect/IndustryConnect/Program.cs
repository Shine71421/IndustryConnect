using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



// open chrome browser

IWebDriver driver = new ChromeDriver();
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

// check if the user logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if(helloHari.Text == "hello Hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}

// Navigate to Time & Material

IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
Thread.Sleep(500);

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

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

if(newCode.Text == "Nov2022")
{
    Console.WriteLine("new record has been created successfully.");
}
else
{
    Console.WriteLine(" time record hasn't been created successfully.");
}

