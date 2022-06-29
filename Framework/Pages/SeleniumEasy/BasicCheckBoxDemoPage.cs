using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.SeleniumEasy
{
    public class BasicCheckBoxDemoPage
    {
        public static void clickSingleCheckbox()
        {
            string locator = "//*[@id='isAgeSelected']";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='txtAge']";
            return Common.getElementText(locator);
        }
    }
}
