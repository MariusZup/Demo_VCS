using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VCS.SeleniumEasy
{
    internal class BasicCheckBoxDemo
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        [Test]
        public static void singleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";
            string actualMessage;

            BasicCheckBoxDemoPage.clickSingleCheckbox();
            actualMessage = BasicCheckBoxDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
