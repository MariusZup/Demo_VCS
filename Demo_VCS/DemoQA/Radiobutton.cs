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
using Tests.BaseClasses;

namespace Tests.DemoQA
{
    public class Radiobutton
    {
        public class RadioButton : BaseTest
        {
            [SetUp]
            public void openPage()
            {
                RadioButtonPage.open();
            }

            [Test]
            public void radioButton()
            {
                string expectedMessage = "Yes";

                RadioButtonPage.clickYesRadioButton();
                string actualMessage = RadioButtonPage.getMessage();

                Assert.IsTrue(actualMessage.Contains(expectedMessage));
            }
        }
    }
}
