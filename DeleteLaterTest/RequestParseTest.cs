using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EQRSWin;

namespace DeleteLaterTest
{
    [TestClass]
    public class RequestParseTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            SMSRouter router = new SMSRouter(null);
            var wat = router.Parse("CRIM::murder::101.12::86.32::01234567890");
            Assert.IsTrue(wat.ResponderCode == "CRIM");
            Assert.IsTrue(wat.EmergencyDetail == "MURDER");
            Assert.IsTrue(wat.Latitude == 101.12);
            Assert.IsTrue(wat.Longitude == 86.32);
            Assert.IsTrue(wat.PhoneNumber == "01234567890");
        }
    }
}
