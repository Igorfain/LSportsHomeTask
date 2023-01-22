using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            this.Driver = driver;
            this.Wait = wait;
        }
    }
}

