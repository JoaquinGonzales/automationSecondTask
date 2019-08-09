using Automation_Framework.BaseFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Framework.Page_Object
{
    public class MenuPage
    {
        private WebDriverBase driver;
        public MenuPage(WebDriverBase driver)
        {
            this.driver = driver;
        }
        public void clickSignInButton()
        {
            IWebElement SingInButton = driver.FindElement(By.XPath("//div[@class='header_user_info']/a"));
            SingInButton.Click();
        }
    }

}
