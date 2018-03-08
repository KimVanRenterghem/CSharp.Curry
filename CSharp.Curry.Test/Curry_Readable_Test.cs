using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Curry.Test
{
    [TestClass]
    public class Curry_Readable_Test
    {

        private readonly _ _ = _.__;
        private static IEnumerable<int> Get() => new[] { 1, 2, 3 };


        [TestMethod]
        public void SameParams()
        {
            Func<int, int, int> Add = (x, y) => x + y;

            var res = Get()
                .Select(Add.Curry(3, _))
                .Aggregate(0, Add);

            Assert.AreEqual((1 + 3) + (2 + 3) + (3 + 3), res);
        }
        [TestMethod]
        public void DiferendParams()
        {
            Func<int, int, int> Add = (x, y) => x + y;
            Func<string, int, string> toString = (x, y) => x + y;

            var res = Get()
                .Select(Add.Curry(3, _))
                .Select(toString.Curry("Kim "))
                .ToArray();

            Assert.AreEqual("Kim " + (1 + 3), res[0]);
            Assert.AreEqual("Kim " + (2 + 3), res[1]);
            Assert.AreEqual("Kim " + (3 + 3), res[2]);
        }
    }
}
