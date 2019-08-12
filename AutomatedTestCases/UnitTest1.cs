using NUnit.Framework;      // 

namespace Tests {
    public class TestFunctions {


        Functions functions = null;     // variable type functions that creates 

        [SetUp]         //  use for things that you only have to do once.  Has to call methods in library
        public void Setup() {
            functions = new Functions();

        }

        [Test]              // All have to be public, void w/no parmeters.  Must have [Test] annotation
        public void Test1() {

            Assert.Pass();
        }

        public void InternalMethod() {              // Can have other methods without [Test] annotation.  They won't run

        }

        [Test]
        public void TestXSquaredPlus3() {
            // test input 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);

            // test input 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
        }

        [Test]
        public void TestX7X12() {
            //test zero
            var ans = functions.XX7X12(0);
            Assert.AreEqual(12, ans);
            // test one
            ans = functions.XX7X12(1);
            Assert.AreEqual(6, ans);
            // test neg. one
            Assert.AreEqual(20, functions.X7X12(-1));
        }
    }
}