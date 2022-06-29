﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.SeleniumEasy
{
    public class BasicFirstFormDemoPage
    {

        public static void closeAdvertisment()
        {
            string locator = "//*[@id='at-cv-lightbox-close']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='display']";
           return Common.getElementText(locator);
        }

        public static void enterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.sendKeysToElement(locator, message);
        }

        public static void clickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.clickElement(locator);
        }

        public static void enterInputA(string input)
        {
            string locator = "//*[@id='sum1']";
            Common.sendKeysToElement(locator, input);
        }

        public static void enterInputB(string input)
        {
            string locator = "//*[@id='sum2']";
            Common.sendKeysToElement(locator, input);
        }

        public static void clickGetTotalButton()
        {
            string locator = "//*[@id='gettotal']/button";
            Common.clickElement(locator);
        }

        public static string readTotal()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.getElementText(locator);
        }
    }
}
