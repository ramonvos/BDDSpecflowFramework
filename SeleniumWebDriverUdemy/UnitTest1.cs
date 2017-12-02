using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using SeleniumWebDriverUdemy.Configuration;
using SeleniumWebDriverUdemy.Interfaces;
using SeleniumWebDriverUdemy.Settings;
using SeleniumWebDriverUdemy.ComponentHelpers;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.Extensions;
using SeleniumWebDriverUdemy.BaseClasses;

namespace SeleniumWebDriverUdemy
{
    [TestClass]
    public class UnitTest1
    {
        String pathFirefoxDriver = @"C:\Users\ramon\Downloads\";

        [TestMethod]
        public void TestMethod1()
        {
            //NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //try
            //{   

            //    ReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("input"));
            //    Console.WriteLine("size : {0}", col.Count);
                


            //}
            //catch (Exception e)
            //{

                
            //    Console.WriteLine("---------");
            //    Console.WriteLine(e.Message);
            
            //    Console.WriteLine("---------");
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("Test1");

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


        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));

            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            //TextBoxHelper.ClearTextBox(By.Id("Bugzilla_password"));

            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));


            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine("Text : {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));

            GenericHelper.WaitForWebElement(By.Name("component"), TimeSpan.FromSeconds(30));
            IWebElement element = GenericHelper.WaitForWebElementInPage(By.Name("component"), TimeSpan.FromSeconds(30));



            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.jpeg");

        }

        [TestMethod]
        public void dragdrop()
        {
            NavigationHelper.NavigateToUrl("http://demos.telerik.com/kendo-ui/dragdrop/events");

            //MouseOverHelper.MouseOverClickContext(By.Id("draggable"));

            //MouseOverHelper.MouseOverDranNDrop(By.Id("draggable"), By.Id("droptarget"));
            MouseOverHelper.MouseOverClickNHold(By.Id("draggable"), By.Id("droptarget")); 



        }
    }
}
