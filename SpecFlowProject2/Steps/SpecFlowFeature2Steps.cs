using NUnit.Framework;
using OpenQA.Selenium;
using PageObject;
using SpecFlowProject2.Steps;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps : BaseStep
    {
        private SaucedemoPage sPage;
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            driver.Url = "https://www.saucedemo.com/";
            sPage = new SaucedemoPage(driver);
            Thread.Sleep(100);
        }

        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string Username)
        {
            sPage.LoginUsername(Username);
        }

        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string Password)
        {
            sPage.LoginPassword(Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            sPage.ClickLoginBtn();
            Thread.Sleep(100);
        }

        [When(@"Click on the photo of the ""(.*)""")]
        public void GivenClickOnThePhotoOfThe(string text)
        {
            sPage.ClickToImg(text);
            Thread.Sleep(100);
        }

        [Then(@"I see a button ""(.*)""")]
        public void ThenISeeAButton(string text)
        {
            IWebElement element = sPage.ButtonText(text);
            Assert.That(element,Is.Not.Null);
        }
    }
}
