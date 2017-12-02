using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriverUdemy.ComponentHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);

        }

        public static void SelectElement(By locator, string visibleText)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(visibleText);

        }

        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();

        }

        public static void SelectElement(IWebElement element, string visibleText)
        {
            select = new SelectElement(element);
            select.SelectByValue(visibleText);

        }
    }
}
