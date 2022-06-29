﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.DemoQA
{
   public class ButtonsPage
    {
        public static void leftClick()
        {
            string locator = "//*[text()='Click Me']";
            Common.clickElement(locator);
        }

        public static string readMessageLeftClick()
        {
            string locator = "//*[@id='dynamicClickMessage']";
            return Common.getElementText(locator);
        }

        public static void rightClick()
        {
            string locator = "//*[@id='rightClickBtn']";
            Common.performRightClick(locator);
        }

        public static string readMessageRightClick()
        {
            string locator = "//*[@id='rightClickMessage']";
            return Common.getElementText(locator);
        }
    }
}
