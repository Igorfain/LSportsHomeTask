using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public class EilatSearchResultPage : BasePage
    {

        public EilatSearchResultPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public EilatSearchResultPage SelectVeryGoodCheckBox(IWebDriver driver, WebDriverWait wait)
        {
            driver.Navigate().Refresh();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='submit']")));
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,2700)");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]")));
            IWebElement veryGoodCheckBoxElement = driver.FindElement(By.XPath("(//div[@data-filters-group='review_score']//div[@data-filters-item='review_score:review_score=80'])[1]"));
            veryGoodCheckBoxElement.Click();

            return this;

        }

        public bool VerifyAllResultsAreEightAndUp(IWebDriver driver, WebDriverWait wait, double score)
        {
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-testid='review-score']//div[contains(@aria-label,'Scored')]")));
            var elements = driver.FindElements(By.XPath("//div[@data-testid='review-score']//div[contains(@aria-label,'Scored ')]"));
           
            for (int i=0; i < elements.Count; i++)
            {
                double elementScore = Convert.ToDouble(elements[i].Text);
                if (score > elementScore) {
                    Console.WriteLine($"The score of the element is {elementScore} lower than {score}");
                    return false;
                }
            }
            return true;
        }


    }
}
