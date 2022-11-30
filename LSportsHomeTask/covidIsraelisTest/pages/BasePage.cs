﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public abstract class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(1));
            this.driver = driver;
            this.wait = wait;
        }
    }
}

