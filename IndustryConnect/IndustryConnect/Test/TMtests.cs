using IndustryConnect.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome driver 
IWebDriver driver= new ChromeDriver();

//Login Page object initialization and definition
LoginPage loginPageObj= new LoginPage();
loginPageObj.LoginActions(driver);

//Home page object initialization and definition

HomePage homePageObj= new HomePage();
homePageObj.GoToTMPage(driver);

//TM page object intializationa nd definition

TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

tmPageObj.EditTM(driver);

tmPageObj.DeleteTM(driver);










// check if the user logged in successfully
//IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

//if(helloHari.Text == "hello Hari!")
//{
//   Console.WriteLine("Logged in successfully, test passed.");
//}
//else
//{
// Console.WriteLine("Login failed, test failed.");
//}


