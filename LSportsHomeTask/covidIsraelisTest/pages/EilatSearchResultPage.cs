using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    internal class EilatSearchResultPage : BasePage
    {
        public EilatSearchResultPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void SelectVeryGoodCheckBox(IWebDriver driver, WebDriverWait wait)
        {
            //Thread.Sleep(200000);
            // (driver.FindElement(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']")))

            //if (driver.FindElement(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']")).Displayed)
            //{
            //    IWebElement closePopupButton = driver.FindElement(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']"));
            //    closePopupButton.Click(); 
            //}
            //else
            //{
            //    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //    js.ExecuteScript("window.scrollBy(0,2700)");
            //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]")));
            //    IWebElement veryGoodCheckBoxLocator = driver.FindElement(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]"));
            //    veryGoodCheckBoxLocator.Click();
            //}

            //IWebElement closePopupButton = driver.FindElement(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']"));
            //closePopupButton.Click();

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,2700)");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]")));
            IWebElement veryGoodCheckBoxLocator = driver.FindElement(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]"));
            veryGoodCheckBoxLocator.Click();
        }

        public void checkAllResultsAreEight(IWebDriver driver, WebDriverWait wait)
        {
            var locator = driver.FindElements(By.XPath(".//div[contains(text(),'8')]"));
            //locator.ToString().Count();
            Console.WriteLine(locator.Count());
            Assert.GreaterOrEqual(locator.ToString(), 8);
        }
    }
}
