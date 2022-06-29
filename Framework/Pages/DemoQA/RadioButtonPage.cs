﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.DemoQA
{
    public class RadioButtonPage
    {
       public static void clickYesRadioButton()
        {
            string locator = "//*[@for='yesRadio']";
            Common.clickElement(locator);

        }

        public static string getMessage()
        {
            string locator = "//*[@class='text-succes']";
            return Common.getElementText(locator);
        }
    }
}
