using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Demo_VCS.SeleniumEasy
{
    public class JavaScriptAlerts
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        [Test]
        public static void acceptAlertBox()
        {
            JavaScriptAlertPage.clickButtonToOpenAlertBox();
            JavaScriptAlertPage.clickOkInAlertBox();

            // Assert ?! :/
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
