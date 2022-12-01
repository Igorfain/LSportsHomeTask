using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public class EilatSearchResultPage : BasePage
    {

        public EilatSearchResultPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public EilatSearchResultPage SelectVeryGoodCheckBox(IWebDriver driver, WebDriverWait wait)
        {
            //var closePopupButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']")));
            //// closePopupButton.Click();
            //if (closePopupButton.Equals(closePopupButton))

            //{
            //    //IWebElement closePopupButton = driver.FindElement(By.XPath("//div//button[@aria-label='Dismiss sign-in info.']"));
            //    closePopupButton.Click();
            //}

            driver.Navigate().Refresh();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,2700)");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]")));
            IWebElement veryGoodCheckBoxLocator = driver.FindElement(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]"));
            veryGoodCheckBoxLocator.Click();

            return this;

        }

        public EilatSearchResultPage CheckAllResultsAreEight(IWebDriver driver, WebDriverWait wait)
        {
            var locator = driver.FindElements(By.XPath(".//div[contains(text(),'8')]"));
            Console.WriteLine("The count of results with 8+ are : " + locator.Count());
   
            return this;
        }


    }
}
