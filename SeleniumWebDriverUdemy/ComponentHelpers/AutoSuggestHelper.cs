using OpenQA.Selenium;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class AutoSuggestHelper
    {
        private static IWebElement driver;

        public static void SelectAutoSuggest(By locatorSrc, string text, By locatorTar)
        {
            IWebElement ele = ObjectRepository.Driver.FindElement(locatorSrc);
            ele.SendKeys(text);
            Thread.Sleep(1000);

            var wait = GenericHelper.GetWebdriverWait(TimeSpan.FromSeconds(40));
             IList<IWebElement> elements = wait.Until(GetAllElement(locatorTar));
        }

        private static Func<IWebDriver, IList<IWebElement>> GetAllElement (By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
                
                
        }
    }
}
