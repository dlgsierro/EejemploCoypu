using System;
using Coypu;
using Coypu.Drivers;
using NUnit.Framework;

namespace PruebaCoypu
{
    [TestFixture]
    public class TuleapTests
    {
        [Test]
        public void LoginTest()
        {
            var sessionConfig = new SessionConfiguration() {
                Browser = Browser.Chrome,
                AppHost = "dltuleap.dl.cl",
                Timeout = TimeSpan.FromSeconds(50)
            };
            var browser = new BrowserSession(sessionConfig);
            try
            {
                browser.Visit("");
                browser.FindField("Username").FillInWith("gsierro");
                browser.FindField("Password").FillInWith("Gasr3673");
                browser.ClickButton("Login");
            }
            finally
            {
                browser.Dispose();
            }
        }
    }
}
