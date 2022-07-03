using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.ArmyShop
{
    public class ArmyShopPage
    {
        public static void closeAdvertisment()
        {
            string locator = "//*[@id='sbox - btn - close']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
        }

        public static void Blogas()
        {
            string locator = "//*[@id='position_menu1']/div/div/div/div/ul/li[5]/a/span";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='content']/div[1]/div[1]/div/div[1]/div[1]/a";
            return Common.getElementText(locator);
        }
    }
}
