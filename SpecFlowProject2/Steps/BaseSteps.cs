using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class BaseStep
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver(@"C:\Users\ірка\Desktop\L2specflow\TestResults\");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}


