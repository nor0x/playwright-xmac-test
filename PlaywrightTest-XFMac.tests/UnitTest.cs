using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace PlaywrightTest_XFMac.tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCLILocation()
        {
            var path = "../../../../PlaywrightTest-XFMac.macOS/bin/Debug/PWTest.app/Contents/MonoBundle/package/lib/cli/cli.js";
            var exists = File.Exists(path);
            Assert.IsTrue(exists);
        }
    }
}
