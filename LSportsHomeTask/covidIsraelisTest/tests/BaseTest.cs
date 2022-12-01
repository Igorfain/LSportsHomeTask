using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using LSportsHomeTask.covidIsraelisTest.Infra;

namespace LSportsHomeTask.covidIsraelisTest.tests
{
    public abstract class BaseTest
    {

        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            driver = new ChromeDriver(@"C:\Users\IGR_2\source\repos\TestProject2\drivers", options);
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            ConsoleReporter.Log("Test start time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}

