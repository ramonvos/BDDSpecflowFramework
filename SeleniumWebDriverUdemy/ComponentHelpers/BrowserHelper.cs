using OpenQA.Selenium;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class BrowserHelper
    {
        private static IWebDriver driver;
        
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void BrowserGoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void BrowserForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }


        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchElementException("Invalid Browser Window Index " + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();

        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));
            

        }
    }
}
