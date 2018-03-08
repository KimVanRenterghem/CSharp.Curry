using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Curry.Test
{
    [TestClass]
    public class ShooldCurry
    {

        private readonly _ _ = _.__;
        
        private static int Som(int i, int v)
        {
            return i + v;
        }

        [TestMethod]
        public void AfunctionWith2Parms()
        {
            Func<int, string, string> som = (i, s) => "" + i + s;

            var een = som(1, "0");

            var twee = som.Curry().Curry(1)("0");
            var drie = som.Curry(_, "0")(1);
            var vier = som.Curry("0")(1);

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }
        [TestMethod]
        public void AfunctionWithTheSame2Parms()
        {
            Func<int, int, int> som2 = Som;
            var een = Som(3, 6);
            var twee = som2.Curry(_, 6)(3);
            // zou niet moeten die cast moet hier nog rond werken
            var drie = ((Func<int, int, int>)Som).Curry(_, 6)(3);

            var vier = som2(3, 6);
            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }
        [TestMethod]
        public void AfunctionWith3Parms()
        {
            Func<int, string, bool, string> som = (i, s, b) => "" + i + s + (b ? "True" : "False");

            var een = som(1, "0", true);

            var twee = som.Curry(1)("0")(true);
            var drie = som.Curry(_, "0")(1)(true);
            var vier = som.Curry(true).Curry("0")(1);

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }

        [TestMethod]
        public void AfunctionWithTheSame3Parms()
        {
            Func<string, string, string, string> som = (i, s, b) => i + s + b;

            var een = som("1", "0", "3");

            var twee = som.Curry("1", _, _)("0")("3");
            var drie = som.Curry(_, "0")("1")("3");
            var vier = som.Curry(_, _, "3").Curry(_, "0")("1");

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }
        [TestMethod]
        public void AfunctionWith4Parms()
        {
            Func<int, string, bool, double, string> som = (i, s, b, d) => "" + i + s + (b ? "True" : "False") + d;

            var een = som(1, "0", true, 2.2);

            var twee = som.Curry(1)("0")(true)(2.2);
            var drie = som.Curry(2.2).Curry("0").Curry(1)(true);
            var vier = som.Curry(true).Curry(1).Curry(2.2)("0");

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }

        [TestMethod]
        public void AfunctionWithTheSame4Parms()
        {
            Func<string, string, string, string, string> som = (i, s, b, h) => i + s + b + h;

            var een = som("1", "0", "3", "4");

            var twee = som.Curry("1", _, _, _).Curry(_, "3", _)("0")("4");
            var drie = som.Curry(_, "0", _, _)("1").Curry(_, "4")("3");
            var vier = som.Curry(_, _, "3").Curry(_, "0")("1")("4");

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }
        [TestMethod]
        public void AfunctionWith5Parms()
        {
            Func<int, string, bool, double, char, string> som = (i, s, b, d, c) => "" + i + s + (b ? "True" : "False") + d + c;

            var een = som(1, "0", true, 2.2, 'B');

            var twee = som.Curry(2.2).Curry(1,true).Curry("0")('B');
            var drie = som.Curry(2.2)(1).Curry("0").Curry('B')(true);
            var vier = som.Curry(true).Curry("0", 2.2,'B')(1);

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }

        [TestMethod]
        public void AfunctionWithTheSame5Parms()
        {
            Func<string, string, string, string, string, string> som = (i, s, b, h, c) => i + s + b + h + c;

            var een = som("1", "0", "3", "4","9");

            var twee = som.Curry(_,"0", _, _, "9").Curry(_, "3", _)("1")("4");
            var drie = som.Curry("1", "0", _, _,"9").Curry(_, "4")("3");
            var vier = som.Curry(_, _, "3").Curry(_, "0","4", "9")("1");

            Assert.AreEqual(een, twee);
            Assert.AreEqual(vier, drie);
            Assert.AreEqual(vier, een);
        }
    }
}
