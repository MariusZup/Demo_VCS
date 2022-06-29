using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;


        public static void setDriver()
        {
            IWebDriver driver = new ChromeDriver();
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
