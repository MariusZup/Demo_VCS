using Framework;
using Framework.Pages.ArmyShop;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VCS.ArmyShop
{
    public class ArmyShop
    {

        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.army-shop.lt/");
        }

        [Test]

        public static void Blogas()
        {
            string expectedMessage = "CARINTHIA - sukurta Jūsų saugumui ir komfortui";
            string acctualMessage;

            ArmyShopPage.clickBlogas();
            acctualMessage = ArmyShopPage.readMessage();

            Assert.AreEqual(expectedMessage, acctualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
