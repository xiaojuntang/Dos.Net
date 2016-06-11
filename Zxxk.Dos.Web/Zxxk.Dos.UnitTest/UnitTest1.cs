using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zxxk.Dos.DataModel;
using Zxxk.Dos.DataAccess;

namespace Zxxk.Dos.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Answer an = new Answer();
            an.HomeWorkID = 1;
            an.OpenID = "eeeeeeeeeeeeeeee";

            int a1 = AnswerService.Insert(an);
        }
    }
}
