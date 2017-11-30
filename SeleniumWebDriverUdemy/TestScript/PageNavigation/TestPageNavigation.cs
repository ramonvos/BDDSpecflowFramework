using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriverUdemy.ComponentHelpers;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.TestScript.PageNavigation
{   
    [TestClass]
    public class TestPageNavigation
    {
        public object NavigatioHelper { get; private set; }

        [TestMethod]
        public void OpenPage()
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());

            //ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title page is : {0}", WindowsHelper.GetTitle());
        }
    }
}
