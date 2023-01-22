using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using LSportsHomeTask.covidIsraelisTest.Infra;

namespace LSportsHomeTask.covidIsraelisTest.tests
{
    public abstract class BaseTest
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito"); 
            Driver = new ChromeDriver(@"covidIsraelisTest\drivers", options);
            Driver.Manage().Window.Maximize();
 
            Wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(20000));
            ConsoleReporter.Log("Test start time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}

