using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Framework.BaseFramework
{
    public class WebDriverBase
    {
        private IWebDriver driver = null;
        private TimeSpan waitForElementTime = TimeSpan.FromSeconds(5);

        public WebDriverBase()
        {
            driver = new ChromeDriver(@"C:\Users\joaquin.gonzales\Desktop\drivers");      
        }

        public void Start(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.Navigate();
        }

        public void Stop()
        {
            driver.Quit();
        }

        public IWebElement FindElement(By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitForElementTime);
                return wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch
            {
                return null;
            }
        }
    }
}
