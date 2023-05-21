using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PizzaStoreTests
{
    internal class BaseTests
    {
        IWebDriver driver;

        protected IWebDriver GetDriver()
        {
            return driver;
        }
        [OneTimeSetUp]

        public void OneTimeSetup()
        {
            TestContext.Progress.WriteLine("One Time Setup Invoke.");
        }
        [SetUp]

        public void Setup()
        {
            driver = CreateDriver("chrome");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5182/");
        }
        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {
            TestContext.Progress.WriteLine("One Time Tear Down Invoke.");
        }

        private IWebDriver CreateDriver(string browserName)
        {
            switch (browserName.ToLowerInvariant())
            {
                case "chrome":
                    return new ChromeDriver();

                case "firefox":
                    return new FirefoxDriver();

                case "edge":
                    return new EdgeDriver();
                default:
                    throw new Exception("ERROR 404:BROWSER NOT SUPPORTED");
            }
        }
    }
}