using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTheLongestSequence;

namespace TestFindTheLongestSequence
{
    [TestClass]
    public class FindTheLongestSequenceTests
    {
        [TestMethod]
        public void TestFindSequence1()
        {
            int[,] testArray = { { 0, 1, 0, 1, 1 },
                                 { 1, 0, 0, 1, 1 },
                                 { 1, 1, 1, 0, 0 },
                                 { 0, 0, 0, 0, 1 },
                                 { 1, 1, 0, 0, 1 }};
            int sequence = BinaryMatrix.FindSequence(testArray);
            Assert.AreEqual(3, sequence);
        }
        [TestMethod]
        public void TestFindSequence2()
        {
            int[,] testArray = { { 0, 1, 0, 1, 1 },
                                 { 1, 1, 0, 1, 1 },
                                 { 1, 1, 1, 0, 0 },
                                 { 0, 1, 0, 0, 1 },
                                 { 1, 1, 0, 0, 1 }};
            int sequence = BinaryMatrix.FindSequence(testArray);
            Assert.AreEqual(5, sequence);
        }

        [TestMethod]
        public void TestFindSequence3()
        {
            int[,] testArray = { { 0, 1, 0, 1, 1 },
                                 { 1, 0, 0, 1, 1 },
                                 { 1, 1, 1, 1, 1 },
                                 { 0, 1, 0, 0, 0 },
                                 { 1, 1, 0, 0, 1 }};
            int sequence = BinaryMatrix.FindSequence(testArray);
            Assert.AreEqual(5, sequence);
        }
    }
}
