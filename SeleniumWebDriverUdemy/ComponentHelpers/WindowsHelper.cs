using SeleniumWebDriverUdemy.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverUdemy.ComponentHelpers
{
    public class WindowsHelper
    {   
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
