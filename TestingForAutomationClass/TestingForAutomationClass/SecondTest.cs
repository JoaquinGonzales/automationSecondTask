using Automation_Framework.BaseFramework;
using Automation_Framework.Page_Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingForAutomationClass
{
    [TestClass]
    public class SecondTest 
    {
        Random r;
        [TestMethod]
        /*This test is going to test the functionality to create a new account*/
        public void secondTest()
        {
            WebDriverBase driver = new WebDriverBase();
            driver.Start("http://automationpractice.com/index.php");
            MenuPage menu = new MenuPage(driver);
            menu.clickSignInButton();
            //LoginPage loginPage = new LoginPage();

            //r = new Random(DateTime.Now.Millisecond);
            //int number = r.Next();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //IWebElement SingInButton = driver.FindElement(By.XPath("//div[@class='header_user_info']/a"));
            //SingInButton.Click();

           // IWebElement EmailInput = driver.FindElement(By.Id("email_create"));
           // string EmailAddress = "joaquin" + number.ToString() + "@Test.com";
           // Console.WriteLine(EmailAddress);
           // EmailInput.SendKeys(EmailAddress);

           // IWebElement SendButton = driver.FindElement(By.Id("SubmitCreate"));
           // SendButton.Click();


           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // IWebElement RadioButton = driver.FindElement(By.XPath("//div[@class='radio']/span/input[@id='id_gender1']"));
           

           ///*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           // wait.Until(ExpectedConditions.ElementToBeClickable(RadioButton));*/
           // RadioButton.Click();


           // IWebElement FirstNameField = driver.FindElement(By.Id("customer_firstname"));
           // FirstNameField.SendKeys("Joaquin");
           // /**/
           // IWebElement LastNameField = driver.FindElement(By.Name("customer_lastname"));
           // LastNameField.SendKeys("Gonzales");

           // IWebElement PasswordField = driver.FindElement(By.XPath("//input[@data-validate='isPasswd']"));
           // PasswordField.SendKeys("Test123");

           // IWebElement DayDropDown = driver.FindElement(By.Id("days"));
           // SelectElement SelectForDay = new SelectElement(DayDropDown);
           // SelectForDay.SelectByValue("26");

           // IWebElement MonthDropDown = driver.FindElement(By.Id("months"));
           // SelectElement SelectForMonth = new SelectElement(MonthDropDown);
           // SelectForMonth.SelectByValue("7");

           // IWebElement YearDropDown = driver.FindElement(By.Id("years"));
           // SelectElement SelectForYear = new SelectElement(YearDropDown);
           // SelectForYear.SelectByValue("1990");

           // IWebElement NewsLetterCheckBox = driver.FindElement(By.Name("newsletter"));
           // NewsLetterCheckBox.Click();

           // IWebElement OtherCheckBox = driver.FindElement(By.Id("optin"));
           // OtherCheckBox.Click();

           // IWebElement FirstName = driver.FindElement(By.Id("firstname"));
           // FirstName.SendKeys("Joaquin");

           // IWebElement LastName = driver.FindElement(By.Id("lastname"));
           // LastName.SendKeys("Gonzales");

           // IWebElement Company = driver.FindElement(By.Id("company"));
           // Company.SendKeys("ASSURESOFT");

           // IWebElement Adrress = driver.FindElement(By.Id("address1"));
           // Adrress.SendKeys("ASSURESOFT");

           // IWebElement City = driver.FindElement(By.Name("city"));
           // City.SendKeys("COCHA");

           // IWebElement State = driver.FindElement(By.Id("id_state"));
           // SelectElement SelectState = new SelectElement(State);
           // SelectState.SelectByText("Louisiana");

           // IWebElement ZipCode = driver.FindElement(By.Id("postcode"));
           // ZipCode.SendKeys("00000");

           // IWebElement SelectCountryDropDown = driver.FindElement(By.Id("id_country"));
           // SelectElement SelectCountry = new SelectElement(SelectCountryDropDown);
           // SelectCountry.SelectByValue("21");

           // IWebElement OtherInformation = driver.FindElement(By.Name("other"));
           // OtherInformation.SendKeys("Test other info");

           // IWebElement HomePhone = driver.FindElement(By.Name("phone"));
           // HomePhone.SendKeys("4471939");

           // IWebElement CellNumber = driver.FindElement(By.Id("phone_mobile"));
           // CellNumber.SendKeys("73773296");

           // IWebElement Alias = driver.FindElement(By.Id("alias"));
           // Alias.SendKeys("TestAlias");

           // IWebElement SendAccountButton = driver.FindElement(By.Id("submitAccount"));
           // SendAccountButton.Click();

           // IWebElement MyAccountMessage = driver.FindElement(By.XPath("//p[@class='info-account']"));
           // string ActualMessage = MyAccountMessage.Text;
           // string ExpectedMessage = "Welcome to your account. Here you can manage all of your personal information and orders.";

           // Assert.AreEqual(ActualMessage, ExpectedMessage);

        }
    }
}
