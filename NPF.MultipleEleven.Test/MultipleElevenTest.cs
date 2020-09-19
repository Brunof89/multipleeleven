using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPF.MultipleEleven.Domain;
using System;
using System.Linq;

namespace NPF.MultipleEleven.Test
{
    [TestClass]
    public class MultipleElevenTest
    {
        [TestMethod]
        public void CheckIsNumber()
        {
            MultipleElevenService srv = new MultipleElevenService();
            Assert.IsTrue(srv.isNumber("123"));
        }

        [TestMethod]
        public void CheckIsMultipleEleven()
        {
            MultipleElevenService srv = new MultipleElevenService();
            var rsp = srv.Check(new Domain.Requests.MultipleElevenRequestDto { numbers = new string[] { "11" } });
            Assert.IsTrue(rsp.result.FirstOrDefault().isMultiple);
        }

        [TestMethod]
        public void CheckIsNotMultipleEleven()
        {

            MultipleElevenService srv = new MultipleElevenService();
            var rsp = srv.Check(new Domain.Requests.MultipleElevenRequestDto { numbers = new string[] { "12" } });
            Assert.IsFalse(rsp.result.FirstOrDefault().isMultiple);
        }
    }
}
