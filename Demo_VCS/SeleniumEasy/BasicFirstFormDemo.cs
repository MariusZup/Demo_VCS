﻿using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VCS.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-first-form-demo.html");
            BasicFirstFormDemoPage.closeAdvertisment();
        }

        [Test]

        public static void singleInputField()
        {
            string expectedMessage = "Test";
            string actualMessage;

            BasicFirstFormDemoPage.enterMessage(expectedMessage);
            BasicFirstFormDemoPage.clickShowMessageButton();
            actualMessage = BasicFirstFormDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }


        [Test]

        public static void twoInputFields()
        {
            string inputA = "5";
            string inputB = "7";
            string expectedTotal = "12";
            string actualTotal;

            BasicFirstFormDemoPage.enterInputA(inputA);
            BasicFirstFormDemoPage.enterInputB(inputB);
            BasicFirstFormDemoPage.clickGetTotalButton();
            actualTotal = BasicFirstFormDemoPage.readTotal();

            Assert.AreEqual(expectedTotal, actualTotal);

        }




        [TearDown]

        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
