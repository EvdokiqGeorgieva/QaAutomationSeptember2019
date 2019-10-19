using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject
{
    public static class Extensions
    {
        public static void Type (this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
