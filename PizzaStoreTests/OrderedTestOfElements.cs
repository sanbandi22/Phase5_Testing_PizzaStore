using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreTests
{
    
    internal class OrderedTestOfElements : BaseTests
    {
        [Test]
        public void SimpleTest()
        {
            GetDriver().FindElement(By.Id("Name")).SendKeys("Sanskar");
            GetDriver().FindElement(By.Id("UserName")).SendKeys("ImSanskar22");
            GetDriver().FindElement(By.Id("password")).SendKeys("Sanskarbandi@2206");
            GetDriver().FindElement(By.Id("Email")).SendKeys("sanskarbandi7@gmail.com");
            GetDriver().FindElement(By.Id("register-btn")).Click();
            Thread.Sleep(5000);
            GetDriver().FindElement(By.Id("UserName")).SendKeys("ImSanskar22");
            GetDriver().FindElement(By.Id("password")).SendKeys("Sanskarbandi@2206");
            GetDriver().FindElement(By.Id("loginbtn")).Click();
            Thread.Sleep(1000);
            GetDriver().FindElement(By.Id("avail-btn")).Click();
            Thread.Sleep(3000);
            GetDriver().FindElement(By.Id("view-btn")).Click();
            Thread.Sleep(4000);
            GetDriver().FindElement(By.Id("cart-btn")).Click();
            Thread.Sleep(1250);
            GetDriver().FindElement(By.Id("check-btn")).Click();
            Thread.Sleep(2500);
            GetDriver().FindElement(By.Id("UserName")).SendKeys("ImSanskar22");
            GetDriver().FindElement(By.Id("Email")).SendKeys("sanskarbandi7@gmail.com");
            GetDriver().FindElement(By.Id("Phone")).SendKeys("9407095992");
            GetDriver().FindElement(By.Id("Address")).SendKeys("Elite Anmol");
            Thread.Sleep(80000);
            var countryDropDown = GetDriver().FindElement(By.Id("country"));
            var countrySelectElement = new SelectElement(countryDropDown);
            countrySelectElement.SelectByText("India");
            Thread.Sleep(5000);
            var stateDropDown = GetDriver().FindElement(By.Id("state"));
            var stateSelectElement = new SelectElement(stateDropDown);
            stateSelectElement.SelectByText("Madhya Pradesh");
            GetDriver().FindElement(By.Id("Zip")).SendKeys("452016");
            Thread.Sleep(2000);
        }
    }
}