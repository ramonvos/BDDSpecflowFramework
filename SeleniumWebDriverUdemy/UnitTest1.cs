    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using SeleniumWebDriverUdemy.Configuration;
using SeleniumWebDriverUdemy.Interfaces;

namespace SeleniumWebDriverUdemy
{
    [TestClass]
    public class UnitTest1
    {
        String pathFirefoxDriver = @"C:\Users\ramon\Downloads\";

        [TestMethod]
        public void TestMethod1()
        {

            Console.WriteLine("Test1");

            //IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser : {0}", config.GetBrowser());
            //Console.WriteLine("Browser : {0}", config.GetUsername());
            //Console.WriteLine("Browser : {0}", config.GetPassword());






            //Console.WriteLine(ConfigurationManager.AppSettings.Get("browser"));
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("username"));
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("password"));

            //Console.WriteLine((int)BrowserType.Chrome);
            //Console.WriteLine((int)BrowserType.Firefox);
            //Console.WriteLine((int)BrowserType.IEExplorer);



            //if (ConfigurationManager.AppSettings.Get("browser") == )
            //{

            //}

            //IWebDriver driver = new ChromeDriver();
            ////IWebDriver driver = new InternetExplorerDriver();
            ////IWebDriver driver = new FirefoxDriver(pathFirefoxDriver);
            //driver.Navigate().GoToUrl("http://localhost:5001/");
            //driver.Manage().Window.Maximize();
            //driver.Close();
            //driver.Quit();


        }
    }
}
