using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using SeleniumWebDriverUdemy.Configuration;
using SeleniumWebDriverUdemy.CustomException;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.BaseClasses
{   
    [TestClass]
    public class BaseClass
    {
        public static string pathFirefoxDriver = @"C:\Users\ramon\Downloads\";

        private static FirefoxProfile GetFirefoxProfile()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();

            profile.SetPreference("webdriver.gecko.driver", @"C:\Users\ramon\Downloads\geckodriver.exe");

            profile = manager.GetProfile("default");
            
            return profile;
        }

        private static FirefoxOptions GetFirefoxOptions()
        {

            var url = new Uri("http://10.6.122.49:5555/wd/hub");

            var options = new FirefoxOptions();
            options.SetPreference("webdriver.gecko.driver", pathFirefoxDriver);

            var driver = new RemoteWebDriver(url, options.ToCapabilities());


            //FirefoxOptions option = new FirefoxOptions();
            //option.SetPreference("webdriver.gecko.driver", @"C:\Users\ramon\Downloads\geckodriver.exe");
            return options;

        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;

        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver(pathFirefoxDriver);
            return driver; 
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.IEExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found : "+ ObjectRepository.Config.GetBrowser().ToString());
                    
            }
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
