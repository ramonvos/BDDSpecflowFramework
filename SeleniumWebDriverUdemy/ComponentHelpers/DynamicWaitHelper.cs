using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class DynamicWaitHelper
    {
        private static IWebDriver driver;

        public void DynamicWait(By locator, string par, string text)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            if (par == "waitSearchbox" )
            {
                wait.Until(waitSearchbox(locator));
            }
            else if (par == "waitSearchbox")
            {
                wait.Until(waitForTitle(text));
            }

            else if (par == "waitForElement")
            {
                wait.Until(waitForElement(locator));
            }

        }

        private Func<IWebDriver,bool> waitSearchbox(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator).Count == 1;
            });
        }

        

        private Func<IWebDriver, string> waitForTitle(string title)
        {
            return ((x) =>
            {
                if (x.Title.Contains(title))
                    return title;
                return null;
                
            });
        }

        private Func<IWebDriver, IWebElement> waitForElement(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
                    
            });
        }
    }
}
