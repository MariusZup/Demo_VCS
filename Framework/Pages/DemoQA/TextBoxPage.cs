using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.DemoQA
{
    public class TextBoxPage
    {
        public static void enterFullName(string name)
        {
            string locator = "//*[@id='userName']";
            Common.getElement(locator).SendKeys(name);
        }

        public static void enterEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.getElement(locator).SendKeys(email);
        }
        public static void clickSubmitButton()
        {
            string locator = "//*[@id='submit']";
            Common.getElement(locator).Click();
        }

        public static string getNameAfterSubmit()
        {
            string locator = "//*[@id='name']";
            return Common.getElement(locator).Text;
        }

        public static string getEmailAfterSubmit()
        {
            string locator = "//*[@id='email']";
            return Common.getElement(locator).Text;
        }
    }
}
