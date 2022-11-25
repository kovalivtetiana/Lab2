using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace PageObject
{
    public class SaucedemoPage : BasePage
    {
        public SaucedemoPage(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        private IWebElement txtlogin => driver.FindElement(By.Id("user-name"));
        private IWebElement txtpassword => driver.FindElement(By.Id("password"));
        private IWebElement btnlogin => driver.FindElement(By.Id("login-button"));
        public void LoginPassword(string password)
        {
            txtpassword.SendKeys(password);
        }

        public void LoginUsername(string UserName)
        {
            txtlogin.SendKeys(UserName);
        }
        public void ClickLoginBtn() => btnlogin.Click();
        public void ClickToImg(string text) => driver.FindElement(By.XPath($"//div[contains(text(),'{text}')]")).Click();
        public IWebElement ButtonText(string text) => driver.FindElement(By.XPath($"//button[contains(text(),'{text}')]"));
    }
}

