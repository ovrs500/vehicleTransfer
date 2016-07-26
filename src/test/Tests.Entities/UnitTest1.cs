using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Entities
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Text.RegularExpressions.Regex expression = new System.Text.RegularExpressions.Regex(@"[A-Za-z0-9]\d\d\d\d\d");
            var output = expression.IsMatch("s7y44dfasdf2fasdf2l55555");
            var x = 9;
        }
    }
}