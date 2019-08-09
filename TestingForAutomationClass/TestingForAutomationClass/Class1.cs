using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingForAutomationClass
{
    [TestClass]
    public class Class1
    {

        [TestMethod]
        public void test()
        {
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //IWebElement ContactUsButton = driver.FindElement(By.Id("contact-link"));
            //ContactUsButton.Click();

            //IWebElement ContactDropDownList = driver.FindElement(By.Id("id_contact"));
            //SelectElement Selection = new SelectElement(ContactDropDownList);
            //Selection.SelectByText("Customer service");

            //IWebElement EmailTextField = driver.FindElement(By.Id("email"));
            //EmailTextField.SendKeys("joaquinjqn@gmail.com");

            //IWebElement OrderReferenceTextField = driver.FindElement(By.Id("id_order"));
            //OrderReferenceTextField.SendKeys("test");

            //IWebElement AttachmentTextField = driver.FindElement(By.Id("fileUpload"));
            //AttachmentTextField.SendKeys(@"C:\Users\joaquin.gonzales\Desktop\test.txt");

            //IWebElement TextArea = driver.FindElement(By.CssSelector("textarea[class='form-control']"));
            //TextArea.SendKeys("test");

            //IWebElement SendButton = driver.FindElement(By.Name("submitMessage"));
            //SendButton.Click();

            //IWebElement SuccessConfirmationMessage = driver.FindElement(By.CssSelector("p[class='alert alert-success']"));
            //string SuccessExpectedMessage = SuccessConfirmationMessage.Text;
            //string ExpectedMessage = "Your message has been successfully sent to our team.";
            //Assert.AreEqual(SuccessExpectedMessage, ExpectedMessage);
        }
    }
}
