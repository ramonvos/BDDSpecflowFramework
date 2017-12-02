using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class MouseOverHelper
    {   

        public static void MouseOverClickContext(By locator)
        {
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(locator);
            act.ContextClick(ele)
                .Build()
                .Perform();

            //Thread.Sleep(5000);
            

        }

        public static void MouseOverDranNDrop(By locatorSrc, By locatorTar)
        {
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(locatorSrc);
            IWebElement tar = ObjectRepository.Driver.FindElement(locatorTar);
            act.DragAndDrop(src,tar)
                .Build()
                .Perform();

            //Thread.Sleep(5000);


        }

        public static void MouseOverClickNHold(By locatorSrc, By locatorTar)
        {
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(locatorSrc);
            IWebElement tar = ObjectRepository.Driver.FindElement(locatorTar);
            act.ClickAndHold(src)
                .MoveToElement(tar, 0, 30)
                .Release()
                .Build()
                .Perform();

            Thread.Sleep(10000);


        }
    }
}
