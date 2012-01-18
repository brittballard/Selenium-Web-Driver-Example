using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriverExample
{
    [TestClass]
    public class SeleniumWebDriver
    {
        [TestMethod]
        public void EampleOne()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://order.papajohns.com/storelocator/page.html");
            var streetAddress = driver.FindElement(By.Id("streetAddress"));
            streetAddress.SendKeys("3800 Commerce");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("75226");
            var searchButton = driver.FindElement(By.Id("mainSearchBtn"));
            searchButton.Click();
            var title = driver.Title;

            // driver.Quit();
        }
    }
}
