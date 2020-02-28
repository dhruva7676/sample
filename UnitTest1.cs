using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;

namespace PAIS
{
    [TestFixture]
    public class SRN
    {
        [Test]
        public void SR()
        {
            string Url = "http://www.google.com/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);


            //driver.FindElement(By.Id("fakebox-input")).SendKeys("selenium");
            Task.Delay(2000).Wait();
            driver.Close();
        }
    }
}