using System;
using Coypu;
using Coypu.Drivers;
using NUnit.Framework;

namespace PruebaCoypu
{
    [TestFixture]
    public class DLTests
    {
        [Test]
        public void QueEsTest()
        {
            var sessionConfig = new SessionConfiguration() {
                Browser = Browser.Chrome,
                AppHost = "www.dl.cl",
                Timeout = TimeSpan.FromSeconds(50)
            };
            var browser = new BrowserSession(sessionConfig);
            try
            {
                browser.Visit("");
                browser.ClickLink("que-es-dl");
            }
            finally
            {
                browser.Dispose();
            }
        }
    }
}
