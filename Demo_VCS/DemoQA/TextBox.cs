using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBoxPage = Framework.Pages.DemoQA.TextBoxPage;

namespace Demo_VCS
{
    public class TextBox
    {
        [SetUp]
        
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/text-box");
        }


        [Test]

        public static void demoQATextBox()
        {
            string expectedName = "Martynas";
            string expectedEmail = "email.email@com";

            TextBoxPage.enterFullName(expectedName);
            TextBoxPage.enterEmail(expectedEmail);
            TextBoxPage.clickSubmitButton();
            string actualName = TextBoxPage.getNameAfterSubmit();
            string actualEmail = TextBoxPage.getEmailAfterSubmit();

            Assert.IsTrue(actualName.Contains(expectedName));
            Assert.IsTrue(actualEmail.Contains(expectedEmail));

        }

        [TearDown]

        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
