namespace Framework.Pages.SeleniumEasy
{
    public class JavaScriptAlertPage
    {
        public static void clickButtonToOpenAlertBox()
        {
            string locator = "//*[@onclick='myAlertFunction()']";
            Common.clickElement(locator);
        }

        public static void clickOkInAlertBox()
        {
            Common.alertAccept();
        }
    }
}
