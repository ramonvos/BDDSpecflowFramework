using OpenQA.Selenium;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class JavaScriptExecutorHelper
    {   

        public static void ExecuteJavaScript(string script)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);

            executor.ExecuteScript(script);
        }

        public static void ExecuteAsyncJavaScript(string script)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);

            executor.ExecuteAsyncScript(script);
        }
    }
}
