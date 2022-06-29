using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VCS.DemoQA
{
    internal class Radiobutton
    {

        [OneTimeSetUp]
        public void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/radio-button");
        }

        [Test]
        public void radioButton()
        {
            string expectedMessage = "Yes";

            RadioButtonPage.clickYesRadioButton();
            string actualMessage = RadioButtonPage.getMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }

        [OneTimeTearDown]
        public void close()
        {
            Driver.closeDriver();
        }
    }
}
