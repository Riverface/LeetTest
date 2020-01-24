using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testpractice.Tests
{
    [TestClass]
    public class LeetTests
    {
        [TestMethod]
        public void ChangeTest()
        {
            string tI = "I hate mondays";
            Assert.AreNotEqual(tI, Leetspeak.Leet(tI));
        }
        [TestMethod]
        public void AccurateTest()
        {
            string tI = "I hate mondays";
            string lTI = "1 h473 m0nd4yz";
            Assert.AreEqual(lTI, Leetspeak.Leet(tI));
        }
    }
}