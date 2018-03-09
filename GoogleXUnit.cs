using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System.Threading;

namespace WebDriverDotNetCore
{
    public class GoogleXUnit
    {
        [Fact]
        public void TestWithFirefoxDriver()
        {
            using (var driver = new FirefoxDriver())
            {
                driver.Url = "http://www.google.com";
                driver.FindElement(By.Name("q")).SendKeys("Mitrais");
                driver.FindElement(By.Name("q")).Submit();
                Thread.Sleep(5000);
                driver.Close();
            }
        }

        [Fact]
        public void TestWithEdgeDriver()
        {
            using (var driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Url = "http://www.google.com";
                driver.FindElement(By.Name("q")).SendKeys("Mitrais");
                driver.FindElement(By.Name("q")).Submit();
                Thread.Sleep(5000);
                driver.Close();
            }
        }

        [Fact]
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Url = "http://www.google.com";
                driver.FindElement(By.Name("q")).SendKeys("Mitrais");
                driver.FindElement(By.Name("q")).Submit();
                Thread.Sleep(5000);
                driver.Close();
            }
        }
    }
}