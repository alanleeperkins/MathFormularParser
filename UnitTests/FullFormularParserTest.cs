using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFormularParser;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class FullFormularParserTest
    {
        [TestMethod]
        public void TokenizerTest()
        {
            var testString = "10 + 20 - 30.123";
            var t = new Tokenizer(new StringReader(testString));

            // "10"
            Assert.AreEqual(t.Token, eToken.Number);
            Assert.AreEqual(t.Number, 10);
            t.NextToken();

            // "+"
            Assert.AreEqual(t.Token, eToken.Add);
            t.NextToken();

            // "20"
            Assert.AreEqual(t.Token, eToken.Number);
            Assert.AreEqual(t.Number, 20);
            t.NextToken();

            // "-"
            Assert.AreEqual(t.Token, eToken.Subtract);
            t.NextToken();

            // "30.123"
            Assert.AreEqual(t.Token, eToken.Number);
            Assert.AreEqual(t.Number, 30.123);
            t.NextToken();
        }

        [TestMethod]
        public void AddSubtractTest()
        {
            // add
            Assert.AreEqual(Parser.Parse("10 + 20").Eval(null), 30);

            // subtract 
            Assert.AreEqual(Parser.Parse("10 - 20").Eval(null), -10);

            // sequence
            Assert.AreEqual(Parser.Parse("10 + 20 - 40 + 100").Eval(null), 90);
        }

        [TestMethod]
        public void UnaryTest()
        {
            // negative
            Assert.AreEqual(Parser.Parse("-10").Eval(null), -10);

            // positive
            Assert.AreEqual(Parser.Parse("+10").Eval(null), 10);

            // negative of a negative
            Assert.AreEqual(Parser.Parse("--10").Eval(null), 10);

            // whaahoooo!
            Assert.AreEqual(Parser.Parse("--++-+-10").Eval(null), 10);

            // all together now
            Assert.AreEqual(Parser.Parse("10 + -20 - +30").Eval(null), -40);
        }

        [TestMethod]
        public void MultiplyDivideTest()
        {
            // multiply 
            Assert.AreEqual(Parser.Parse("10 * 20").Eval(null), 200);

            // divide 
            Assert.AreEqual(Parser.Parse("10 / 20").Eval(null), 0.5);

            // sequence
            Assert.AreEqual(Parser.Parse("10 * 20 / 50").Eval(null), 4);
        }

        [TestMethod]
        public void OrderOfOperation()
        {
            // no parentheses
            Assert.AreEqual(Parser.Parse("10 + 20 * 30").Eval(null), 610);

            // parentheses
            Assert.AreEqual(Parser.Parse("(10 + 20) * 30").Eval(null), 900);

            // parentheses and negative
            Assert.AreEqual(Parser.Parse("-(10 + 20) * 30").Eval(null), -900);

            // nested
            Assert.AreEqual(Parser.Parse("-((10 + 20) * 5) * 30").Eval(null), -4500);
        }

        [TestMethod]
        public void Reflection()
        {
            // get our library and a reflection that uses it
            var lib = new Library();
            var ctx = new ReflectionContext(lib);

            Assert.AreEqual(Parser.Parse("((10*10) * PI) ").Eval(ctx), Math.PI * 100);
            Assert.AreEqual(Parser.Parse("sqrt(8)").Eval(ctx), Math.Sqrt(8));
            Assert.AreEqual(Parser.Parse("abs(-8.2)").Eval(ctx), Math.Abs(-8.2));
            Assert.AreEqual(Parser.Parse("ceiling(8.56)").Eval(ctx), Math.Ceiling(8.56));
            Assert.AreEqual(Parser.Parse("floor(8.56) + 10*10 +1").Eval(ctx), Math.Floor(8.56) + 10 * 10 + 1);
        }
    }
}
