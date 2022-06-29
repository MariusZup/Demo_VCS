using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.SeleniumEasy
{
    public class BasicSelectDropDownDemoPage
    {
        public static void selectDayByValue(string value)
        {
            string locator = "//*[@id='select-demo']";
            Common.selectOptionByValue(locator, value);
        }

        public static string readSelectedDay()
        {
            string locator = "//*[@class='selected-value']";
            return Common.getElementText(locator);
        }
    }
}
