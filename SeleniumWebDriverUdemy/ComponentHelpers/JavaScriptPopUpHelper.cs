using OpenQA.Selenium;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class JavaScriptPopUpHelper
    {   
        public static bool IsPopUpPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetPopUpText()
        {
            if (!IsPopUpPresent())
                return "";
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        }

        public static void ClickOkPopUp()
        {
            if (!IsPopUpPresent())
                return;
         ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }

        public static void ClickCancelPopUp()
        {
            if (!IsPopUpPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
        }

        public static void SendKeysPopUp(string text)
        {
            if (!IsPopUpPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
